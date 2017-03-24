using System;

namespace Lesson13
{
    class Program
    {
        static void Main(string[] args)
        {
            string demo1 = null;

            Console.WriteLine("DEMO 1 '{0}'", demo1);

            Product demo2 = null;

            Console.WriteLine("Demo 2 '{0}'", demo2);

            bool? demo3 = null;

            Console.WriteLine("Demo 3 '{0}'", demo3 ?? true);
        }
    }

    class Product {
        public string Name { get; set; }
    }
}
