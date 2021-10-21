using System;
using System.Collections.Generic;
using System.Linq;

namespace _15.Cooking
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> liquids = new Queue<int>(Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));
            Stack<int> ingredients = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));
            Dictionary<int, string> foodTable = new Dictionary<int, string>();
            foodTable.Add(25,"Bread");
            foodTable.Add(50,"Cake");
            foodTable.Add(75,"Pastry");
            foodTable.Add(100,"Fruit Pie");
            Dictionary<string, int> foods = new Dictionary<string, int>();
            foods.Add("Bread",0);
            foods.Add("Cake",0);
            foods.Add("Pastry",0);
            foods.Add("Fruit Pie",0);

            while (liquids.Count >0 && ingredients.Count >0)
            {
                int cookedDish = liquids.Dequeue() + ingredients.Peek();
                if (foodTable.ContainsKey(cookedDish))
                {
                    ingredients.Pop();
                    if (foods.ContainsKey(foodTable[cookedDish]))
                    {
                        foods[foodTable[cookedDish]]++;
                    }
                    else
                    {
                        foods.Add(foodTable[cookedDish], 1);
                    }
                  
                }
                else
                {
                    ingredients.Push(ingredients.Pop() + 3);
                }
            }

            if (foods.Values.All(x => { return x >= 1; }))
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!"); 
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything."); 
            }
            
            Console.WriteLine($"Liquids left: { (liquids.Count == 0 ? "none" : string.Join(", ",liquids)) }");
            Console.WriteLine($"Ingredients left: { (ingredients.Count == 0 ? "none" : string.Join(", ",ingredients)) }");

            foreach (var food in foods.OrderBy(f => f.Key))
            {
                Console.WriteLine($"{food.Key}: {food.Value}");
            }


        }
    }
}
