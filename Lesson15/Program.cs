using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Lesson15
{
    class Program
    {
        // https://msdn.microsoft.com/library/hh191443(vs.110).aspx
        
        public async static Task DoSomething()
        {
            var client = new HttpClient();
            var page = await client.GetStringAsync("http://Microsoft.com");

            /*
             Wreck the world while waiting!
             */
            Console.WriteLine(page);
        }

        static void Main(string[] args)
        {
            // block synchronously until task is completed
            DoSomething().Wait();

            // pause
            Console.ReadLine();
        }
    }
}
