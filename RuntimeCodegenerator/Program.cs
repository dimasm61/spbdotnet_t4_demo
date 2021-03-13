using System;

namespace RuntimeCodegenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var template = new RuntimeTextTemplate1();

            var str = template.TransformText();

            Console.WriteLine(str);

            Console.ReadLine();
        }
    }
}
