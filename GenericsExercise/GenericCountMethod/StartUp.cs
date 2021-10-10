using System;
using System.Collections.Generic;

namespace GenericCountMethod
{
    class Startup
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Box<double>> boxes = new List<Box<double>>();
            for (int i = 0; i < count; i++)
            {
                Box<double> newBox = new Box<double>(double.Parse(Console.ReadLine()));
                boxes.Add(newBox);
            }
            double compareTo = double.Parse(Console.ReadLine());
            Console.WriteLine(CompareTo(boxes,compareTo));
        }
        public static int CompareTo<T>(List<Box<T>> list, T compareTo)
            where T : IComparable
        {
            int count = 0;
            foreach (var item in list)
            {
                if (item.Value.CompareTo(compareTo)>0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
