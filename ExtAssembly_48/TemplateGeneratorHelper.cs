using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtAssembly_48
{
    public static class TemplateGeneratorHelper
    {
        public static void GenerateSomeText(object context)
        {
            var tt = new TextTransformationProxy(context);

            tt.WriteLine("Hello");
        }
    }
}
