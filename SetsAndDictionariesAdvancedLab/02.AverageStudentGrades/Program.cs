using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < studentsCount; i++)
            {
                string[] studentGradePair = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string name = studentGradePair[0];
                decimal grade = decimal.Parse(studentGradePair[1]);
                if (students.ContainsKey(name)==false)
                {
                    students.Add(name, new List<decimal>());
                }
                students[name].Add(grade);
            }
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key} -> {string.Join(" ",student.Value.Select(x => $"{x :f2}"))} (avg: {student.Value.Average() :f2})");
            }
        }
    }
}
