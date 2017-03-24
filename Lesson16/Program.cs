using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Lesson16
{
    class Program
    {
        static void Main(string[] args)
        {
            var movie = new MovieWriter()
            {
                Name = "Power Rangers"
            };

            movie.Save();

            movie.Dispose();
        }
    }

    class MovieWriter : IDisposable
    {
        private FileStream stream = new FileStream("C:\test.txt", FileMode.OpenOrCreate);
        public string Name { get; set; }

        public void Save() 
        {
            stream.WriteByte("Hello world");
        }

        public void Dispose()
        {
            stream.Flush();
            stream.Dispose();
            stream = null;
        }
    }
}
