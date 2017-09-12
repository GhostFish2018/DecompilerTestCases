using System;

namespace DecompilerTestCases
{
    public class UdocumentedFeatures
    {
        public static void ArgList(__arglist)
        {
            var iterator = new ArgIterator(__arglist);
            Console.WriteLine(iterator.GetRemainingCount());
        }

        public static void TypedReferences(int x)
        {
            // Note: resharper doesn't recognize undocummented keywords.
            TypedReference typedReference = __makeref(x);
            Type type = __reftype(typedReference);
            int value = __refvalue(typedReference, int);
            Console.WriteLine("Type = {0}", type);
            Console.WriteLine("Value = {0}", value);
        }
    }
}
