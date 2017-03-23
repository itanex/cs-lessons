using System;

namespace Lesson08.Models
{
    public class Product
    {
        // Static private field
        private static decimal taxRate;

        public string Name { get; set; }
        public decimal Price { get; set; }

        // Static Constructor
        static Product()
        {
            taxRate = 0.08m;
        }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        // Static Public Method
        public static decimal CalculateTax(Product product)
        {
            return product.Price * taxRate;
        }

        public override string ToString()
        {
            // Leverages the static method CalculateTax
            // 'this' refers to the Object INSTANCE not the STATIC definition
            return String.Format("{0} Cost: {1:c} + Tax: {2:c}", Name, Price, CalculateTax(this));
        }
    }
}