using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using Newtonsoft.Json;

namespace Simple_Class
{
    [MemoryDiagnoser]
    public partial class TestBenchmark
    {
        DemoCarClass item = new DemoCarClass
        {
            CarBuildYear = 2007,
            Model = "Niva",
            CarGuid = Guid.NewGuid()
        };

        JsonSerializer serializer = new JsonSerializer();

        public TestBenchmark()
        {

        }


        [Benchmark]
        public string WithTemplateWithSb() => item.ToT4JsonWithSb();

        [Benchmark]
        public string WithTemplateConcat() => item.ToT4JsonWithConcat();

        [Benchmark]
        public string WithNewtonsoft() => JsonConvert.SerializeObject(item);

        [Benchmark]
        public string WithNewtonsoftWithStream()
        {
            using var stream = new MemoryStream();
            using var streamWriter = new StreamWriter(stream);
            using var writer = new JsonTextWriter(streamWriter);

            serializer.Serialize(writer, item);

            return Encoding.ASCII.GetString(stream.ToArray());
        }

       
    }
}

/*
 

|                   Method |       Mean |    Error |   StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------- |-----------:|---------:|---------:|-------:|------:|------:|----------:|
|       WithTemplateWithSb |   451.2 ns |  5.82 ns |  5.16 ns | 0.6342 |     - |     - |   1,328 B |
|       WithTemplateConcat |   180.8 ns |  2.08 ns |  1.95 ns | 0.2103 |     - |     - |     440 B |
|           WithNewtonsoft | 1,028.6 ns | 13.69 ns | 12.14 ns | 0.7801 |     - |     - |   1,632 B |
| WithNewtonsoftWithStream | 1,379.2 ns | 23.31 ns | 19.46 ns | 2.9850 |     - |     - |   6,248 B |

 */