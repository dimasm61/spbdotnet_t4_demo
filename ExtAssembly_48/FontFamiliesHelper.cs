﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TextTemplating;

namespace ExtAssembly_48
{
    public static class FontFamiliesHelper
    {
        public static void WriteINstalledForntCollection(TextTransformation tt, string className)
        {
            tt.WriteLine($"public static class {className}"); tt.WriteLine($"{{");
            tt.PushIndent("    ");
            {
                foreach (var font in new InstalledFontCollection().Families)
                {
                    var varName = font.Name.Replace(" ", "_");
                    varName = !Char.IsLetter(varName[0]) ? $"_{varName}" : varName;
                    tt.WriteLine($"public const string {varName} = \"{font.Name}\";");
                }
            }// static class
            tt.PopIndent();
            tt.WriteLine($"}}");
        }
    }
}