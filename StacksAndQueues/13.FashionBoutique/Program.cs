using System;
using System.Collections.Generic;
using System.Linq;

namespace _13.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> clothes = new Stack<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse));
            int rackCapacity = int.Parse(Console.ReadLine());
            int racksCount = 1;
            int currentRack = rackCapacity;
            while (clothes.Count >0)
            {
                if (currentRack - clothes.Peek() >= 0)
                {
                    currentRack -= clothes.Pop();
                }
                else
                {
                    racksCount++;
                    currentRack = rackCapacity;
                }
            }
            Console.WriteLine(racksCount);
           
        }
    }
}
