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
        public void WithNewtonsoft()
        {
            var str = JsonConvert.SerializeObject(item);
        }
        
        [Benchmark]
        public void WithTemplate()
        {
            var str = item.ToJson();
        }


        [Benchmark]
        public void WithNewtonsoft2()
        {
            WithNewtonsoftImpl();
        }

        [Benchmark]
        public void WithNewtonsoft2_()
        {
            WithNewtonsoftImpl2();
        }

        [Benchmark]
        public void WithTemplate2()
        {
            WithTemplateImpl();
        }


        [MethodImpl(MethodImplOptions.NoOptimization)]
        private void WithNewtonsoftImpl()
        {
            var str = JsonConvert.SerializeObject(item);
        }

        public void WithNewtonsoftImpl2()
        {
            using var stream = new MemoryStream();
            using var streamWriter = new StreamWriter(stream);
            using var writer = new JsonTextWriter(streamWriter);

            serializer.Serialize(writer, item);

            //var streamReader = new StreamReader(stream);
            //var str = streamReader.ReadToEnd();

            var str = Encoding.ASCII.GetString(stream.ToArray());

        }

        [MethodImpl(MethodImplOptions.NoOptimization)]
        private void WithTemplateImpl()
        {
            var str = item.ToJson();
        }

    }
}







/*

|         Method |       Mean |   Error |  StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------- |-----------:|--------:|--------:|-------:|------:|------:|----------:|
| WithNewtonsoft | 1,047.1 ns | 7.93 ns | 7.42 ns | 0.7801 |     - |     - |      2 KB |
|   WithTemplate |   391.0 ns | 3.74 ns | 3.12 ns | 0.6309 |     - |     - |      1 KB | 

*/