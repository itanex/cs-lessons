using System;

namespace Lesson11.Models
{
    internal class UsedCar : Car
    {
        private decimal _taxRate;
        protected override decimal taxRate
        {
            get
            {
                return _taxRate;
            }
        }


        public UsedCar(string vin, string model)
            : base(vin, model)
        {
            _taxRate = 0.095m;
        }
        
        public override decimal CalculateTotal()
        {
            return Price + base.CalculateTax();
        }

        public int Miles { get; set; }
    }
}