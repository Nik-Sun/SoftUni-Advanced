using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int[], bool> func = (num, dividers) =>
            {
                List<int> temp = new List<int>();
                for (int i = 0; i < dividers.Length; i++)
                {
                    if (num % dividers[i] !=0)
                    {
                        return false;
                    }
                }
                return true;
            };
            
            int endRange = int.Parse(Console.ReadLine());
            List<int> result = new List<int>();
            for (int i = 1; i <= endRange; i++)
            {
                result.Add(i);
            }
            int[] dividers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            result = result.Where(n => func(n, dividers)).ToList();
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
