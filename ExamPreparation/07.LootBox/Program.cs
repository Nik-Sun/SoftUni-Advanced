using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.LootBox
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> firstBox = new Queue<int>(Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));
            Stack<int> secondBox = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));
            int itemsSum = 0;

            while (firstBox.Count >0 && secondBox.Count >0)
            {
                int item = firstBox.Peek() + secondBox.Peek();
                if (item % 2 == 0)
                {
                    itemsSum += firstBox.Dequeue() + secondBox.Pop();
                }
                else
                {
                    firstBox.Enqueue(secondBox.Pop());
                }
            }

            Console.WriteLine(firstBox.Count > secondBox.Count  ? "Second lootbox is empty" : "First lootbox is empty");
            Console.WriteLine(itemsSum >= 100 ? $"Your loot was epic! Value: {itemsSum}" : $"Your loot was poor... Value: {itemsSum}");
        }
    }
}
