using System;
using System.Collections.Generic;
using System.Linq;

namespace _20.CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> cups = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> bottles = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int wastedWater = 0;
            while (cups.Count > 0 && bottles.Count > 0)
            {
                
                int currentCup = cups.Peek();
                while (currentCup>0)
                {
                    int currentBottle = 0;
                    if (bottles.TryPop(out currentBottle))
                    {
                        if (currentCup > currentBottle)
                        {
                            currentCup -= currentBottle;
                        }
                        else if (currentCup <= currentBottle)
                        {
                            currentBottle -= currentCup;
                            wastedWater += currentBottle;
                            currentCup = 0;
                            cups.Dequeue();
                        }
                    }
                    else
                    {
                        break;
                    }
                   
                }
               
            }
            Console.WriteLine(bottles.Count>0 ? $"Bottles: {string.Join(" ",bottles)}" : $"Cups: {string.Join(" ",cups)}");
            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
