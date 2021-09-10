using System;
using System.Collections.Generic;

namespace _16.BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> openingBrackets = new Stack<char>();
           
            bool isBalanced = true;
            if (input.Length % 2 != 0)
            {
                isBalanced = false;
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == '(' || input[i] =='{' || input[i] == '[')
                    {
                        openingBrackets.Push(input[i]);
                    }
                    else if(openingBrackets.Count>0)
                    {
                        string balance = $"{openingBrackets.Pop()}{input[i]}";
                        if (balance != "{}" && balance != "[]" && balance !="()")
                        {
                            isBalanced = false;
                            break;
                        }
                    }
                    else
                    {
                        isBalanced = false;
                        break;
                    }
                }

            }
            if (isBalanced)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }


        }
    }
}
