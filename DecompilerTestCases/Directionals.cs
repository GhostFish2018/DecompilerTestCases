using System;
using System.Collections.Generic;

namespace DecompilerTestCases
{
    public static class Directionals
    {
        private static readonly IDictionary<string, string> TestDictionary = new Dictionary<string, string>();

        public static void OutParameter(out int outParam)
        {
            outParam = 1;
        }

        public static string OutParameterAndReturnType(out int outParam)
        {
            outParam = 1;
            return TestDictionary["Key"];
        }

        public static void RefParameter(ref int refParam)
        {
            refParam++;
        }

        public static void OutParameterUsage()
        {
            int x;
            OutParameter(out x);
            Console.WriteLine(x);
        }

        public static void OutParameterUsageContinuation()
        {
            int x;
            var value = OutParameterAndReturnType(out x);
            if (x == 5)
                Console.WriteLine("x == 5");
            Console.WriteLine(value);
        }

        public static void RefParameterUsage()
        {
            int x = 3;
            RefParameter(ref x);
            Console.WriteLine(x);
        }
        

        public static void DictionaryUsage()
        {
            string value;
            if (!TestDictionary.TryGetValue("Key", out value))
            {
                value = "test";
                TestDictionary.Add("Key", value);
            }
            Console.WriteLine(value);
        }
        
    }
}
