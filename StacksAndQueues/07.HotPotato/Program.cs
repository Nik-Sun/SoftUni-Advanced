using System;
using System.Collections.Generic;

namespace _07.HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kids = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            int tossCount = int.Parse(Console.ReadLine());
            Queue<string> game = new Queue<string>(kids);

            while (game.Count>1)
            {
                for (int i = 0; i < tossCount-1; i++)
                {
                    game.Enqueue(game.Dequeue());
                }
                Console.WriteLine($"Removed {game.Dequeue()}");
            }
            Console.WriteLine($"Last is {game.Dequeue()}");
        }
    }
}
