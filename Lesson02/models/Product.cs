using System;

namespace Lesson02.Models
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public decimal CalculateTax()
        {
            return Price * .08m;
        }

        public override string ToString() {
            return String.Format("{0}: {1:c} + {2:c} tax", Name, Price, CalculateTax());
        }
    }
}
