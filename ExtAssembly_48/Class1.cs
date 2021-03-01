using EnvDTE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtAssembly_48
{
    public class Class1
    {
        public void fun()
        {
            var VisualStudio = new AutomationHelper(null);

            var project = VisualStudio.GetProject("EnumByDOM");

            var list = VisualStudio
                .CodeModel
                .GetAllCodeElementsOfType(project.CodeModel.CodeElements, vsCMElement.vsCMElementClass, false)
                .Cast<EnvDTE.CodeClass>()
                //.Where(recordDelegate => recordDelegate.Name.EndsWith(RecordSuffix))
                .OrderBy(d => d.FullName);

            var commonClass = list.FirstOrDefault(c => c.Name == "CommonClass");

            var classList = list.Where(c => c.Name != "CommonClass" && c.Name != "Converter");

            var list2 = commonClass.DerivedTypes.Cast<EnvDTE.CodeClass>();

            foreach (var item in list2)
            {
                //WriteLine($"//{item.Name} '{commonClass.Name}'");
            }

                foreach (var item in list.Where(c=>c.Parent == commonClass))
            {
                //item.DerivedTypes.AsQueryable().FIr
            }

        }
    }
}
