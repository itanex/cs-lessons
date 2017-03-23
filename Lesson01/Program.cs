using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Lesson01
{
    class Program
    {
        static string[] emails = {
            "david.jones@proseware.com",
            "d.j@server1.proseware.com",
            "jones@ms1.proseware.com",
            "j.@server1.proseware.com",
            "j@proseware.com9",
            "js#internal@proseware.com",
            "j_9@129.126.118.1",
            "j..s@proseware.com", // invalid
            "js*@proseware.com",  // invalid
            "js@proseware..com",  // invalid
            "js@proseware.com9",
            "j.s@server1.proseware.com"
        };
        static void Main(string[] args)
        {
            for (var i = 0; i <= 100; i++)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            var x = 0;
            do
            {
                if (x % 7 == 0)
                {
                    Console.WriteLine(x);
                }
                x++;
            } while (x <= 100);


            var a = 0;
            while (a <= 100)
            {
                if (a % 7 == 0)
                {
                    Console.WriteLine(a);
                }
                a++;
            }

            // Output a table list using String.Format that displays as such
            //
            // Valid   | <valid email>
            // Invalid | <invalid email>

            // pause
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }

    class Car
    {
        public int Year { get; set; }
    }
}
