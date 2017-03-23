using System;
using Lesson02.Models;

namespace Lesson02
{
    class Program
    {
        static void Main(string[] args)
        {
            var product1 = new Product()
            {
                Name = "Milk",
                Price = 2.33m
            };

            var product2 = new Product()
            {
                Name = "Eggs",
                Price = 1.33m,
            };

            // display products
            // Console.WriteLine(String.Format("{0}: {1:c} + {2:c} tax", product1.Name, product1.Price, product1.CalculateTax()));
            // Console.WriteLine(String.Format("{0}: {1:c} + {2:c} tax", product2.Name, product2.Price, product2.CalculateTax()));
            Console.WriteLine(product1.ToString());
            Console.WriteLine(product2.ToString());

            // wait for user input to exit Program
            Console.ReadKey();
        }
    }
}
