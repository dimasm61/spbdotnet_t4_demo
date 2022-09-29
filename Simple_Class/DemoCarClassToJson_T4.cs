using System;
using System.Text;

//09/29/2022 14:33:28
namespace Simple_Class
{
    public static class DemoCarClassExt
    {
         public static string ToT4JsonWithSb(this DemoCarClass item)
         {
             var sb = new StringBuilder(500);
             sb.Append("{");
             sb.AppendFormat("\"CarGuid\":\"{0}\"", item.CarGuid);
             sb.AppendFormat(", \"CarBuildYear\":{0}", item.CarBuildYear);
             sb.AppendFormat(", \"Model\":\"{0}\"", item.Model);
             sb.Append("}");
             return sb.ToString();
         }

         public static string ToT4JsonWithConcat(this DemoCarClass item)
         {
             return string.Concat(
             "{"
              ,"\"CarGuid\":","\"",item.CarGuid.ToString(),"\""
              ,",\"CarBuildYear\":",item.CarBuildYear.ToString()
              ,",\"Model\":","\"",item.Model,"\""
             ,"}");
         }
    }
}