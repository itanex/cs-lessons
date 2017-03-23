using System;
using Lesson03.Models;

namespace Lesson03
{
    class Program
    {
        static void Main(string[] args)
        {
            // create Milk product
            var product1 = new Product()
            {
                Name = "Milk",
                // Price = "2.99"
                Price = 2.99m
            };

            // change the price
            // product1.Price = "3.44";
            product1.Price = 3.44m;

            // display the name and price
            // Console.WriteLine(String.Format("{0} costs {1}", product1.Name, product1.Price));
            Console.WriteLine(product1.ToString());
        }
    }
}
