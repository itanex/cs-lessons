using System;

namespace Lesson08.Models
{
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string ZIP { get; set; }

        public override string ToString() 
        {
            return String.Format("    {0}\n    {1}\n    {2}", 
                Street, City, ZIP);
        }
    }
}