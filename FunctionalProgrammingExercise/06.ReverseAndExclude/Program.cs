using System;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int divisible = int.Parse(Console.ReadLine());
            Func<int, bool> predicate = i => i % divisible != 0;
            Func<int[], int[]> reverse = i => i.Reverse().ToArray();
            numbers = reverse(numbers.Where(predicate).ToArray());
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
