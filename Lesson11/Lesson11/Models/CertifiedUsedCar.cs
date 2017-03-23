using System;

namespace Lesson11.Models
{
    internal class CertifiedUsedCar : UsedCar
    {
        private decimal DealershipDiscount;
        public int WarrantyMonths { get; set; }

        public CertifiedUsedCar(string vin, string model, decimal dealershipDiscount)
            : base(vin, model)
        {
            DealershipDiscount = dealershipDiscount;
        }
        
        public override decimal CalculateTotal()
        {
            return base.CalculateTotal() - DealershipDiscount;
        }
    }
}