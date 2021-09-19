using System;
using System.Collections.Generic;

namespace _05.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            SortedDictionary<char, int> counter = new SortedDictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (counter.ContainsKey(text[i]))
                {
                    counter[text[i]]++;
                }
                else
                {
                    counter.Add(text[i], 1);
                }
            }

            foreach (var item in counter)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
