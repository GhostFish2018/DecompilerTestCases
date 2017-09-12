using System;

namespace DecompilerTestCases
{
    public class GenericClass<T>
    {
        public T ClassTypeArgInReturnType()
        {
            return default(T);
        }

        public void ClassTypeArgInParameter(T param)
        {
            Console.WriteLine(param);
        }

        public TMethod MethodTypeArgInReturnType<TMethod>()
        {
            return default(TMethod);
        }

        public void MethodTypeArgInParam<TMethod>(TMethod param)
        {
            Console.WriteLine(param);
        }

        public void TypeArgConstraints<TClass, TStruct, TType>()
            where TClass : class
            where TStruct : struct
            where TType : AbstractClass
        {
        }

        public void ClassGenericMethodCall()
        {
            ClassTypeArgInParameter(default(T));
        }

        public void GenericMethodCall()
        {
            MethodTypeArgInParam<string>("Test");
        }
    }
}
