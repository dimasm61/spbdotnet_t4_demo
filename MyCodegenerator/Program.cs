using System;
using static System.Console;

namespace MyCodegenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameSpace  = args[0]; // MyCodegeneratorUsing
            var enumName   = args[1]; // DemoCountryEnum
            var enumValues = args[2]; // AUS:Australia;AUT:Austria;BHR:Bahrain

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





