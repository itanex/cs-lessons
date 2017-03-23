using System;

namespace Lesson04.Models
{
    public class Product
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public decimal CalculateTotal()
        {
            return CalculateTotal(0, 0);
        }

        public decimal CalculateTotal(decimal taxRate)
        {
            return CalculateTotal(taxRate, 0);
        }
        
        public decimal CalculateTotal(decimal taxRate, decimal discount)
        {
            return Price + (Price * taxRate) - (Price * discount);
        }
    }
}