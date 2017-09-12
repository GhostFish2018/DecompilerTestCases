namespace DecompilerTestCases
{
    public interface IShadowingInterface : ICustomInterfaceA
    {
        new void InterfaceAMethod();
    }
}
