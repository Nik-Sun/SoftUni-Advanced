using System;
using System.Linq;

namespace _04.AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] prices = Console.ReadLine()
                .Split(", ")
                .Select(decimal.Parse)
                .Select(p => p * 1.20M)
                .ToArray();

            foreach (var price in prices)
            {
                Console.WriteLine($"{price :f2}");
            }
        }
    }
}
