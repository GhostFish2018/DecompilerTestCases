using System;

namespace DecompilerTestCases
{
    public static class ExceptionHandlers
    {
        private static int _myInt = 0;

        public static void ThrowNew()
        {
            throw new ArgumentException("This is a test exception");
        }

        public static void Rethrow()
        {
            try
            {
                if (_myInt == 0)
                    throw new ArgumentException("_myInt == 0");
            }
            catch
            {
                Console.WriteLine("Error");
                throw;
            }
        }

        public static void Finally()
        {
            Console.WriteLine("Before");
            try
            {
                Console.WriteLine("Try");
            }
            finally 
            {
                Console.WriteLine("Finally");
            }
            Console.WriteLine("After");
        }

        public static void CatchAny()
        {
            Console.WriteLine("Before");
            try
            {
                Console.WriteLine("Try");
            }
            catch
            {
                Console.WriteLine("Catch");
            }
        }

        public static void CatchAnyContinuation()
        {
            Console.WriteLine("Before");
            try
            {
                Console.WriteLine("Try");
            }
            catch
            {
                Console.WriteLine("Catch");
            }
            Console.WriteLine("After");
        }

        public static void CatchSpecific()
        {
            Console.WriteLine("Before");
            try
            {
                Console.WriteLine("Try");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Catch");
            }
            Console.WriteLine("After");
        }

        public static void CatchSpecificVar()
        {
            Console.WriteLine("Before");
            try
            {
                Console.WriteLine("Try");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Catch " + ex.Message);
            }
            Console.WriteLine("After");
        }

        public static void CatchMultiple()
        {
            Console.WriteLine("Before");
            try
            {
                Console.WriteLine("Try");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("ArgumentException");
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("InvalidOperationException");
            }
            Console.WriteLine("After");
        }

        public static void CatchFinally()
        {
            Console.WriteLine("Before");
            try
            {
                Console.WriteLine("Try");
            }
            catch
            {
                Console.WriteLine("Catch");
            }
            finally
            {
                Console.WriteLine("Finally");
            }
            Console.WriteLine("After");
        }

        public static void Nested()
        {
            Console.WriteLine("0: Before");
            try
            {
                Console.WriteLine("1: Try Before");
                try
                {
                    Console.WriteLine("2: Try");
                }
                catch (Exception)
                {
                    Console.WriteLine("2: Catch");
                }
                Console.WriteLine("1: Try After");
            }
            catch (Exception)
            {
                Console.WriteLine("1: Catch");
            }
            Console.WriteLine("0: After");
        }

        public static void Filters()
        {
            Console.WriteLine("0: Before");
            try
            {
                Console.WriteLine("1: Try");
            }
            catch (Exception ex) when (ex.InnerException != null)
            {
                Console.WriteLine("1: Catch");
            }
            Console.WriteLine("0: After");
        }
    }
}