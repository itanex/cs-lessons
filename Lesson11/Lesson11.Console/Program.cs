using Lesson11.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson11.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();

            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Subtract(1, 2));
            Console.WriteLine(calculator.Multiply(1, 2));
            Console.WriteLine(calculator.Divide(1, 2));
            Console.WriteLine(calculator.Modulus(1, 2));

            Console.ReadKey();


            string message = "Hello World";

            Console.WriteLine(message.Reverse());

            Console.ReadKey();

            var menu = new List<string>()
            {
                "Orange Chicken",
                "General Tsos",
                "Egg Foo Young"
            };

            menu.ForEach(item => Console.WriteLine(item));
            

            Console.ReadKey();

        }
    }
}
