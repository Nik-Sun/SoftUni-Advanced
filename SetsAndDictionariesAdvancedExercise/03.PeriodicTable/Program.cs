using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());
            SortedSet<string> uniqueElements = new SortedSet<string>();

            for (int i = 0; i < linesCount; i++)
            {
                string line = Console.ReadLine();
                string[] elements = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                foreach (var item in elements)
                {
                    uniqueElements.Add(item);
                }
            }
            Console.WriteLine(string.Join(" ",uniqueElements));
        }
    }
}
