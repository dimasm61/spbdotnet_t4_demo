using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtAssembly_48
{
    public static class TestArrayHelper
    {
        /// <summary>
        /// Создаем набор рандомных данных
        /// </summary>
        /// <param name="context"></param>
        /// <param name="countOfItem"></param>
        /// <param name="countOfTestArrayByModel"></param>
        /// <param name="countOfTestArrayByItem"></param>
        public static void GenerateTestArray(object context, int countOfItem, int countOfTestArrayByModel, int countOfTestArrayByItem)
        {
            var tt = new TextTransformationProxy(context);

            tt.WriteLine("private static MyTestClass[] testArray = new []{");

            var keyList = new List<Guid>();
            var k = "";
            var models = new[] { Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid() };
            var rand = new Random();
            string allowedChars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz0123456789!@$?_-";

            // создаем набор тестовых записей
            for (var i = 0; i < countOfItem; i++)
            {
                k = (i > 0) ? ", " : "  ";
                // создаем рандомное наполнение
                var key = Guid.NewGuid();
                keyList.Add(key);
                var modelKey = models.OrderBy(c => Guid.NewGuid()).FirstOrDefault();
                var carName = string.Join("", Enumerable.Repeat(0, 10).Select(n => allowedChars[rand.Next(60)]));
                var buildYear = rand.Next(1990, 2020);
                var saleDate = $"new DateTime({rand.Next(buildYear, 2020)}, {rand.Next(1, 12):00}, {rand.Next(1, 28):00})";
                tt.WriteLine($"{k}new MyTestClass(Guid.Parse(\"{key}\"), Guid.Parse(\"{modelKey}\"), \"{carName}\", {buildYear}, {saleDate}");
            }
            tt.WriteLine("};");

            /////////////////////////////////////
            
            tt.WriteLine($"private static Guid[] randomModelKeyArray = new[]{{");

            // создаем набор modelKey для тестов
            for (var i = 0; i < countOfTestArrayByModel; i++)
            {
                k = (i > 0) ? ", " : "  ";
                var key = models.OrderBy(c => Guid.NewGuid()).FirstOrDefault();

                tt.WriteLine($"{k}Guid.Parse(\"{key}\")");
            }
            tt.WriteLine("};");
            
            ////////////////////////////////////
            
            tt.WriteLine($"private static Guid[] randomKeyArray = new[]{{");

            // создаем набор key для тестов
            for (var i = 0; i < countOfTestArrayByItem; i++)
            {
                k = (i > 0) ? ", " : "  ";
                var key = keyList.OrderBy(c => Guid.NewGuid()).FirstOrDefault();
                tt.WriteLine($"{k}Guid.Parse(\"{key}\")");
            }
            tt.WriteLine("};");
        }
    }
}
