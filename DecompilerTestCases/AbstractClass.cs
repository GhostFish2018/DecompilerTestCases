using System;

namespace DecompilerTestCases
{
    public abstract class AbstractClass
    {
        public abstract int AbstractProperty
        {
            get;
        }

        public virtual int VirtualProperty
        {
            get
            {
                return 1;
            }
        }

        public int NormalProperty
        {
            get;
        }

        public abstract void AbstractMethod();

        public virtual void VirtualMethod()
        {
            Console.WriteLine("Hello, world!");
        }

        public void NormalMethod()
        {
            Console.WriteLine("Hello, mars!");
        }

        private void InaccessibleMethod()
        {
            Console.WriteLine("Hello, jupiter!");
        }
    }
}
