using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool tiresDone = false;
            bool enginesDone = false;
            List<Tire[]> tirePairs = new List<Tire[]>();
            List<Engine> engines = new List<Engine>();
            List<Car> garage = new List<Car>();
            while (input != "Show special")
            {
                if (input == "No more tires")
                {
                    tiresDone = true;
                    input = Console.ReadLine();
                    continue;
                }
                if (input == "Engines done")
                {
                    enginesDone = true;
                    input = Console.ReadLine();
                    continue;
                }
                if (tiresDone && enginesDone == false)
                {
                    double[] engineInfo = input
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .Select(double.Parse)
                        .ToArray();
                    Engine engine = new Engine((int)engineInfo[0], engineInfo[1]);
                    engines.Add(engine);
                }
                else if (enginesDone && tiresDone)
                {
                    string[] carInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    string make = carInfo[0];
                    string model = carInfo[1];
                    int year = int.Parse(carInfo[2]);
                    int fuel = int.Parse(carInfo[3]);
                    double consumption = double.Parse(carInfo[4]);
                    int idxForEngine = int.Parse(carInfo[5]);
                    int idxForTires = int.Parse(carInfo[6]);
                    Car car = new Car(make, model, year, fuel, consumption, engines[idxForEngine], tirePairs[idxForTires]);
                    garage.Add(car);
                }
                else
                {

                    double[] tiresInfo = input
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .Select(double.Parse)
                        .ToArray();
                    List<Tire> currentTires = new List<Tire>();
                    for (int i = 0; i < tiresInfo.Length; i += 2)
                    {
                        int year = (int)tiresInfo[i];
                        double pressure = tiresInfo[i + 1];
                        Tire tire = new Tire(year, pressure);
                        currentTires.Add(tire);
                    }
                    tirePairs.Add(currentTires.ToArray());
                }

                input = Console.ReadLine();
            }

            garage = garage.Where(c => c.Year >= 2017)
                .Where(c => c.Engine.HorsePower > 330)
                .Where(c => c.Tires.Select(x => x.Pressure).Sum() >= 9)
                .Where(c => c.Tires.Select(p => p.Pressure).Sum() <= 10)
                .ToList();

            foreach (Car car in garage)
            {
                car.Drive(20);
                Console.WriteLine(car.WhoAmI());
            }
        }
    }
}
