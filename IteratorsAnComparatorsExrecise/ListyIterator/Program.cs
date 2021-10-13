using System;
using System.Collections.Generic;
using System.Linq;

namespace ListyIterator
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<string> create  = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList();
            create.Remove("Create");

            var iterator = new GenericLystyIterator<string>(create.ToArray());
            string input = Console.ReadLine();
            while (input != "END")
            {
                switch (input)
                {
                    case "HasNext":
                        Console.WriteLine(iterator.HasNext()); 
                        break;
                    case "Print":
                        iterator.Print();
                        break;
                    case "Move":
                        Console.WriteLine(iterator.Move()); 
                        break;
                    case "PrintAll":
                        iterator.PrintAll();
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine();
            }

            
        }
    }
}
