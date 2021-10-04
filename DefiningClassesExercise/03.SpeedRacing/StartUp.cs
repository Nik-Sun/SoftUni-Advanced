using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace _03.SpeedRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int carsCount = int.Parse(Console.ReadLine());
            Dictionary<string, Car> garage = new Dictionary<string, Car>();

            for (int i = 0; i < carsCount; i++)
            {
                string[] carData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = carData[0];
                double fuelAmount = double.Parse(carData[1]);
                double fuelConsumption = double.Parse(carData[2]);
                Car car = new Car(model,fuelAmount,fuelConsumption);
                garage.Add(model,car);
            }

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] commandData = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = commandData[1];
                double kilometers = double.Parse(commandData[2]);
                garage[model].Drive(kilometers);
                input = Console.ReadLine();
            }

            foreach (var car in garage)
            {
                car.Value.Print();
            }
           
        }
    }
}
