using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> predicate = s => s == "even";
            int[] boundaries = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string condition = Console.ReadLine();
            List<int> result = new List<int>();
           
            for (int i = boundaries[0]; i <= boundaries[1]; i++)
            {
                if (predicate(condition))
                {
                    if (i%2==0)
                    {
                        result.Add(i);
                    }
                }
                else
                {
                    if (i % 2 != 0)
                    {
                        result.Add(i);
                    }
                }
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
