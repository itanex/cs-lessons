using System;
using System.Collections.Generic;

namespace Lesson11.ConsoleApp
{
    public static class StringExtensions
    {
        /// <summary>
        /// Returns the reverse of this string
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static string Reverse(this String self)
        {
            var textArray = self.ToCharArray();
            Array.Reverse(textArray);

            return new string(textArray);

        }
    }
}
