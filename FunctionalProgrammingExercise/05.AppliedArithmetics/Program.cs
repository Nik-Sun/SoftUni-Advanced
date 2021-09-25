using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<List<int>, string, List<int>> manipulator = (l, s) => {
                switch (s)
                {
                    case "add":
                        return l.Select(i => i+1).ToList();
                    case "multiply":
                        return l.Select(i => i * 2).ToList();
                    case "subtract":
                        return l.Select(i => i - 1).ToList();
                    case "print":
                        Console.WriteLine(string.Join(" ",l));
                        return l;
                    default:
                        return l;
                }
            };
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string command = Console.ReadLine();
            while (command != "end")
            {
                numbers = manipulator(numbers, command);
                command = Console.ReadLine();
            }
        }
    }
}
