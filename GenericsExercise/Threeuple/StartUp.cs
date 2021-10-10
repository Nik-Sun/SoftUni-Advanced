using System;
using System.Collections.Generic;

namespace Threeuple
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Queue<string> firstLine = new Queue<string>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries));
            string[] secondLine = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            Queue<string> thirdLine = new Queue<string>(Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries));

            var firstThreeuple = new Threeuple<string,string,string>($"{firstLine.Dequeue()} {firstLine.Dequeue()}",firstLine.Dequeue(),$"{string.Join(" ",firstLine)}");
            var secondThreeuple = new Threeuple<string, int, bool>(secondLine[0], int.Parse(secondLine[1]), secondLine[2] == "drunk");
            var thirdThreeuple = new Threeuple<string, double, string>(thirdLine.Dequeue(),double.Parse(thirdLine.Dequeue()),$"{string.Join(" ",thirdLine)}");

            Console.WriteLine(firstThreeuple);
            Console.WriteLine(secondThreeuple);
            Console.WriteLine(thirdThreeuple);
        }
    }
}
