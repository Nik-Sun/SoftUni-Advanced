using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.CarSalesman
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int enginesCount = int.Parse(Console.ReadLine());
            List<Engine> engines = new List<Engine>();
          
            for (int i = 0; i < enginesCount; i++)
            {
                string[] engineData = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                Engine engine = new Engine(engineData);
                engines.Add(engine);
            }

            int carsCount = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < carsCount; i++)
            {
                string[] carData = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                Engine carEngine = engines[engines.FindIndex(e => e.Model == carData[1])];
                Car car = new Car(carData, carEngine);
                cars.Add(car);
            }

            foreach (Car car in cars)
            {
                Console.WriteLine(car.ToString());  
            }
        }
    }
}
