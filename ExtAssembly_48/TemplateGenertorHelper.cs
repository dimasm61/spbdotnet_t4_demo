using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TextTemplating;

namespace ExtAssembly_48
{
    public static class TemplateGenertorHelper
    {
        public static void GenerateSomeText(TextTransformation tt)
        {
            tt.WriteLine("Hello");
        }
    }
}
