using System;
using System.Collections.Generic;
using Lesson10.Models;

namespace Lesson10
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car()
            {
                Make = "Subaru",
                Model = "CrossTrek",
                Year = 2014,
                Color = "Orange"
            };

            var truck = new Truck()
            {
                Make = "Ford",
                Model = "F150",
                Year = 2016,
                Color = "Black"
            };

            var inventory = new List<ICar>()
            {
                truck,
                car
            };

            foreach (var item in inventory)
            {
                Console.WriteLine(item);
                Console.WriteLine(FormatICar(item));
            }
        }

        static string FormatICar(ICar car)
        {
            return String.Format("{0} {1} ({2})", car.Make, car.Model, car.Year);
        }
    }
}
