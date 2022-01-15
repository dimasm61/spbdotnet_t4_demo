using System;
using BenchmarkDotNet.Running;

namespace Simple_TestBenchmark
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
