namespace DecompilerTestCases
{
    public interface ICovariantInterface<in T>
    {
        void MethodWithCovariantParam(T param);
    }
}
