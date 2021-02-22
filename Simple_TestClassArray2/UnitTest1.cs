using System;
using System.Data;
using System.Linq;
using Xunit;

namespace Simple_TestClassArray2
{
    public partial class UnitTest1
    {
        [Fact]
        public void LinqWhereByKeyTest()
        {
            for (var i = 0; i < randomModelKeyArray.Length; i++)
            {
                var cars = testArray.Where(c => c.ModelKey == randomModelKeyArray[i]);
                //if (cars == null) throw new Exception();
            }
        }

        [Fact]
        public void LinqFindByModelKeyTest()
        {
            for (var i = 0; i < randomKeyArray.Length; i++)
            {
                var car = testArray.FirstOrDefault(c => c.Key == randomKeyArray[i]);
                //if (car == null) throw new Exception();
            }
        }
    }
}
