using System;

namespace DecompilerTestCases
{
    public static class Operators
    {
        private static readonly object _myObject = "test";
        private static readonly int _myInt1 = 3;
        private static readonly int _myInt2 = 4;
        private static readonly bool _myBool = true;
        private static readonly string _myString1 = "_myString1";
        private static readonly string _myString2 = "_myString2";

        public static void Concat()
        {
            Console.WriteLine(_myInt1 + "lol" + _myString1);
        }

        public static void ExplicitCast()
        {
            Console.WriteLine((string)_myObject);
        }

        public static void SafeCast()
        {
            Console.WriteLine(_myObject as string);
        }

        public static void Explicit()
        {
            var ptr = (IntPtr)1337ul;
            Console.WriteLine(ptr);
        }

        public static void Implicit()
        {
            int x = 3;
            decimal y = x;
            y += 3;
            Console.WriteLine(y);
        }

        public static void Is()
        {
            Console.WriteLine(_myObject is string);
        }

        public static void BitwiseNegate()
        {
            Console.WriteLine(~_myInt1);
        }

        public static void Negate()
        {
            Console.WriteLine(-_myInt1);
        }

        public static void BooleanNot()
        {
            Console.WriteLine(!_myBool);
        }

        public static void Add()
        {
            Console.WriteLine(_myInt1 + _myInt2);
        }

        public static void Subtract()
        {
            Console.WriteLine(_myInt1 - _myInt2);
        }

        public static void Multiply()
        {
            Console.WriteLine(_myInt1 * _myInt2);
        }

        public static void Divide()
        {
            Console.WriteLine(_myInt1 / _myInt2);
        }

        public static void ShiftRight()
        {
            Console.WriteLine(_myInt1 >> _myInt2);
        }

        public static void ShiftLeft()
        {
            Console.WriteLine(_myInt1 << _myInt2);
        }

        public static void CheckEquality()
        {
            Console.WriteLine(_myInt1 == _myInt2);
        }

        public static void CheckEqualityCustom()
        {
            Console.WriteLine(_myString1 == _myString2);
        }

        public static void CheckInequality()
        {
            Console.WriteLine(_myInt1 != _myInt2);
        }

        public static void CheckBiggerThan()
        {
            Console.WriteLine(_myInt1 > _myInt2);
        }

        public static void CheckBiggerThanOrEqual()
        {
            Console.WriteLine(_myInt1 >= _myInt2);
        }

        public static void CheckLessThan()
        {
            Console.WriteLine(_myInt1 < _myInt2);
        }

        public static void CheckLessThanOrEqual()
        {
            Console.WriteLine(_myInt1 <= _myInt2);
        }

        public static void BitwiseAnd()
        {
            Console.WriteLine(_myInt1 & _myInt2);
        }

        public static void BitwiseOr()
        {
            Console.WriteLine(_myInt1 | _myInt2);
        }

        public static void BitwiseXor()
        {
            Console.WriteLine(_myInt1 ^ _myInt2);
        }

        public static void Default()
        {
            Console.WriteLine(default(CustomStruct));
        }

        public static void TypeOf()
        {
            Console.WriteLine(typeof(CustomStruct));
        }

        public static void NullPropagation()
        {
            Console.WriteLine(_myObject?.ToString());
        }

        public static void NullCoalesce()
        {
            Console.WriteLine(_myString1 ?? "other");
        }

    }
}
