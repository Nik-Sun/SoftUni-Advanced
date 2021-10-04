using System;
using System.Collections.Generic;
using System.Text;

namespace SkiRental
{
    public class Ski
    {
        public string Manifacturer { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public Ski(string manifacturer,string model, int year)
        {
            Manifacturer = manifacturer;
            Model = model;
            Year = year;
        }
        public override string ToString()
        {
            return $"{Manifacturer} - {Model} - {Year}";
        }
    }
}
