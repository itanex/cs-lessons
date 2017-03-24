using System;
using System.Collections.Generic;

namespace Lesson14
{
    class Program
    {
        static void Main(string[] args)
        {
            // Single instance of an item is written as a singular noun
            // Muliple instnance or Colleciton of Items is written as a plural noun

            var movies = new List<string>();

            movies.Add("Star Wars");
            movies.Add("King Kong");
            movies.Add("Memento");

            movies.AddRange(new string[] { "a", "a", "a", "a", "a", "a", "a", "a" });

            movies.TrueForAll(x => x.Length > 0);

            var states = new Dictionary<string, string>();
            states.Add("ca", "California");
            states.Add("tx", "Texas");
            states.Add("wa", "Washington");

            states.ContainsKey("or");
            states.ContainsValue("Oregon");


        }
    }
}
