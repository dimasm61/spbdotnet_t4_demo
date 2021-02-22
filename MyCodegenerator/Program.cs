using System;

namespace MyCodegenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameSpace = (args.Length > 0) ? args[0] : "defaultNamespace";
            var enumName = (args.Length > 1) ? args[1] : "defaultEnumName";
            var enumValues = (args.Length > 2) ? args[2] : "defValue1:;defValue2:";

            var enumValues2 = enumValues.Split(';');

            Console.WriteLine($"namespace {nameSpace}");
            Console.WriteLine($"{{");
            {
                Console.WriteLine($"    public enum {enumName}");
                Console.WriteLine($"    {{");
                {
                    foreach (var e in enumValues2)
                    {
                        var a = e.Split(':');
                        Console.WriteLine($"");
                        Console.WriteLine($"        /// <summary>{a[1]}</summary>");
                        Console.WriteLine($"        {a[0]},");
                    }

                }
                Console.WriteLine($"    }}");
            }
            Console.WriteLine($"}}");
        }
    }
}
