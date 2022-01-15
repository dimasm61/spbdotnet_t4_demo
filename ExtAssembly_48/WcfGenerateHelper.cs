using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace ExtAssembly_48
{
    public static class WcfGenerateHelper
    {
        public class MetadataItem
        {
            public string ReturnType { get; set; }
            public string Comment { get; set; }
            public string Name { get; set; }
            public List<string> ArgList { get; set; }

            public string ArgListStr
            {
                get
                {
                    // return string "int arg1, int arg2, int arg3"
                    return ArgList.Select(s => s.Replace(":", " ")).Aggregate((i, j) => i + ", " + j);
                }
            }

            public string ArgListWithoutTypeStr
            {
                get
                {
                    // return string "arg1, arg2, arg3"
                    return ArgList.Select(s => s.Split(':')[1]).Aggregate((i, j) => i + ", " + j);
                }
            }
        }

        public static void GenerateInterfaceWrapper(object ttContext, string fileName)
        {
            var tt = TextTransformationProxy.GetProxy(ttContext);

            var str = File.ReadAllText(fileName);

            var items = JsonSerializer.Deserialize<List<MetadataItem>>(str);

            foreach (var a in items)
            {
                tt.WriteLine($"        /// <summary>{a.Comment}</summary>");
                tt.WriteLine($"        {a.ReturnType} {a.Name} ({a.ArgListStr});");
            }
        }

        public static void GenerateServiceWrapper(object ttContext, string fileName)
        {
            var tt = TextTransformationProxy.GetProxy(ttContext);

            var str = File.ReadAllText(fileName);

            var items = JsonSerializer.Deserialize<List<MetadataItem>>(str);

            foreach (var a in items)
            {
                GenerateWrapperMethod(tt, a);
            }
        }

        private static void GenerateWrapperMethod(TextTransformationProxy tt, MetadataItem item)
        {

            tt.WriteLine($"/// <summary>{item.Comment}</summary> ");
            tt.WriteLine($"public {item.ReturnType} {item.Name}({item.ArgListStr})");
            tt.WriteLine($"{{");
            tt.PushIndent("    ");
            {
                tt.WriteLine(
                    $"if (LogInformationEnabled) _logger.Information(\"{{Method}} start\", nameof({item.Name}));");
                tt.WriteLine($"Stopwatch sw = null;");
                tt.WriteLine($"if(LogVerboseEnabled || LogDebugEnabled)");
                tt.WriteLine($"    sw = Stopwatch.StartNew();");
                tt.WriteLine($"try");
                tt.WriteLine($"{{");
                tt.PushIndent("    ");
                {
                    tt.WriteLine($"if (LogVerboseEnabled) ");
                    tt.WriteLine($"    _logger.Verbose($\"{{{{Method}}}} args: \"");
                    foreach (var argStr in item.ArgList)
                    {
                        var argName = argStr.Split(':')[1];
                        tt.WriteLine($"    + $\"{argName}:{{{argName}}}, \"");
                    }

                    tt.WriteLine($"    , nameof({item.Name}));");
                    tt.WriteLine($"");

                    tt.WriteLine($"return _policy.Execute(() => ");
                    tt.WriteLine($"    {{");
                    tt.WriteLine($"        using (var db = new DbContext()) ");
                    tt.WriteLine($"        {{");
                    tt.WriteLine($"            return _impl.{item.Name}(db, {item.ArgListWithoutTypeStr});");
                    tt.WriteLine($"        }}");
                    tt.WriteLine($"    }});");
                }
                tt.PopIndent();
                tt.WriteLine($"}}");
                tt.WriteLine($"catch(BrokenCircuitException bcex)");
                tt.WriteLine($"{{");
                tt.WriteLine(
                    $"    _logger.Warning($\"{{{{Method}}}} {{nameof(BrokenCircuitException)}}, return empty\", nameof({item.Name}));");
                tt.WriteLine($"    return new {item.ReturnType}();");
                tt.WriteLine($"}}");
                tt.WriteLine($"catch(Exception ex)");
                tt.WriteLine($"{{");
                tt.WriteLine($"    _logger.Error(ex, nameof({item.Name}));");
                tt.WriteLine($"    return new {item.ReturnType}();");
                tt.WriteLine($"}}");
                tt.WriteLine($"finally");
                tt.WriteLine($"{{");
                tt.WriteLine($"    if(LogVerboseEnabled || LogDebugEnabled) ");
                tt.WriteLine($"    {{");
                tt.WriteLine($"        sw.Stop();");
                tt.WriteLine(
                    $"        _logger.Debug(\"{{Method}} finish, {{Duration}} ms\", nameof({item.Name}), sw.ElapsedMilliseconds);");
                tt.WriteLine($"    }}");
                tt.WriteLine($"}}");
            }
            tt.PopIndent();
            tt.WriteLine($"}}");
        }


        public static void GenerateClient(object ttContext, string fileName)
        {
            var tt = TextTransformationProxy.GetProxy(ttContext);
            
            var str = File.ReadAllText(fileName);

            var items = JsonSerializer.Deserialize<List<MetadataItem>>(str);

            foreach (var a in items)
            {
                GenerateClientMethod(tt, a);
            }
        }

        private static void GenerateClientMethod(TextTransformationProxy tt, MetadataItem item)
        {
            tt.WriteLine($"/// <summary>{item.Comment}</summary> ");
            tt.WriteLine($"public {item.ReturnType} {item.Name}({item.ArgListStr})");
            tt.WriteLine($"{{");
            tt.PushIndent("    ");
            {
                tt.WriteLine($"return _policy.Execute(() => base.Channel.{item.Name}({item.ArgListWithoutTypeStr}));");
            }
            tt.PopIndent();
            tt.WriteLine($"}}");
        }
    }
}