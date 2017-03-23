using System;
using System.Collections.Generic;
using Lesson09.Models;

namespace Lesson09
{
    class Program
    {
        static void Main(string[] args)
        {
            var newCar = new NewCar("KJASDHFKJA939", "BMW", 600)
            {
                Price = 45000m
            };

            var usedCar = new UsedCar("OIUIOFSF7676sdf", "Subaru")
            {
                Price = 45000m,
                Miles = 4000
            };
            
            var certifiedUsedCar = new CertifiedUsedCar("UWYERU8374", "Mini Cooper", 300)
            {
                Price = 45000m,
                Miles = 4000,
                WarrantyMonths = 12
            };

            var carInventory = new List<Car>();

            carInventory.Add(newCar);
            carInventory.Add(usedCar);
            carInventory.Add(certifiedUsedCar);

            Console.Clear();

            Console.WriteLine(newCar);
            Console.WriteLine(carInventory[0]);
            Console.WriteLine("'-------------------------------'");

            Console.WriteLine(usedCar);
            Console.WriteLine(carInventory[1]);
            Console.WriteLine("'-------------------------------'");
            
            Console.WriteLine(certifiedUsedCar);
            Console.WriteLine(carInventory[2]);
            Console.WriteLine("'-------------------------------'");
            
        }
    }
}
