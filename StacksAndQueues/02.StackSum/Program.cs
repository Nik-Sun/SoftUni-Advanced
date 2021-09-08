using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> numbers = new Stack<int>(input);
            string command = Console.ReadLine().ToUpper();
            while (command != "END")
            {
                string[] commandData = command.Split();
                if (commandData[0] == "ADD")
                {
                    numbers.Push(int.Parse(commandData[1]));
                    numbers.Push(int.Parse(commandData[2]));
                }
                else
                {
                    int count = int.Parse(commandData[1]);
                    if (count < numbers.Count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            numbers.Pop();
                        }
                    }
                    
                }

                command = Console.ReadLine().ToUpper();
            }
            Console.WriteLine($"Sum: {numbers.Sum()}");
        }
    }
}
