using System;
using System.Collections.Generic;

namespace _06.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            HashSet<string> parking = new HashSet<string>();
 
            while (line != "END")
            {
                string[] lineData = line.Split(", ",StringSplitOptions.RemoveEmptyEntries);
                string direction = lineData[0];
                string carNumber = lineData[1];

                if (direction=="IN")
                {
                    parking.Add(carNumber);
                }
                else
                {
                    parking.Remove(carNumber);
                }

                line = Console.ReadLine();
            }
            if (parking.Count==0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            foreach (var car in parking)
            {
                Console.WriteLine(car);
            }
        }
    }
}
