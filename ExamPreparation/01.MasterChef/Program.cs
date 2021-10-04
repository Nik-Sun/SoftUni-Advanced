using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.MasterChef
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> ingredients = new Queue<int>(Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(i => i != 0));
            Stack<int> freshness = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));
            Dictionary<string, int> dishesMade = new Dictionary<string, int>();
            Dictionary<int, string> scoringTable = new Dictionary<int, string>();
            scoringTable.Add(150,"Dipping sauce");
            scoringTable.Add(250,"Green salad");
            scoringTable.Add(300, "Chocolate cake");
            scoringTable.Add(400, "Lobster");

            while (ingredients.Count >0 && freshness.Count>0)
            {
                int dish = ingredients.Peek() * freshness.Peek();
                if (scoringTable.ContainsKey(dish))
                {
                    ingredients.Dequeue();
                    freshness.Pop();
                    if (dishesMade.ContainsKey(scoringTable[dish]) == false)
                    {
                        dishesMade.Add(scoringTable[dish], 1);
                    }
                    else
                    {
                        dishesMade[scoringTable[dish]]++;
                    }
                }
                else
                {
                    freshness.Pop();
                    ingredients.Enqueue(ingredients.Dequeue() + 5);
                }
            }

            if (dishesMade.Count<4)
            {
                Console.WriteLine("You were voted off. Better luck next year.");
                if (ingredients.Count> 0)
                {
                    Console.WriteLine($"Ingredients left: {ingredients.Sum()}");
                }
            }
            else
            {
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");
            }
            foreach (var dish in dishesMade.OrderBy(d => d.Key))
            {
                Console.WriteLine($" # {dish.Key} --> {dish.Value}");
            }
        }
    }
}
