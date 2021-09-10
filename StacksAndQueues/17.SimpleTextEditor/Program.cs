using System;
using System.Collections.Generic;
using System.Text;

namespace _17.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int commandsCount = int.Parse(Console.ReadLine());
            StringBuilder text = new StringBuilder();
            Stack<StringBuilder> buffer = new Stack<StringBuilder>();
            for (int i = 0; i < commandsCount; i++)
            {
                string[] commandData = Console.ReadLine().Split();
                string command = commandData[0];
                switch (command)
                {
                    case"1":
                        buffer.Push(new StringBuilder(text.ToString()));
                        string substring = commandData[1];
                        text.Append(substring);
                      
                        break;
                    case "2":
                        buffer.Push(new StringBuilder(text.ToString()));
                        int length = int.Parse(commandData[1]);
                        text.Remove(text.Length-length,length);
                        
                        break;
                    case "3":
                        int index = int.Parse(commandData[1])-1;
                        Console.WriteLine(text[index]);
                        break;
                    case "4":
                        text = buffer.Pop();
                        break;
                }
                
                
            }
        }
    }
}
