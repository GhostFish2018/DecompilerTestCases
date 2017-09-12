namespace DecompilerTestCases
{
    public class Accessibility
    {
        private string _privateMember;
        public string PublicMember;
        internal string InternalMember;
        protected string ProtectedMember;
        protected internal string ProtectedInternalMember;

        internal string InternalProperty
        {
            get;
            set;
        }

        public string LessAccessibleGetter
        {
            private get;
            set;
        }

        public string LessAccessibleSetter
        {
            get;
            private set;
        }
    }
}