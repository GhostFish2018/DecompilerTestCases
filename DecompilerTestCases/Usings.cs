using System;
using System.IO;

namespace DecompilerTestCases
{
    public class Usings
    {
        private Stream _myStream = new MemoryStream();

        public void UseNewVariable()
        {
            using (var stream = File.OpenRead("C:\\somefile.txt"))
            {
                Console.WriteLine(stream.Length);
            }
        }

        public void UseExistingVariable()
        {
            using (_myStream)
            {
                Console.WriteLine(_myStream.Length);
            }
        }
    }
}
