using System;
using System.Collections.Generic;

namespace SoftUniParking
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var car = new Car("Skoda", "Fabia", 65, "CC1856BG");
            var car2 = new Car("Audi", "A3", 110, "EB8787MN");

            Parking parking = new Parking(2);
            Console.WriteLine(parking.AddCar(car));
            Console.WriteLine(parking.AddCar(car2));
            List<string> n = new List<string>() { "CC1856BG" }; 
            parking.RemoveSetOfRegistrationNumber(n);
            Console.WriteLine(parking.Count); 
        }
    }
}
