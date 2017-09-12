using System;
using System.Collections.Generic;

namespace DecompilerTestCases
{
    public static class Conditions
    {
        private static int _myInt = 3;

        private static List<string> _myStringArray = new List<string>(new[]
        {
            "Lorem", "Ipsum", "Dolor", "Sit", "Amet"
        });

        static void SimpleIf()
        {
            if (_myInt == 3)
            {
                Console.WriteLine("_myInt == 3");
            }
            Console.WriteLine("some more");
        }

        static void SimpleIfElse()
        {
            Console.WriteLine("preceding");
            if (_myInt == 3)
            {
                Console.WriteLine("_myInt == 3");
            }
            else
            {
                Console.WriteLine("_myInt != 3");
            }
            Console.WriteLine("some more");
        }

        static void SimpleIfElseIf()
        {
            if (_myInt == 3)
            {
                Console.WriteLine("_myInt == 3");
            }
            else if (_myInt == 4)
            {
                Console.WriteLine("_myInt == 4");
            }
            else
            {
                Console.WriteLine("_myInt != 3 && _myInt != 4");
            }
            Console.WriteLine("some more");
        }

        static void DoubleIfElse()
        {
            Console.WriteLine("preceding");
            if (_myInt == 3)
            {
                Console.WriteLine("_myInt == 3");
            }
            else
            {
                Console.WriteLine("_myInt != 3");
            }

            Console.WriteLine("some more");
            
            if (_myInt == 3)
            {
                Console.WriteLine("_myInt == 3");
            }
            else
            {
                Console.WriteLine("_myInt != 3");
            }

            Console.WriteLine("w/e");
        }

        static void NestedIf()
        {
            if (_myInt == 3)
            {
                Console.WriteLine("_myInt == 3");
                if (_myStringArray.Count == 0)
                {
                    Console.WriteLine("_myIntArray.Count == 0");
                }
                else
                {
                    Console.WriteLine("_myIntArray.Count != 0");
                }
            }
            else
            {
                Console.WriteLine("_myInt != 3");
            }
        }
        
        static void Ternary()
        {
            Console.WriteLine(_myInt == 3 ? "test1" : "test2");
        }

        static void DoubleTernary()
        {
            Console.WriteLine(_myInt == 3 ? (_myStringArray.Count == 4 ? "llo" : "test") : "test2");
        }

        
        static void LogicalAnd()
        {
            if (_myInt == 3 && _myStringArray[0] == "Lorem")
            {
                Console.WriteLine("_myInt == 3 && _myIntArray[0] == \"Lorem\"");
            }
            else
            {
                Console.WriteLine("_myInt != 3 || _myIntArray[0] != \"Lorem\"");
            }
        }

        static void LogicalOr()
        {
            if (_myInt == 3 || _myStringArray[0] == "Lorem")
            {
                Console.WriteLine("_myInt == 3 || _myIntArray[0] == \"Lorem\"");
            }
            else
            {
                Console.WriteLine("_myInt != 3 && _myIntArray[0] != \"Lorem\"");
            }
        }

        static void Switch()
        {
            switch (_myInt)
            {
                case 0:
                case 1:
                case 3:
                    Console.WriteLine("0 || 1 || 3");
                    break;
                case 2:
                    Console.WriteLine("2");
                    break;
                case 4:
                    Console.WriteLine("4");
                    break;
            }
        }

        static void SwitchDefault()
        {
            switch (_myInt)
            {
                case 0:
                case 1:
                case 3:
                    Console.WriteLine("0 || 1 || 3");
                    break;
                case 2:
                    Console.WriteLine("2");
                    break;
                case 4:
                    Console.WriteLine("4");
                    break;
                default:
                    Console.WriteLine("_myInt is something else.");
                    break;
            }
        }

        static void DoLoop()
        {
            do
            {
                Console.WriteLine("_myInt != 3");
            } while (_myInt != 3);
            Console.WriteLine("_myInt == 3");
        }

        static void DoLoopNestedIf()
        {
            do
            {
                Console.WriteLine("_myInt != 3");
                if (_myStringArray.Count == 3)
                    Console.WriteLine("_myStringArray.Count == 3");
            } while (_myInt != 3);
            Console.WriteLine("_myInt == 3");
        }

        static void WhileLoop()
        {
            while (_myInt == 3)
            {
                Console.WriteLine("_myInt == 3");
            }
            Console.WriteLine("_myInt != 3");
        }

        static void WhileLoopNestedIf()
        {
            while (_myInt == 3)
            {
                Console.WriteLine("_myInt == 3");
                if (_myStringArray.Count == 3)
                    Console.WriteLine("_myStringArray.Count == 3");
            }
            Console.WriteLine("_myInt != 3");
        }

        static void NestedWhileLoop()
        {
            Console.WriteLine("before");
            while (_myInt == 3)
            {
                Console.WriteLine("_myInt == 3");

                while (_myStringArray.Count == 3)
                {
                    Console.WriteLine("_myStringArray.Count == 3");
                }

                Console.WriteLine("_myStringArray.Count != 3");

            }
            Console.WriteLine("_myInt != 3");
        }

        static void WhileTrue()
        {
            while (true)
            {
                Console.WriteLine();
            }
        }

        static void WhileWithAnd()
        {
            Console.WriteLine("Before");
            while (_myInt == 0 && _myStringArray.Count == 1)
            {
                Console.WriteLine("Test");
            }
            Console.WriteLine("After");
        }

        static void BreakTest()
        {
            while (_myInt == 3)
            {
                Console.WriteLine("1");
                if (_myStringArray.Count == 3)
                    break;
                Console.WriteLine("2");
            }
            Console.WriteLine("3");
        }

        static void ContinueTest()
        {
            while (_myInt < 10)
            {
                Console.WriteLine("1");
                if (_myInt == 3)
                {
                    if (_myStringArray.Count == 3)
                        continue;
                    else
                        Console.WriteLine();
                }
                Console.WriteLine("2");
            }
        }

        static void ForLoop()
        {
            for (int i = 0; i < _myInt; i++)
            {
                Console.WriteLine("i < _myInt");
            }
            Console.WriteLine("i >= _myInt");
        }

        static void ForeachLoop()
        {
            foreach (var value in _myStringArray)
            {
                Console.WriteLine("value = {0}", value);
            }
            Console.WriteLine("end of loop");
        }
    }
}