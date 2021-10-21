using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.TheFightForGondor
{
    class Program
    {
        static void Main(string[] args)
        {
            int wavesCount = int.Parse(Console.ReadLine());
            List<int> defence = new List<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));
            Stack<int> orcs = new Stack<int>();
            bool defenceDestroyed = false;
            for (int wave = 1; wave <= wavesCount; wave++)
            {
               
                orcs = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

                if (wave % 3 == 0)
                {
                    defence.Add(int.Parse(Console.ReadLine()));
                    defenceDestroyed = false;
                }

                while (orcs.Count > 0 )
                {
                    int currentOrc = orcs.Pop();
                    if (defence[0] < currentOrc)
                    {
                        currentOrc -= defence[0];
                        defence.RemoveAt(0);
                        orcs.Push(currentOrc);
                    }
                    else if (defence[0]> currentOrc)    
                    {
                        defence[0] -= currentOrc;
                    }
                    else
                    {
                        defence.RemoveAt(0);
                    }
                    if (defence.Count==0)
                    {
                        defenceDestroyed = true;
                        break;
                    }

                }
                if (defenceDestroyed)
                {
                    break;
                }
            }
            Console.WriteLine(defence.Count>0 ? "The people successfully repulsed the orc's attack." : "The orcs successfully destroyed the Gondor's defense.");
            Console.WriteLine(defence.Count >0 ? $"Plates left: {string.Join(", ", defence)}" : $"Orcs left: {string.Join(", ",orcs)}");
        }
    }
}
