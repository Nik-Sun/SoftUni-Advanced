using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            Func<string,int,bool> findSum = (str,num)  =>
            {
                int sum = 0;
                
                for (int i = 0; i < str.Length; i++)
                {
                    sum += str[i];
                }
                if (sum > num)
                {
                    return true;
                }
                return false;
            };

            Func<List<string>, string> returnName = (lst) =>
             {
                 foreach (var item in lst)
                 {
                     if (findSum(item, number))
                     {
                         return item;
                     }
                 }
                 return string.Empty;
             };
            Console.WriteLine(returnName(names));
          
        }
       


    }
}
