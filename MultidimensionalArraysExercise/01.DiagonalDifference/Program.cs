using System;
using System.Linq;

namespace _01.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];

            for (int r = 0; r < size; r++)
            {
                int[] row = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                for (int c = 0; c < size; c++)
                {
                    matrix[r, c] = row[c];
                }
            }
            int primarySum = 0;
            int secondarySum = 0;
           
            for (int r = 0; r < size; r++)
            {
                primarySum += matrix[r, r];
                for (int i = (size - 1)-r; i >= (size-r) -1; i--)
                {
                    secondarySum += matrix[r, i];
                }
            }
            int difference = Math.Abs(primarySum - secondarySum);
            Console.WriteLine(difference);
        }
    }
}
