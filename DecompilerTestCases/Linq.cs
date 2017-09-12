using System;
using System.Collections.Generic;
using System.Linq;

namespace DecompilerTestCases
{
    public class Linq
    {
        private readonly IList<string> _collection = new List<string>();

        public void First()
        {
            Console.WriteLine(_collection.First());
            Console.WriteLine(_collection.First(x => x.Length == 3));
        }

        public void Select()
        {
            var records = from item in _collection
                          select item.Substring(2);
            Console.WriteLine(records.First());
        }
        
        public void Where()
        {
            var records = from item in _collection
                          where item.StartsWith("test")
                          select item.Substring(2);
            Console.WriteLine(records.First());
        }

        public void Let()
        {
            var records = from item in _collection
                          let subItem = item.Substring(2)
                          where subItem.StartsWith("test")
                          select subItem.PadLeft(1);
            Console.WriteLine(records.First());
        }

        public void OrderBy()
        {
            var records = from item in _collection
                          where item.StartsWith("test")
                          orderby item ascending
                          select item.Substring(2);
            Console.WriteLine(records.First());

            var records2 = from item in _collection
                          where item.StartsWith("test")
                          orderby item descending
                          select item.Substring(2);
            Console.WriteLine(records2.First());
        }
    }
}
