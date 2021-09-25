using System;
using System.Linq;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int nameLenght = int.Parse(Console.ReadLine());
            Func<string, int, bool> predicate = (str,lght ) => str.Length <= lght;
            Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(s => predicate(s, nameLenght))
                .ToList()
                .ForEach(s => Console.WriteLine(s));
        }
    }
}
