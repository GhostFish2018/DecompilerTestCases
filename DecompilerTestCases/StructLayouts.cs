using System.Runtime.InteropServices;

namespace DecompilerTestCases
{
    public static class StructLayouts
    {
        [StructLayout(LayoutKind.Auto)]
        public struct AutoStruct
        {
            public byte A;
            public int B;
            public long C;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SequentialStruct
        {
            public byte A;
            public int B;
            public long C;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct SequentialPackedStruct
        {
            public byte A;
            public int B;
            public long C;
        }

        [StructLayout(LayoutKind.Explicit, Size = 20)]
        public struct ExplicitPackedStruct
        {
            [FieldOffset(5)]
            public byte A;
            [FieldOffset(5)]
            public int B;
            [FieldOffset(10)]
            public long C;
        }

        [StructLayout(LayoutKind.Auto, CharSet = CharSet.Ansi)]
        public struct AnsiStruct
        {
            public string MyString;
        }

        [StructLayout(LayoutKind.Auto, CharSet = CharSet.Unicode)]
        public struct UnicodeStruct
        {
            public string MyString;
        }
    }
}
