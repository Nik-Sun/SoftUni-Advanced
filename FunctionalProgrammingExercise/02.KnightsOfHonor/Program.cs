using System;
using System.Linq;

namespace _02.KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> printAndAppend = s => Console.WriteLine($"Sir {s}");
            Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(s => printAndAppend(s));
        }
    }
}
