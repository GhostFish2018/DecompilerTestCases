using System;

namespace DecompilerTestCases
{
    public interface ICustomInterfaceA
    {
        event EventHandler InterfaceAEvent;

        int InterfaceAProperty
        {
            get;
            set;
        }

        void InterfaceAMethod();
    }
}
