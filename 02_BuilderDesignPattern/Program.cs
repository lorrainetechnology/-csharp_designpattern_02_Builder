using System;

namespace _02_BuilderDesignPattern
{
    internal class Program
    {
        static void Main()
        {
            var director = new Director();
            IBuilder builder1 = new ConcreteBuilder1();
            
            director.Builder = builder1;
            director.Construct();
            IProduct p1 = builder1.GetProduct();
            p1.ListParts();

            IBuilder builder2 = new ConcreteBuilder2();
            director.Builder = builder2;

            director.Construct();
            IProduct p2 = builder2.GetProduct();
            p2.ListParts();

            Console.ReadLine();
        }
    }
}
