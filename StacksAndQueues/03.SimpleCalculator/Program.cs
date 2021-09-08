using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Stack<string> calcStack = new Stack<string>(input.Reverse());

            while (calcStack.Count>1)
            {
                int lastNum = int.Parse(calcStack.Pop());
                string sign = calcStack.Pop();
                int nextNum = int.Parse(calcStack.Pop());
                if (sign == "+")
                {
                    calcStack.Push((lastNum+nextNum).ToString());
                }
                else
                {
                    calcStack.Push((lastNum - nextNum).ToString());
                }
            }
            Console.WriteLine(calcStack.Pop());
        }
    }
}
