using System;
using Lesson12.Models;

namespace lesson12
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product()
            {
                Name = "Orange",
                Price = 0.79m
            };

            decimal value = 43;

            // Console.WriteLine("PRODUCT: {0} {1}", product.Name, product.Price);
            // Console.WriteLine("VALUE: {0}", value);

            // UpdateValue(ref value);
            // UpdatePrice(ref product);

            // Console.WriteLine("PRODUCT: {0} {1}", product.Name, product.Price);
            // Console.WriteLine("VALUE: {0}", value);

            string name1 = "Bryan";
            string name2 = "Bryan";

            Console.WriteLine("Name1 == Name2 :: {0}", name1 == name2);

            var product2 = new Product()
            {
                Name = "Orange",
                Price = 0.79m
            };

            Console.WriteLine("Product == Product2 :: {0}", product == product2);

            Console.WriteLine("Product.Equals(Product2) :: {0}", product.Equals(product2));

        }

        static void UpdateValue(ref decimal value)
        {
            value = 88m;
        }

        static void UpdatePrice(ref Product product)
        {
            product = new Product();
            product.Name = "Xbox";
            product.Price = 299.47m;
        }
    }
}
