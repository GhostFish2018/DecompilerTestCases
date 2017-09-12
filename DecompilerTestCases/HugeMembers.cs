using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    public class HugeMembers
    {
        private int _myInt = 3;
        public void HugeMethodBody()
        {
           foreach (var type in Type.EmptyTypes)
           {
               Console.WriteLine(type);
               do
               {
                   Console.WriteLine("test");
               } while (_myInt != 3);
               Console.WriteLine("test");
               do
               {
                   Console.WriteLine("test");
               } while (_myInt <= 4);
               Console.WriteLine("test");
               do
               {
                   Console.WriteLine("test");
               } while (_myInt > 5);
               Console.WriteLine("test");
               do
               {
                   Console.WriteLine("test");
               } while (_myInt == 6);
                while (_myInt > 0)
                {
                    do
                    {
                        Console.WriteLine("test");
                    } while (_myInt == 1);
                    Console.WriteLine("test");
                    do
                    {
                        Console.WriteLine("test");
                    } while (_myInt == 2);
                    Console.WriteLine("test");
                    do
                    {
                        Console.WriteLine("test");
                    } while (_myInt != 3);
                    Console.WriteLine("test");
                    do
                    {
                        Console.WriteLine("test");
                    } while (_myInt <= 4);
                    Console.WriteLine("test");
                    do
                    {
                        Console.WriteLine("test");
                    } while (_myInt > 5);
                    Console.WriteLine("test");
                    do
                    {
                        Console.WriteLine("test");
                    } while (_myInt == 6);
                }
                foreach (var type1 in Type.EmptyTypes)
                {
                    while (_myInt > 0)
                    {
                        do
                        {
                            Console.WriteLine("test");
                        } while (_myInt == 1);
                        Console.WriteLine("test");
                        do
                        {
                            Console.WriteLine("test");
                        } while (_myInt == 2);
                        Console.WriteLine("test");
                        do
                        {
                            Console.WriteLine("test");
                        } while (_myInt != 3);
                        Console.WriteLine("test");
                        do
                        {
                            Console.WriteLine("test");
                        } while (_myInt <= 4);
                        Console.WriteLine("test");
                        do
                        {
                            Console.WriteLine("test");
                        } while (_myInt > 5);
                        Console.WriteLine("test");
                        do
                        {
                            Console.WriteLine("test");
                        } while (_myInt == 6);
                    }
                }
                do
                {
                    Console.WriteLine("test");
                } while (_myInt != 3);
                Console.WriteLine("test");
                do
                {
                    Console.WriteLine("test");
                } while (_myInt <= 4);
                Console.WriteLine("test");
                do
                {
                    Console.WriteLine("test");
                } while (_myInt > 5);
                Console.WriteLine("test");
                do
                {
                    Console.WriteLine("test");
                } while (_myInt == 6);
           }
           do
           {
               Console.WriteLine("test");
           } while (_myInt != 3);
           Console.WriteLine("test");
           do
           {
               Console.WriteLine("test");
           } while (_myInt <= 4);
           Console.WriteLine("test");
           do
           {
               Console.WriteLine("test");
           } while (_myInt > 5);
           Console.WriteLine("test");
           do
           {
               Console.WriteLine("test");
           } while (_myInt == 6);
        }
    }
}
