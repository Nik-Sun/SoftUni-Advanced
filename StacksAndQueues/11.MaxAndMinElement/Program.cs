using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.MaxAndMinElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int queriesCount = int.Parse(Console.ReadLine());
            Stack<int> result = new Stack<int>();

            for (int i = 0; i < queriesCount; i++)
            {
                Queue<int> queue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
                int command = queue.Dequeue();

                if (command == 1)
                {
                    result.Push(queue.Dequeue());
                }
                else if (command == 2 && result.Count>0)
                {
                    result.Pop();
                }
                else if (result.Count >0)
                {
                    Console.WriteLine(command == 3 ? $"{result.Max()}" : $"{result.Min()}");
                }
                
            }
            Console.WriteLine(string.Join(", ",result));
        }
    }
}
