rem MyCodegenerator.exe MyCodegeneratorUsing DemoCountryEnum AUS:Australia;AUT:Austria;BHR:Bahrain;BLR:Belarus
cd /d %~dp0
..\MyCodegenerator\bin\Debug\net5.0\MyCodegenerator.exe ^
 MyCodegeneratorUsing ^
 DemoCountryEnum ^
 AUS:Australia;AUT:Austria;BHR:Bahrain;BLR:Belarus;BRA:Brazil;FIN:Finland^
 > DemoCountryEnum.cs