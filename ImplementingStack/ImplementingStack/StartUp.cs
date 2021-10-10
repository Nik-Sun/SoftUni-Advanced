using System;
using System.Collections.Generic;

namespace ImplementingStack
{
    class StartUp
    {
        static void Main(string[] args)
        {
            CustomStack<int> stack = new CustomStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            Console.WriteLine(stack.Count);
            stack.Pop();
            stack.ForEach(x => Console.Write(x + " "));
            int a = stack.Peek();
            Console.WriteLine();
            Console.WriteLine(a);
            Console.WriteLine("----------");
            


            Stack<int> newStack = new Stack<int>();
            newStack.Push(1);
            newStack.Push(2);
            newStack.Push(3);
            newStack.Push(4);
            newStack.Push(5);
            newStack.Push(6);
            Console.WriteLine(newStack.Count);
            newStack.Pop();
            int b = stack.Peek();
            Console.WriteLine(string.Join(" ",newStack));
            Console.WriteLine(b);
        }
    }
}
