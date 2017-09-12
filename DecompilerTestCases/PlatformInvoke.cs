using System;
using System.Runtime.InteropServices;

namespace DecompilerTestCases
{
    public static class PlatformInvoke
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int MessageBox(IntPtr hWnd, string text, string caption, int options);

        [DllImport("user32.dll", EntryPoint = "MessageBox", CharSet = CharSet.Auto)]
        public static extern int CustomEntrypoint(IntPtr hWnd, string text, string caption, int options);

        [DllImport("NonExistingLib.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int StdCallMethod(int a, int b);

        [DllImport("NonExistingLib.dll", CallingConvention = CallingConvention.ThisCall)]
        public static extern int ThisCallMethod(int a, int b);

        [DllImport("NonExistingLib.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int CdeclCallMethod(int a, int b);

        [DllImport("NonExistingLib.dll", CallingConvention = CallingConvention.FastCall)]
        public static extern int FastCallMethod(int a, int b);

        [DllImport("NonExistingLib.dll", CharSet = CharSet.Unicode)]
        public static extern int UnicodeMethod(int a, int b);

        [DllImport("NonExistingLib.dll", CharSet = CharSet.None)]
        public static extern int None(int a, int b);

        [DllImport("NonExistingLib.dll", CharSet = CharSet.Auto)]
        public static extern int Auto(int a, int b);

        [DllImport("NonExistingLib.dll", CharSet = CharSet.Ansi)]
        public static extern int Ansi(int a, int b);

        [DllImport("NonExistingLib.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode)]
        public static extern int StdUnicodeMethod(int a, int b);

        [DllImport("NonExistingLib.dll", SetLastError=true)]
        public static extern int SetLastErrorMethod(int a, int b);

        [DllImport("user32.dll", BestFitMapping = true)]
        public static extern int BestFitMapping(IntPtr hWnd, string text, string caption, int options);

        [DllImport("user32.dll", BestFitMapping = false)]
        public static extern int NoBestFitMapping(IntPtr hWnd, string text, string caption, int options);

        [DllImport("user32.dll", ThrowOnUnmappableChar = true)]
        public static extern int ThrowOnUnmappableChar(IntPtr hWnd, string text, string caption, int options);

        [DllImport("user32.dll", ThrowOnUnmappableChar = false)]
        public static extern int NoThrowOnUnmappableChar(IntPtr hWnd, string text, string caption, int options);

        [DllImport("user32.dll", ExactSpelling = true)]
        public static extern int ExactSpelling(IntPtr hWnd, string text, string caption, int options);

        [DllImport("user32.dll", ExactSpelling = false)]
        public static extern int NoExactSpelling(IntPtr hWnd, string text, string caption, int options);

    }
}