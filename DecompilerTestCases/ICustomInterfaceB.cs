using System;

namespace DecompilerTestCases
{
    public interface ICustomInterfaceB
    {
        event EventHandler InterfaceBEvent;

        int InterfaceBProperty
        {
            get;
            set;
        }

        void InterfaceBMethod();
    }
}
