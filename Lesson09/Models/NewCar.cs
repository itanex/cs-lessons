using System;

namespace Lesson09.Models
{
    public class NewCar : Car
    {
        public decimal FirstTimeBuyerDiscount { get; private set; }
        protected override decimal taxRate
        {
            get
            {
                return 0.09m;
            }
        }

        public NewCar(string vin, string model, decimal firstTimeBuyerDiscount)
        : base(vin, model)
        {
            FirstTimeBuyerDiscount = firstTimeBuyerDiscount;
        }

        public override decimal CalculateTotal()
        {
            return Price + base.CalculateTax() - FirstTimeBuyerDiscount;
        }
    }
}