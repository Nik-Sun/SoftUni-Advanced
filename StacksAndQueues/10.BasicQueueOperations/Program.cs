using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int queueCount = data[0];
            int dequeueCount = data[1];
            int numberToFind = data[2];
            Queue<int> numbers = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            for (int i = 0; i < dequeueCount; i++)
            {
                numbers.Dequeue();
            }
            if (numbers.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine( numbers.Contains(numberToFind) ? "true" : numbers.Min().ToString());
            }
        }
    }
}
