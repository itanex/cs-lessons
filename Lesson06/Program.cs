using System;
using Lesson06.Models;

namespace Lesson06
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create instance of shopping cart
            var cart = new ShoppingCart();

            // Add items
            cart.AddItem("Milk");
            cart.AddItem("Shampoo", "Kleenex", "Soup", "Dog Food");
            cart.AddItem("Apples", "Eggs");

            Console.ReadKey();
        }
    }
}
