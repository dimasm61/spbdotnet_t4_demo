t4 --out=BeginWithT4\TextTemplate1.cs                 BeginWithT4\TextTemplate1.tt          
t4 --out=Simple_Class\DemoCarClass_T4.cs              Simple_Class\DemoCarClass_T4.tt
t4 --out=Simple_Class\DemoCarClassToJson_T4.cs        Simple_Class\DemoCarClassToJson_T4.tt
cd Simple_TestBenchmark
t4 --out=TestArray_T4.cs TestArray_T4.tt
cd ..
cd Simple_Logger
t4 --out=LoggerAdapterTextTemplate.cs LoggerAdapterTextTemplate.tt
cd ..
cd Simple_Enum
t4 --out=DemoCountryEnum_T4.cs DemoCountryEnum_T4.tt
cd ..
cd Simple_EnumWriteLine
t4 --out=DemoCountryEnum_T4.cs DemoCountryEnum_T4.tt
cd ..
cd EnumByDOM
t4 --out=EnumByDOM_T4.cs EnumByDOM_T4.tt
cd ..
cd EnumByTxtFile
t4 --out=DemoCountryEnum_T4.cs DemoCountryEnum_T4.tt    
t4 --out=DemoCountryEnum2_T4.cs DemoCountryEnum2_T4.tt    
cd ..
