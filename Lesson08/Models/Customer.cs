using System;

namespace Lesson08.Models
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address BillingAddress { get; set; }
        public Address ShippingAddress { get; set; }

        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            BillingAddress = new Address();
            ShippingAddress = new Address();
        }

        public override string ToString() 
        {
            return String.Format("{0} {1}\n\n----------\n{2}\n\n----------\n{3}",
                FirstName,
                LastName,
                BillingAddress,
                ShippingAddress);
        }
    }
}