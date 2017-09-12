using System;

namespace DecompilerTestCases
{
    public class DerivedClass : AbstractClass
    {
        public override int AbstractProperty
        {
            get
            {
                return 2;
            }
        }

        public override void AbstractMethod()
        {
            Console.WriteLine("Override test.");
        }

        public new void NormalMethod()
        {
            Console.WriteLine("Shadowing test.");
        }

        private void InaccessibleMethod()
        {
            Console.WriteLine("No shadowing keyword needed.");
        }
    }
}
