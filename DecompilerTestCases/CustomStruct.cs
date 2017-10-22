using System.Runtime.InteropServices;

namespace DecompilerTestCases
{
    public struct CustomStruct
    {
        public int FieldOne;
        public ushort FieldTwo;
        public byte FieldThree;

        public CustomStruct(int one, ushort two, byte three)
        {
            FieldOne = one;
            FieldTwo = two;
            FieldThree = three;
        }
    }
}