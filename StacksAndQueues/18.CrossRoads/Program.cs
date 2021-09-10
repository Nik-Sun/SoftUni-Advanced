using System;
using System.Collections.Generic;

namespace _18.CrossRoads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeTime = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            Queue<string> cars = new Queue<string>();
            int carsCounter = 0;
            while (input != "END")
            {
                if (input == "green")
                {
                    int currentLight = greenLight;
                    while (currentLight>0)
                    {
                        if (cars.Count==0)
                        {
                            break;
                        }
                        else
                        {
                            string currentCar = cars.Dequeue();
                            currentLight -= currentCar.Length;
                            if (currentLight + freeTime < 0)
                            {
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{currentCar} was hit in {currentCar[currentCar.Length - Math.Abs(currentLight + freeTime)]}");
                                Environment.Exit(0);
                            }
                            else
                            {
                                carsCounter++;
                            }
                        }
                        
                    }
                }
                else
                {
                    cars.Enqueue(input);
                }

                input = Console.ReadLine();
            }
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{carsCounter} total cars passed the crossroads.");
        }
    }
}
