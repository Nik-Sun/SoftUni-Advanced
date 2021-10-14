using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.WarmWinter
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> hats = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));
            Queue<int> scarfs = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));
            List<int> sets = new List<int>();

            while (hats.Count>0 && scarfs.Count >0)
            {
                if (hats.Peek() > scarfs.Peek())
                {
                    sets.Add(hats.Pop() + scarfs.Dequeue());
                }
                else if (hats.Peek() < scarfs.Peek())
                {
                    hats.Pop();
                }
                else if (hats.Peek() == scarfs.Peek())
                {
                    scarfs.Dequeue();
                    hats.Push(hats.Pop() + 1);
                }
            }
            Console.WriteLine($"The most expensive set is: {sets.Max()}");
            Console.WriteLine(string.Join(" ",sets));
        }
    }
}
