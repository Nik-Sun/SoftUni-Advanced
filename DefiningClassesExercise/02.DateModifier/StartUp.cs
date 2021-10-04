using System;

namespace _02.DateModifier
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();
            DateModifier diff = new DateModifier();
            diff.GetDaysBetween(firstDate, secondDate);
        }
    }
}
