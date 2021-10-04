using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int carsCount = int.Parse(Console.ReadLine());
            List<Car> garage = new List<Car>();

            for (int i = 0; i < carsCount; i++)
            {
                string[] carData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                List<(double, int)> tires = new List<(double, int)>();
                for (int j = 5; j < carData.Length; j+=2)
                {
                    tires.Add((double.Parse(carData[j]),int.Parse(carData[j+1])));
                }
                Car car = new Car(carData[0],int.Parse(carData[1]),int.Parse(carData[2]),int.Parse(carData[3]),carData[4],tires.ToArray());
                garage.Add(car);

            }
            string input = Console.ReadLine();
            if (input == "fragile")
            {
                garage = garage.Where(c => c.Cargo.CargoType == "fragile").Where(c => c.Tires.Any(t=> t.Pressure<1)).ToList();
            }
            else if(input == "flammable")
            {
                garage = garage.Where(c => c.Cargo.CargoType == "flammable").Where(c => c.Engine.EnginePower > 250).ToList();
            }
            foreach (Car car in garage)
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}
