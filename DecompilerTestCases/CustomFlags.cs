using System;

namespace DecompilerTestCases
{
    [Flags]
    public enum CustomFlags
    {
        Attribute1 = 1,
        Attribute2 = 2,
        Attribute3 = 4,
        Attribute4 = 8,
        Attribute5 = 16,
    }
}
