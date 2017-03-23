using System;
using Lesson04.Models;

namespace Lesson04
{
    class Program
    {
        static void Main(string[] args)
        {
            // create Milk product
            var product1 = new Product()
            {
                Name = "Milk",
                Price = 2.80m
            };

            // Perform different calculations
            var totalWithoutTax = product1.CalculateTotal();
            Console.WriteLine("Total without tax:" + totalWithoutTax.ToString("c"));

            var totalWithTax = product1.CalculateTotal(0.08m);
            Console.WriteLine("Total with tax:" + totalWithTax.ToString("c"));

            var totalWithTaxAndDiscount = product1.CalculateTotal(0.09m, 0.10m);
            Console.WriteLine("Total with tax and discount:" + totalWithTaxAndDiscount.ToString("c"));



            // pause
            Console.ReadLine();
        }
    }
}
