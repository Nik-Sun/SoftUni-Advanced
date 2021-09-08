using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split()
                .Select(int.Parse)
                .ToArray();
            Queue<int> intQueue = new Queue<int>(numbers);
            int count = intQueue.Count;

            for (int i = 0; i < count; i++)
            {
                int nextInQueue = intQueue.Dequeue();
                if (nextInQueue % 2 == 0)
                {
                    intQueue.Enqueue(nextInQueue);
                }
            }
            
               
            
            Console.WriteLine(string.Join(", ",intQueue));

        }
    }
}
