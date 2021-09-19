using System;
using System.Collections.Generic;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < linesCount; i++)
            {
                string[] clothesInfo = Console.ReadLine().Split(new string[] { ",", " -> " }, StringSplitOptions.RemoveEmptyEntries);
                string color = clothesInfo[0];
                if (wardrobe.ContainsKey(color) == false)
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }
                for (int item = 1; item < clothesInfo.Length; item++)
                {
                    if (wardrobe[color].ContainsKey(clothesInfo[item]))
                    {
                        wardrobe[color][clothesInfo[item]]++;
                    }
                    else
                    {
                        wardrobe[color].Add(clothesInfo[item],1);
                    }
                }
            }

            string[] searchInfo = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            string colorWanted = searchInfo[0];
            string clothingWanted = searchInfo[1];

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var clothing in color.Value)
                {
                    if (color.Key==colorWanted && clothing.Key == clothingWanted)
                    {
                        Console.WriteLine($"* {clothing.Key} - {clothing.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothing.Key} - {clothing.Value}");
                    }
                }
            }
        }
    }
}
