namespace ExtAssembly_48
{
    public class TextTransformationProxy
    {
        private readonly dynamic _ttContext;
        
        public TextTransformationProxy(dynamic ttContext)
        {
            _ttContext = ttContext;
            
            var contextType = ttContext.GetType();

        }

        public static TextTransformationProxy GetProxy(object ttContext)
        {
            if (ttContext is TextTransformationProxy proxy)
                return proxy;

            return new TextTransformationProxy(ttContext);
        }

        public void Write(string str) => _ttContext.Write(str);
        
        public void WriteLine(string str) => _ttContext.WriteLine(str);
        
        public void PushIndent(string indent) => _ttContext.PushIndent(indent);
        
        public void PopIndent() => _ttContext.PopIndent();
    }
}