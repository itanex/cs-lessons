using System;

namespace Lesson03.Models
{
    public class Product
    {
        public string Name { get; set; }
        private decimal _price;
        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value < 0m)
                {
                    throw new ArgumentOutOfRangeException("value", "Price cannot be less than zero.");
                }

                _price = value;
            }
        }

        public override string ToString()
        {
            return String.Format("{0} costs {1:c}", Name, Price);
        }
    }
}