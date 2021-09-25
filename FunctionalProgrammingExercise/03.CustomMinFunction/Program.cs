using System;
using System.Linq;

namespace _03.CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> func = arr => {
                int min = int.MaxValue;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i]< min)
                    {
                        min = arr[i];
                    }
                }
                return min;
            };
            Console.WriteLine(func(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray())); 
        }
    }
}
