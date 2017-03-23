using System;
using Lesson05.Models;

namespace Lesson05
{
    class Program
    {
        static void Main(string[] args)
        {
            var emailer = new Emailer();

            emailer.Send(
                to: "Mike@Somewhere.com",
                from: "Bob@Somewhere.com", 
                body: "Lunch at the Taco Stand?",
                subject: "Let's get lunch!" 
            );

            // pause
            Console.WriteLine("Email sent.");
            Console.ReadLine();
        }
    }
}
