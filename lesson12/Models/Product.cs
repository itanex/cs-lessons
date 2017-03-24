using System;

namespace Lesson12.Models
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public override bool Equals(object test)
        {
            var result = false;
            var testObj = test as Product;

            if(testObj != null)
            {
                result = this.Name == testObj.Name 
                    && this.Price == testObj.Price;
            }

            return result;
        }
    }
}