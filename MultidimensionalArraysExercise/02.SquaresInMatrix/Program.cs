using System;
using System.Linq;

namespace _02.SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[,] matrix = new string[sizes[0], sizes[1]];

            for (int r = 0; r < sizes[0]; r++)
            {
                string[] row = Console.ReadLine().Split();

                for (int c = 0; c < sizes[1]; c++)
                {
                    matrix[r, c] = row[c];
                }
            }
            int equalCellsCount = 0;

            for (int r = 0; r < sizes[0]-1; r++)
            {
                for (int c = 0; c < sizes[1]-1; c++)
                {
                    if (matrix[r,c] == matrix[r+1,c]&&matrix[r,c]==matrix[r,c+1]&&matrix[r,c]==matrix[r+1,c+1])
                    {
                        equalCellsCount++;
                    }
                }
            }
            Console.WriteLine(equalCellsCount);
        }
    }
}
