using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;

namespace Simple_TestBenchmark
{
    [MemoryDiagnoser]
    public partial class TestBenchmark
    {
        public static Dictionary<Guid, MyTestClass> randomDict = testArray.ToDictionary(c => c.Key);

        // private static MyTestClass[] testArray = new[]
        // {
        //     new MyTestClass(Guid.Parse("4a4dff13-a7dc-424c-9129-fbd40a3673d0"),
        //         Guid.Parse("cdcb73c5-555d-4819-9f34-442843c42c0a"),
        //         "MxRcWHLZRQrdP6A0Oe3YVbVPXtjpu2JUueAavh1JbSJn9ubNae", 2014, new DateTime(2019, 11, 11)),
        //     new MyTestClass(Guid.Parse("c3d51c42-805c-4d0a-9b50-a4ef6325321c"),
        //         Guid.Parse("f738aca9-8b4e-4c66-b0b0-79984afcb141"),
        //         "VvbCEohfpZGXtv6kFqnv6CTtQoRXPQDOUWKP8tdOk5nufmArQ0", 2002, new DateTime(2004, 04, 07)),
        //     new MyTestClass(Guid.Parse("566a3dfd-1cea-4968-a443-f023daa965cf"),
        //         Guid.Parse("13f380f3-365e-4d0c-9f1e-ce6ea9c92b7f"),
        //         "aSctwaWLRZV3CXmrmWMZLBZiNonkGZ154F51xQ6D1ZpOZmjoEj", 1996, new DateTime(1997, 11, 25)),
        //     new MyTestClass(Guid.Parse("e310f0c5-af1c-4553-9f3f-70ab0da558b2"),
        //         Guid.Parse("f738aca9-8b4e-4c66-b0b0-79984afcb141"),
        //         "EZ23gJxwE2hZ96bu4WZJivXMKkE9fgLy9BBg93tyQEUxq9nnNU", 2010, new DateTime(2018, 07, 22))
        // };
        
        // private static Guid[] randomKeyArray = new []{
        //     Guid.Parse("9bcc3d2c-5ec2-446f-ab4a-f9e5764d02d7")
        //     , Guid.Parse("bc37cc1d-ca5d-495d-85c7-6fc5690d22d5")
        //     , Guid.Parse("04727f70-a0e3-46fc-b37b-3a0b822cc415")
        //     , Guid.Parse("205f8247-9ee1-4351-be9c-027301ba6c58")
        //     , Guid.Parse("7cda0dfb-7c4a-40a5-aeb8-8f9c26316850")
        //     , Guid.Parse("3b2fa654-ae7c-4468-926d-ee034b7d8a7c")
        //     , Guid.Parse("bfe4be50-8fd3-4fbf-9dcf-599e6ca4d05a")
        //     , Guid.Parse("a5f77433-eebd-40dc-b554-e1558f11a556")
        //     , Guid.Parse("f0616439-e573-481b-8615-b86f4fb47931")
        //     , Guid.Parse("7a66d6bc-144f-4755-ae8e-2ee3b87c361a")
        //     , Guid.Parse("f2779b27-52e5-403f-ba37-9e77d9a1ab6a")
        //     , Guid.Parse("1eb6f1db-537f-4041-a11d-8f527eccbae6")
        //     , Guid.Parse("b254befd-a8c7-40df-8cd8-accdef93d6e5")
            
        public TestBenchmark()
        {

        }

        [Benchmark]
        [MethodImpl(MethodImplOptions.NoOptimization)]
        public void DictionaryGet()
        {
            for (var i = 0; i < randomKeyArray.Length; i++)
            {
                var item = randomDict[randomKeyArray[i]];
            }
        }
        
        [Benchmark]
        [MethodImpl(MethodImplOptions.NoOptimization)]
        public void DictionaryTryGet()
        {
            for (var i = 0; i < randomKeyArray.Length; i++)
            {
                randomDict.TryGetValue(randomKeyArray[i], out var item);
            }
        }

        [Benchmark]
        [MethodImpl(MethodImplOptions.NoOptimization)]
        public void FirstOrDefault()
        {
            for (var i = 0; i < randomKeyArray.Length; i++)
            {
                var item = testArray.FirstOrDefault(c => c.Key == randomKeyArray[i]);
            }
        }
        
        [Benchmark]
        [MethodImpl(MethodImplOptions.NoOptimization)]
        public void ForLoop()
        {
            for (var i = 0; i < randomKeyArray.Length; i++)
            {
                var key = randomKeyArray[i];

                for (var j = 0; i < testArray.Length; j++)
                {
                    if (testArray[j].Key == key)
                        break;
                }
            }
        }
        
    }
}
