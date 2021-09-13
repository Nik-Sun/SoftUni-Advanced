using System;

namespace _04.SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];

            for (int r = 0; r < size; r++)
            {
                char[] row = Console.ReadLine().ToCharArray();
                for (int c = 0; c < size; c++)
                {
                    matrix[r, c] = row[c];
                }
            }
            string symbol = Console.ReadLine();
            bool isSymbolFound = false;
            int[] coordinates = new int[2];
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (matrix[row,col].ToString() == symbol)
                    {
                        coordinates[0] = row;
                        coordinates[1] = col;
                        isSymbolFound = true;
                        break;
                    }
                }
                if (isSymbolFound)
                {
                    break;
                }
            }
            if (isSymbolFound)
            {
                Console.WriteLine($"({string.Join(", ",coordinates)})");
            }
            else
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}
