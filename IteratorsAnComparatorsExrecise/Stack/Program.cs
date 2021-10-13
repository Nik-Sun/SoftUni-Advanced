using System;
using System.Collections.Generic;
using System.Linq;


namespace Stack
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(new string[] {" ",", "}, StringSplitOptions.RemoveEmptyEntries).ToList();
            var stack = new CustomStack<int>();
            while (input[0] != "END")
            {
                string command = input[0];
                input.Remove(command);
                if (command == "Push")
                {
                    stack.Push((input.Select(int.Parse).ToArray()));
                }
                else if (command == "Pop")
                {
                    try
                    {
                        stack.Pop();
                    }
                    catch (SystemException)
                    {

                        Console.WriteLine("No elements");
                    }
                }
                input = Console.ReadLine().Split(new string[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
