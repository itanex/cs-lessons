using System;

namespace Lesson11.Models
{
    public abstract class Car
    {
        protected virtual decimal taxRate
        {
            get
            {
                return 0.08m;
            }
        }
        public string VIN { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

         public Car(string vin, string model)
        {
            VIN = vin;
            Model = model;
        }

        public decimal CalculateTax()
        {
            return Price * taxRate;
        }

        public abstract decimal CalculateTotal();

        public override string ToString()
        {
            return String.Format("{0} Cost: {1} Tax: {2}", Model, Price, CalculateTax());
        }
    }
}