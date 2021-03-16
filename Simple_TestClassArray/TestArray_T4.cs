

using System;
using Xunit;

namespace Simple_TestClassArray
{
    public partial class UnitTest1
    {
        private static MyTestClass[] testArray = new []{
              new MyTestClass(Guid.Parse("a640fa38-ca3e-4b1d-b32b-e23141b00678"), Guid.Parse("320ecfd3-1790-4cda-b79c-e6618d2c5110"), "q47LbWQLVowuMtvdg82nVxLrkuNzxOrYwEjWEjOkZqozax9GG1", 1990, new DateTime(2000, 05, 07))
            , new MyTestClass(Guid.Parse("6a24fc08-fbcc-479c-9ab8-890260491d72"), Guid.Parse("320ecfd3-1790-4cda-b79c-e6618d2c5110"), "p3uQkrKaXG7X7GJZY7vSOpJWRxvFs6MU9harnz8hb8Tg1C038s", 2003, new DateTime(2004, 07, 03))
            , new MyTestClass(Guid.Parse("a8cb9e5c-0c69-40b9-8191-68244e0ee52a"), Guid.Parse("f412a21f-e98a-4598-902c-15d738eeef49"), "B9uY9x5Dtb5nXZrcxj8O1PWmeP72GAdGt3ga6O0MmXQ1mPpaMg", 2017, new DateTime(2019, 02, 11))
            , new MyTestClass(Guid.Parse("a1a1bd98-1b15-4b6d-8f32-42feb089ba63"), Guid.Parse("f6e64ade-ff17-45c7-ba97-908ced27b341"), "PwoJ4uzD6s8y3e3Rfiuxne9fAPjhqkFkBWpuwyUFWhai3xVLg5", 1990, new DateTime(2000, 02, 09))
            , new MyTestClass(Guid.Parse("feb26d01-f2a0-48ef-b3bb-9eb883a8c8d3"), Guid.Parse("320ecfd3-1790-4cda-b79c-e6618d2c5110"), "vvxHHpKSYWmXxhzJesOobFEbnN3ZAuktcsk47pqq5EJE6fAxVY", 2003, new DateTime(2008, 02, 14))
            , new MyTestClass(Guid.Parse("361e6d52-146a-413b-bc65-223a918642c5"), Guid.Parse("320ecfd3-1790-4cda-b79c-e6618d2c5110"), "2qqWf5vvRow24E74M0BitW6AeGNGDnTRk705OmJv4KxeSDm50a", 1996, new DateTime(2010, 04, 16))
            , new MyTestClass(Guid.Parse("9f6d7a83-a125-43f5-b7ce-065ae332160b"), Guid.Parse("7f4229e1-71cf-43e1-86b2-4b8adb8bea59"), "wftq1YspsoVeS7PBrjrQpijbsbfRQnat9BLVNiuvDPcKKyworz", 2012, new DateTime(2016, 10, 01))
            , new MyTestClass(Guid.Parse("4bfe5742-c490-41c3-9848-d6b976e68ac7"), Guid.Parse("7f4229e1-71cf-43e1-86b2-4b8adb8bea59"), "4O6R8Z3aZENmfQw3zJ06NZFZS4q1ka2yy7G7Z5jV1n0Y6hSf1x", 1990, new DateTime(2008, 09, 27))
            , new MyTestClass(Guid.Parse("cdb327bb-a1eb-4418-adeb-f69c40eea115"), Guid.Parse("7f4229e1-71cf-43e1-86b2-4b8adb8bea59"), "zfJg9EtB08MZyhJze3ieEkiscumLAyaRB0Jmy26fmzw2MhuvWB", 1998, new DateTime(2000, 01, 08))
            , new MyTestClass(Guid.Parse("9e2bb687-f6ca-47fc-b30b-707e5f151a8d"), Guid.Parse("6f35af05-b161-4f76-a9e5-c84988e9cdb8"), "3P6bDPdiBCh5X8ZhBn7D3Pyrf5A1y8fUOu64pXyrCDyuUQKvVy", 1990, new DateTime(2010, 02, 01))
        };

        private static Guid[] randomModelKeyArray = new []{
              Guid.Parse("320ecfd3-1790-4cda-b79c-e6618d2c5110")
            , Guid.Parse("7f4229e1-71cf-43e1-86b2-4b8adb8bea59")
            , Guid.Parse("7f4229e1-71cf-43e1-86b2-4b8adb8bea59")
            , Guid.Parse("6f35af05-b161-4f76-a9e5-c84988e9cdb8")
            , Guid.Parse("f412a21f-e98a-4598-902c-15d738eeef49")
            , Guid.Parse("6f35af05-b161-4f76-a9e5-c84988e9cdb8")
            , Guid.Parse("7f4229e1-71cf-43e1-86b2-4b8adb8bea59")
            , Guid.Parse("f412a21f-e98a-4598-902c-15d738eeef49")
            , Guid.Parse("f6e64ade-ff17-45c7-ba97-908ced27b341")
            , Guid.Parse("6f35af05-b161-4f76-a9e5-c84988e9cdb8")
         };

        private static Guid[] randomKeyArray = new []{
              Guid.Parse("feb26d01-f2a0-48ef-b3bb-9eb883a8c8d3")
            , Guid.Parse("feb26d01-f2a0-48ef-b3bb-9eb883a8c8d3")
            , Guid.Parse("9e2bb687-f6ca-47fc-b30b-707e5f151a8d")
            , Guid.Parse("a640fa38-ca3e-4b1d-b32b-e23141b00678")
            , Guid.Parse("4bfe5742-c490-41c3-9848-d6b976e68ac7")
            , Guid.Parse("6a24fc08-fbcc-479c-9ab8-890260491d72")
            , Guid.Parse("9f6d7a83-a125-43f5-b7ce-065ae332160b")
            , Guid.Parse("4bfe5742-c490-41c3-9848-d6b976e68ac7")
            , Guid.Parse("4bfe5742-c490-41c3-9848-d6b976e68ac7")
            , Guid.Parse("9e2bb687-f6ca-47fc-b30b-707e5f151a8d")
         };
    }
}
