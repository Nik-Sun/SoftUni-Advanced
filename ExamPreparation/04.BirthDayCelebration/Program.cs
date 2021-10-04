using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.BirthDayCelebration
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> guests = new Queue<int>(Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));
            Stack<int> plates = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));
            int wastedFood = 0;
            while (guests.Count>0 && plates.Count >0)
            {
                int currentGuest = guests.Dequeue();
                while (currentGuest>0)
                {
                    int currentPlate = plates.Pop();
                    if (currentPlate >= currentGuest)
                    {
                        wastedFood += currentPlate - currentGuest;
                        currentGuest -= currentPlate;
                    }
                    else
                    {
                        currentGuest -= currentPlate;
                    }
                }
            }
            Console.WriteLine(guests.Count > 0 ? $"Guests: {string.Join(" ",guests)}" : $"Plates: {string.Join(" ",plates)}");
            Console.WriteLine($"Wasted grams of food: {wastedFood}");
        }
    }
}
