using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());
            Dictionary<int, int> numbers = new Dictionary<int, int>();

            for (int i = 0; i < linesCount; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                if (numbers.ContainsKey(currentNum))
                {
                    numbers[currentNum]++;
                }
                else
                {
                    numbers.Add(currentNum, 1);
                }
            }
            int x = numbers.Where(x => x.Value % 2 == 0).Single().Key;

            Console.WriteLine(x);

        }
    }
}
