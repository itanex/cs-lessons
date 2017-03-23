using System;

namespace Lesson10.Models
{
    public class Truck : ICar
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1} ({2}) - {3}", Make, Model, Year, Color);
        }
    }
}