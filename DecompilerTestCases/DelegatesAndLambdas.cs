using System;

namespace DecompilerTestCases
{
    public class DelegatesAndLambdas
    {
        public static event EventHandler MyStaticEvent;

        public event EventHandler MyEvent;

        public event EventHandler MyCustomEvent
        {
            add
            {
                Console.WriteLine("Add");
            }
            remove
            {
                Console.WriteLine("Remove");
            }
        }

        public void Subscribe()
        {
            MyEvent += MyEventHandler;
        }

        public void SubscribeAnonymously()
        {
            MyEvent += delegate (object o, EventArgs e)
            {
                Console.WriteLine(o);
                Console.WriteLine(e);
            };

            MyEvent += delegate 
            {
                Console.WriteLine("No parameter specification required.");
            };
        }

        public void SubscribeAnonymouslyLambda()
        {
            MyEvent += (o, e) => { };
        }

        public void SubscribeStatic()
        {
            MyStaticEvent += MyStaticEventHandler;
        }

        public void SubscribeLambdaClosure()
        {
            int x = 0;
            MyEvent += (o, e) =>
            {
                x++;
                Console.WriteLine(x);
            };
        }

        public void Unsubscribe()
        {
            MyEvent -= MyEventHandler;
        }

        private void MyEventHandler(object sender, EventArgs e)
        {
            Console.WriteLine("My event handler");
        }

        private static void MyStaticEventHandler(object sender, EventArgs e)
        {
            Console.WriteLine("My static event handler");
        }
    }
}
