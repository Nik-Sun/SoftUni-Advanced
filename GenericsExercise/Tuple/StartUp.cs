using System;

namespace Tuple
{
    class StartUp
    {
        static void Main(string[] args)
        {

            string[] nameAndAdress = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
            var tuple1 = new TupleItem<string,string>(($"{nameAndAdress[0]} {nameAndAdress[1]}"),nameAndAdress[2]);
            string[] nameAndLiters = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var tuple2 = new TupleItem<string, int>(nameAndLiters[0], int.Parse(nameAndLiters[1]));
            string[] intAndDouble = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var tuple3 = new TupleItem<int, double>(int.Parse(intAndDouble[0]), double.Parse(intAndDouble[1]));
            Console.WriteLine(tuple1);
            Console.WriteLine(tuple2);
            Console.WriteLine(tuple3);


        }
    }
}
