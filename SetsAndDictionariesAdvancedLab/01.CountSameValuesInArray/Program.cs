using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            Dictionary<double, int> counter = new Dictionary<double, int>();
            foreach (var item in array)
            {
                if (counter.ContainsKey(item) == false)
                {
                    counter.Add(item, 1);
                }
                else
                {
                    counter[item]++;
                }
            }


            foreach (var item in counter)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
