using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CustomComparator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Array.Sort(numbers, new MyComparer());
            Console.WriteLine(string.Join(" ",numbers));

                
        }
    }
    class MyComparer : IComparer<int>
    {
        public  int Compare(int x,int y)
        {
            if (x %2 ==0 && y %2 != 0)
            {
                return -1;
            }
            else if (x % 2 != 0 && y%2 ==0)
            {
                return 1;
            }
            else
            {
                return x.CompareTo(y);
            }
            
        }
    }
}
