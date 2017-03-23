using System;

namespace Lesson07.Models
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }

        // public Customer()
        // {
        //     FirstName = "Jane";
        //     LastName = "Doe";
        // }

        public Customer(string firstName, string lastName, int age = 16)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}