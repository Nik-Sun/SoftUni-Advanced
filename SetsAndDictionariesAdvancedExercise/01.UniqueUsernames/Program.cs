using System;
using System.Collections.Generic;

namespace _01.UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());
            HashSet<string> uniqueUsers = new HashSet<string>();

            for (int i = 0; i < linesCount; i++)
            {
                string name = Console.ReadLine();
                uniqueUsers.Add(name);
            }

            foreach (var name in uniqueUsers)
            {
                Console.WriteLine(name);
            }
        }
    }
}
