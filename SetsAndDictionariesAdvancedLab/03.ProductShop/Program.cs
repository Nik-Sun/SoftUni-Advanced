using System;
using System.Collections.Generic;

namespace _03.ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, double>> shops = new SortedDictionary<string, Dictionary<string, double>>();
            string input = Console.ReadLine();
            while (input != "Revision")
            {
                string[] shopData = input.Split(", ",StringSplitOptions.RemoveEmptyEntries);

                string shop = shopData[0];
                string product = shopData[1];
                double price = double.Parse(shopData[2]);
                if (shops.ContainsKey(shop) == false)
                {
                    shops.Add(shop,new Dictionary<string, double>());
                }
                shops[shop].Add(product,price);

                input = Console.ReadLine();
            }
            foreach (var shop in shops)
            {
                Console.WriteLine($"{shop.Key}->");

                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
