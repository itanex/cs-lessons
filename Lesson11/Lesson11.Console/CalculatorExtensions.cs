using Lesson11.Models;

namespace Lesson11.ConsoleApp
{
    public static class CalculatorExtensions
    {
        /// <summary>
        /// Extension Method to add Modulus operations to our Calculator
        /// </summary>
        /// <param name="calculator"></param>
        /// <param name="x">Total to modulus From</param>
        /// <param name="y">Value to modulus total</param>
        /// <returns></returns>
        public static int Modulus(this Calculator calculator, int x, int y)
        {
            return x % y;
        }
    }
}
