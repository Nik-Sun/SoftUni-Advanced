using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int stackCount = data[0];
            int popCount = data[1];
            int numberToFind = data[2];
            Stack<int> stack = new Stack<int>();
            int[] numbersToPush = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < stackCount; i++)
            {
                stack.Push(numbersToPush[i]);
            }
            for (int i = 0; i < popCount; i++)
            {
                stack.Pop();
            }
            
            if (stack.Contains(numberToFind))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                int smallestNum = int.MaxValue; 
                while (stack.Count >0)
                {
                    if (smallestNum>stack.Peek())
                    {
                        smallestNum = stack.Pop();
                    }
                    else
                    {
                        stack.Pop();
                    }
                }
                Console.WriteLine(smallestNum);
            }
           
        }
    }
}
