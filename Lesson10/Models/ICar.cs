using System;

namespace Lesson10.Models
{
    public interface ICar
    {
        string Make { get; set; }
        string Model { get; set; }
        int Year { get; set; }
    }
}