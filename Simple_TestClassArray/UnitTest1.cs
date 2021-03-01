using System;
using System.Diagnostics;
using System.Linq;
using Xunit;
using Xunit.Abstractions;

namespace Simple_TestClassArray
{
    public partial class UnitTest1
    {
        private readonly ITestOutputHelper output;

        public UnitTest1(ITestOutputHelper output)
        {
            this.output = output;
        }

        [Fact]
        public void LinqWhereByModelKeyTest()
        {
            var arr1 = testArray;
            var list2 = testArray.ToList();

            var sw = Stopwatch.StartNew();
            for (var i = 0; i < randomModelKeyArray.Length; i++)
            {
                var cars = arr1.Where(c => c.ModelKey == randomModelKeyArray[i]);
                //if (cars == null) throw new Exception();
            }
            sw.Stop();

            output.WriteLine($"Where in Array: {sw.ElapsedMilliseconds} ms");

            sw.Restart();

            for (var i = 0; i < randomModelKeyArray.Length; i++)
            {
                var cars = list2.Where(c => c.ModelKey == randomModelKeyArray[i]);
                //if (cars == null) throw new Exception();
            }
            sw.Stop();

            output.WriteLine($"Where in List: {sw.ElapsedMilliseconds} ms");
        }

        [Fact]
        public void LinqFindByModelKeyTest()
        {
            var arr1 = testArray;
            var list2 = testArray.ToList();
            var dict2 = testArray.ToDictionary(c => c.Key);

            var sw = Stopwatch.StartNew();
            for (var i = 0; i < randomKeyArray.Length; i++)
            {
                var car = arr1.FirstOrDefault(c => c.Key == randomKeyArray[i]);
            }
            sw.Stop();

            output.WriteLine($"FirstOrDefault in Array: {sw.ElapsedMilliseconds} ms");

            sw.Restart();
            for (var i = 0; i < randomKeyArray.Length; i++)
            {
                var car = list2.FirstOrDefault(c => c.Key == randomKeyArray[i]);
            }
            sw.Stop();

            output.WriteLine($"FirstOrDefault in List: {sw.ElapsedMilliseconds} ms");

            sw.Restart();
            for (var i = 0; i < randomKeyArray.Length; i++)
            {
                var car = dict2[randomKeyArray[i]];
            }
            sw.Stop();

            output.WriteLine($"FirstOrDefault in Dict: {sw.ElapsedMilliseconds} ms");


        }
    }
}
