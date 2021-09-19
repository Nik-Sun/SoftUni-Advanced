using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int firstSetSize = sizes[0];
            int secondSetSize = sizes[1];
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < firstSetSize + secondSetSize; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (i < firstSetSize)
                {
                    firstSet.Add(currentNum);
                }
                else 
                {
                    secondSet.Add(currentNum);
                }
            }

            HashSet<int> resultSet = new HashSet<int>();
            foreach (var item in firstSet)
            {
                if (secondSet.Contains(item))
                {
                    resultSet.Add(item);
                }
            }
            Console.WriteLine(string.Join(" ",resultSet));
        }
    }
}
