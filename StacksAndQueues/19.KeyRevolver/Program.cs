using System;
using System.Collections.Generic;
using System.Linq;

namespace _19.KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int barrelSize = int.Parse(Console.ReadLine());

            Stack<int> bullets = new Stack<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse));


            Queue<int> locks = new Queue<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse));
                
            int intelligenceValue = int.Parse(Console.ReadLine());
            int currentBarrel = barrelSize;
            int bulletsFired = 0;
            while (bullets.Count>0 && locks.Count >0)
            {
                
                if (bullets.Count<currentBarrel)
                {
                    currentBarrel = bullets.Count;
                }
                for (int i = 0; i < currentBarrel; i++)
                {
                    if (bullets.Pop()<=locks.Peek())
                    {
                        Console.WriteLine("Bang!");
                        locks.Dequeue();
                        bulletsFired++;
                    }
                    else
                    {
                        Console.WriteLine("Ping!");
                        bulletsFired++;
                    }
                }
                if (bullets.Count>0)
                {
                    Console.WriteLine("Reloading!");
                }
               
            }
            if (locks.Count==0)
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${intelligenceValue - (bulletsFired*bulletPrice)}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
        }
    }
}
