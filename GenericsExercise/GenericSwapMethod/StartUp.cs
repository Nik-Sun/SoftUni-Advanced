using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethod
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            for (int i = 0; i < count; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }
            int[] indexes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            list = SwapIndexes(list,indexes[0],indexes[1]);
            foreach (var item in list)
            {
                Console.WriteLine($"{item.GetType()}: {item}");
            }
        }
        static List<T> SwapIndexes<T>(List<T> list,int firstIndex,int secondIndex)
        {
            T temp = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = temp;
            return list;
        }
    }
}
