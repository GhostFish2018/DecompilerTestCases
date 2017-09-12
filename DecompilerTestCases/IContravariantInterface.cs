namespace DecompilerTestCases
{
    public interface IContravariantInterface<out T>
    {
        T ContravariantMethod();
    }
}
