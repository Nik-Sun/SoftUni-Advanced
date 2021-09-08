using System;
using System.Collections.Generic;

namespace _08.TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int carsCount = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            Queue<string> cars = new Queue<string>();
            int counter = 0;
            while (command != "end")
            {
                if (command == "green")
                {
                    for (int i = 0; i < carsCount; i++)
                    {
                        if (cars.Count>0)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            counter++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"{counter} cars passed the crossroads");
        }
    }
}
