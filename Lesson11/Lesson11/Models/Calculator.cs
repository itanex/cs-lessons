namespace Lesson11.Models
{
    public class Calculator
    {
        /// <summary>
        /// Adds two numbers
        /// </summary>
        /// <param name="x">First Number to Add</param>
        /// <param name="y">Last Number to Add</param>
        /// <returns>Sum of <paramref name="x"/> and <paramref name="y"/></returns>
        public int Add(int x, int y)
        {
            return x + y;
        }
        
        public int Subtract(int x, int y)
        {
            return x - y;
        }

        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public int Divide(int x, int y)
        {
            return x / y;
        }
    }
}
