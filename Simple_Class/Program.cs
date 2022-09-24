using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Running;

namespace Simple_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            BenchmarkRunner.Run<TestBenchmark>();
            Console.ReadLine();
        }
    }
}
