using System;
using Lesson07.Models;

namespace Lesson07
{
    class Program
    {
        static void Main(string[] args)
        {
            // var customer1 = new Customer();
            // var customer2 = new Customer()
            // {
            //     FirstName = "Howard",
            //     LastName = "Duck"
            // };
            var customer3 = new Customer(
                age: 32,
                lastName: "Adama",
                firstName: "Bill" 
                )
            {
                Age = 16
            };

            customer3.Age = 42;

            // Console.WriteLine("{0} {1}", customer1.FirstName, customer1.LastName);

            // Console.WriteLine("{0} {1}", customer2.FirstName, customer2.LastName);

            Console.WriteLine("{0} {1}", customer3.FirstName, customer3.LastName);
        }
    }
}
