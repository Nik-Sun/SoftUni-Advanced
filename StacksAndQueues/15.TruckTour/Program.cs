using System;
using System.Collections.Generic;
using System.Linq;

namespace _15.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int pumpsCount = int.Parse(Console.ReadLine());
            Queue<int[]> circleOfPumps = new Queue<int[]>();
            for (int i = 0; i < pumpsCount; i++)
            {
                int[] current = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                circleOfPumps.Enqueue(current);
            }
           
            for (int i = 0; i < circleOfPumps.Count; i++)
            {
                Queue<int[]> copy = new Queue<int[]>(circleOfPumps);
                int gas = 0;
                for (int j = 0; j < copy.Count; j++)
                {
                    gas += copy.Peek()[0]- copy.Peek()[1];
                    if (gas <0)
                    {
                        break;
                    }
                    else
                    {
                        copy.Enqueue(copy.Dequeue());
                    }

                }
                if (gas < 0)
                {
                    circleOfPumps.Enqueue(circleOfPumps.Dequeue());
                }
                else
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}
