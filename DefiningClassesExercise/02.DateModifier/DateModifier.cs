
using System;

namespace _02.DateModifier
{
    class DateModifier
    {
        private int daysBetween;

        public void GetDaysBetween(string dateFrom,string dateTo)
        {
            DateTime  from =DateTime.Parse(dateFrom);
            DateTime  to =DateTime.Parse(dateTo);
            TimeSpan days = to-from;
            daysBetween = Math.Abs(days.Days);
            Console.WriteLine(daysBetween);
        }
    }
}
