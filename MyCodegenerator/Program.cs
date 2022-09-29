using System;
using System.IO;
using static System.Console;

namespace MyCodegenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            // цель - генерация перечисления со странами

            // C:\Git\spbdotnet_t4_demo\MyCodegenerator\bin\Debug\net5.0\MyCodegenerator.exe > C:\Git\spbdotnet_t4_demo\MyCodegeneratorUsing\DemoCountryEnum.cs

            var nameSpace  = "MyCodegeneratorUsing";
            var enumName   = "DemoCountryEnum";
            var enumValues = "AUS:Australia;AUT:Austria;BHR:Bahrain";//;"RUS:Russia";

            var metadata = enumValues.Split(';');

            WriteLine($"namespace {nameSpace}");
            WriteLine($"{{");

            {
                WriteLine($"    public enum {enumName}");
                WriteLine($"    {{");

                {
                    foreach (var a in metadata)
                    {
                        var b = a.Split(':');
                        WriteLine($"");
                        WriteLine($"        /// <summary>{b[1]}</summary>");
                        WriteLine($"        {b[0]},");
                    }

                }

                WriteLine($"    }}");
            }

            WriteLine($"}}");

        }
    }
}





