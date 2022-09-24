using System;
using System.Text;

namespace Simple_Class
{
    public static class DemoCarClassExt
    {
         public static string ToJson(this DemoCarClass item)
         {
             var sb = new StringBuilder(500);
             sb.Append("{");
             sb.AppendFormat("\"CarGuid\":{0}", item.CarGuid);
             sb.AppendFormat("\", CarBuildYear\":{0}", item.CarBuildYear);
             sb.AppendFormat("\", Model\":{0}", item.Model);
             sb.Append("}");
             return sb.ToString();
         }
    }
}