namespace DecompilerTestCases
{
    public static class DataTypes
    {
        private static object _myObject;
        private static sbyte _myInt8;
        private static short _myInt16;
        private static int _myInt32;
        private static long _myInt64;

        private static byte _myUInt8;
        private static ushort _myUInt16;
        private static uint _myUInt32;
        private static ulong _myUInt64;

        private static string _myString;
        private static CustomClass _myCustomClass;
        private static CustomEnum _myEnum;
        private static CustomFlags _myFlags;

        private static byte[] _myArray;
        private static byte[,] _myMultidimensionalArray;
        private static byte[][] _myJaggedArray;

        private static decimal _myDecimal;

        private static void Boxing()
        {
            _myObject = 1234;
        }

        private static void Unboxing()
        {
            _myInt32 = (int) _myObject;
        }

        private static void Array1DAccess()
        {
            _myUInt8 = _myArray[3];
        }

        private static void Array1DSet()
        {
            _myArray[3] = _myUInt8;
        }

        private static void Array2DAccess()
        {
            _myUInt8 = _myMultidimensionalArray[1, 2];
        }

        private static void Array2DSet()
        {
            _myMultidimensionalArray[1, 2] = _myUInt8;
        }

        private static void ArrayJaggedAccess()
        {
            _myUInt8 = _myJaggedArray[1][2];
        }

        private static void ArrayJaggedSet()
        {
            _myJaggedArray[1][2] = _myUInt8;
        }

        private static void InitializeEnumVariable()
        {
            _myEnum = CustomEnum.Member2;
        }

        private static void InitializeFlagVariable()
        {
            _myFlags = CustomFlags.Attribute2 | CustomFlags.Attribute4;
        }

        private static void InitializeDecimal()
        {
            _myDecimal = 1337m;
        }
    }
}
