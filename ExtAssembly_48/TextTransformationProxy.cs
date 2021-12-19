using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtAssembly_48
{

    /// <summary>
    /// Класс которыей реализует обертку над TextTransformation с использованием dynamic типа.
    /// Позволяет работать внутри своих сборок генерации кода не подтягивая сборки в которых живет TextTransformation,
    /// которые в свою очередь для Visual Studio будут одни, а для Rider - другие.
    /// </summary>
    public class TextTransformationProxy
    {
        private readonly dynamic _textTemplateContext;
        public TextTransformationProxy(object textTemplateContext)
        {
            _textTemplateContext = textTemplateContext;
        }

        public void Write(string str) => _textTemplateContext.Write(str);

        public void WriteLine(string str) => _textTemplateContext.WriteLine(str);

        public void PushIndent(string indent) => _textTemplateContext.PushIndent(indent);

        public void PopIndent() => _textTemplateContext.PopIndent();
    }
}
