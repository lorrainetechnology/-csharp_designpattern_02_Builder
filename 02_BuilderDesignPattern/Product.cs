using System;
using System.Collections.Generic;

namespace _02_BuilderDesignPattern
{
    public interface IProduct
    {
        void Add(string part);
        void ListParts();
    }

    public class Product : IProduct
    {
        private List<string> _parts = new List<string>();

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public void ListParts()
        {
            Console.WriteLine("\nProduct Parts : \n");
            foreach (string part in _parts)
                Console.WriteLine(part);
            Console.WriteLine("");
        }
    }
}
