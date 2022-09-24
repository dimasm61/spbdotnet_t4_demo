using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_TestBenchmark
{
    public class MyTestClass
    {
        public Guid Key { get; set; }
        public Guid ModelKey { get; set; }
        public string CarName { get; set; }
        public int BuildYear { get; set; }
        public DateTime SaleDate { get; set; }
        public DateTime UpdateDate { get; set; }

        public MyTestClass()
        {

        }

        public MyTestClass(Guid key, Guid modelKey, string carName, int buildYear, DateTime saleDate)
        {
            Key = key;
            ModelKey = modelKey;
            CarName = carName;
            BuildYear = buildYear;
            SaleDate = saleDate;
            UpdateDate = DateTime.Now;
        }
    }
}
