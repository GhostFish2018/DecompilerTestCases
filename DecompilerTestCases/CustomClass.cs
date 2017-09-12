namespace DecompilerTestCases
{
    public class CustomClass
    {
        public CustomClass()
            : this(null, null)
        {
        }

        public CustomClass(string myString)
            : this(myString, null)
        {
        }

        public CustomClass(string myString, CustomClass customClass)
        {
            StringProperty = myString;
            CustomClassProperty = customClass;
        }

        public string StringProperty
        {
            get;
            set;
        }

        public CustomClass CustomClassProperty
        {
            get;
            set;
        }

        public string ReadOnlyProperty
        {
            get { return StringProperty; }
        }

        public string WriteOnlyProperty
        {
            set { StringProperty = value; }
        }
    }
}