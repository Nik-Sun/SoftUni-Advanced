using System;
using System.Collections.Generic;

namespace _01.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            Stack<char> charStack = new Stack<char>(input);
            while (charStack.Count>0)
            {
                Console.Write(charStack.Pop());
            }
        }
    }
}
