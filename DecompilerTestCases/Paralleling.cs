using System;
using System.Threading.Tasks;

namespace DecompilerTestCases
{
    public class Paralleling
    {
        private object _lockObject = new object();

        public async void Await()
        {
            await Task.Run(() => Console.WriteLine());
        }

        public void SyncLock()
        {
            Console.WriteLine("Before");
            lock (_lockObject)
            {
                Console.WriteLine("Locked");
            }
            Console.WriteLine("After");
        }
    }
}
