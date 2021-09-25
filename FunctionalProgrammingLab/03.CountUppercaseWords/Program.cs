using System;
using System.Linq;

namespace _03.CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> predicate = str => char.IsUpper(str[0]);
            string[] uppercaseWords = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(predicate)
                .ToArray();

            foreach (var word in uppercaseWords)
            {
                Console.WriteLine(word);
            }

        }
    }
}
