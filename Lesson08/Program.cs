using System;
using Lesson08.Models;

namespace Lesson08
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer("Bob", "Harris")
            {
                BillingAddress = {
                    Street = "101 Main Street",
                    City = "New York",
                    ZIP = "10022"
                },
                ShippingAddress = {
                    Street = "1 East Terrace Way",
                    City = "Seattle",
                    ZIP = "98122"
                }
            };

            var product = new Product("Soda Water", 34.99m);

            //Product.CalculateTax(product);

            // Console.Clear();
            // Console.Title = "Customer Report";
            // Console.BackgroundColor = ConsoleColor.DarkGray;
            // Console.ForegroundColor = ConsoleColor.Green;

            Console.Write(customer.ToString());
            Console.WriteLine();
            Console.WriteLine(product.ToString());

            // Console.Beep();
        }
    }
}
