using System;

namespace DecompilerTestCases
{
    [Test("Attribute on class")]
    public class CustomAttributes
    {
        [Test("Attribute on nested class")]
        public class NestedClass
        {
        }

        [Test("Attribute on event")]
        public event EventHandler Event;

        [Test("Attribute on field")]
        public int Field;

        [Test("Attribute on property")]
        public int Property
        {
            [Test("Attribute on getter")]
            get
            {
                return Field;
            }
            [Test("Attribute on setter")]
            set
            {
                Field = value;
            }
        }

        [Test("Attribute on method")]
        public void Method()
        {
        }

        [return: Test("Attribute on return type")]
        public int ReturnType()
        {
            return 0;
        }

        public void Parameter([Test("Attribute on parameter")] int x)
        {
        }

        [Test("required", OptionalInt = 1, OptionalType = typeof(CustomAttributes), OptionalArray = new[] { "test", "test2" })]
        public void OptionalParameters()
        {
        }

        [Test]
        public void NoArguments()
        {
        }

        [Test(new[] { "test", "test2" })]
        public void ArrayArgument()
        {
        }


        [Test(required: null)]
        public void NullArgument()
        {
        }
    }

    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public sealed class TestAttribute : Attribute
    {
        public TestAttribute()
        {
        }

        public TestAttribute(string required)
        {
            Required = required;
        }

        public TestAttribute(string[] optionalArray)
        {
            OptionalArray = optionalArray;
        }
        

        public string Required
        {
            get;
        }

        public int OptionalInt
        {
            get;
            set;
        }

        public Type OptionalType
        {
            get;
            set;
        }
        public string[] OptionalArray
        {
            get;
            set;
        }
        
    }
}
