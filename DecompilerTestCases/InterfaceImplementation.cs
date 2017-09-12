using System;

namespace DecompilerTestCases
{
    public class InterfaceImplementation : ICustomInterfaceA, ICustomInterfaceB
    {
        public event EventHandler InterfaceAEvent;

        event EventHandler ICustomInterfaceB.InterfaceBEvent
        {
            add
            {
            }
            remove
            {
            }
        }

        public int InterfaceAProperty
        {
            get;
            set;
        }

        int ICustomInterfaceB.InterfaceBProperty
        {
            get;
            set;
        }

        public void InterfaceAMethod()
        {
        }

        void ICustomInterfaceB.InterfaceBMethod()
        {
        }
    }
}
