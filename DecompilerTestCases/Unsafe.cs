using System;

namespace DecompilerTestCases
{
    public static unsafe class Unsafe
    {
        public struct FixedStruct
        {
            public fixed int FixedField[5];
            public int NormalField;
        }

        public class Point
        {
            public int X;
            public int Y;
        }

        private static unsafe int* _intPtr;
        private static unsafe FixedStruct* _pointPtr;

        public static void PointerAccess()
        {
            Console.WriteLine(_intPtr[0]);
            Console.WriteLine(_intPtr[2]);
        }

        public static void PointerSet()
        {
            _intPtr[0] = 0;
            _intPtr[2] = 2;
        }

        public static void PointerMethodCall()
        {
            Console.WriteLine(_intPtr->ToString());
        }

        public static void PointerMemberAccess()
        {
            Console.WriteLine(_pointPtr->NormalField);
        }

        public static void FixedVariable()
        {
            var point = new Point();
            fixed(int* x = &point.X)
            {
                Console.WriteLine(x[1]);
            }
        }

        public static void FixedString()
        {
            fixed(char* c = "Strings")
            {
                Console.Write(c[0]);
            }
        }

        public static void StackAllocByte()
        {
            var bytePtr = stackalloc byte[20];
            Console.WriteLine(bytePtr[2]);
        }

        public static void StackAllocInt()
        {
            var intPtr = stackalloc int[20];
            Console.WriteLine(intPtr[2]);
        }

        public static void SizeOf()
        {
            Console.WriteLine(sizeof(CustomStruct));
        }
    }
}
