

namespace EnumByDOM
{
    public class Converter
    {
        public enum ClassEnum
        {
            A,
            B,
            C,
            D,
        }

        public static CommonClass GetInstance(ClassEnum classEnum)
        {
            switch(classEnum)
            {
                case ClassEnum.A: return new A();
                case ClassEnum.B: return new B();
                case ClassEnum.C: return new C();
                case ClassEnum.D: return new D();
                default: return null;
            }
        }
    }
}