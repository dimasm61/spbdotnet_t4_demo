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

            //DemoCarClass item = new DemoCarClass
            //{
            //    CarBuildYear = 2007,
            //    Model = "Niva",
            //    CarGuid = Guid.NewGuid(),
            //    SaleDate = DateTime.Now
            //};

            //var f = item.SaleDate.ToString("yyyy-MM-ddTHH:mm:ss.fffffffK");

            //var s = item.ToT4JsonWithSb();
        }
    }
}
