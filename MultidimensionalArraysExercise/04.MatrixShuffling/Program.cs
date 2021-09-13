using System;
using System.Linq;

namespace _04.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[][] matrix = new string[sizes[0]][];
            for (int i = 0; i < sizes[0]; i++)
            {
                string[] row = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                matrix[i] = row;
            }
            string input = Console.ReadLine();

            while (input.ToUpper() != "END")
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (command.Length == 5 && command[0]== "swap")
                {
                    int row1 = int.Parse(command[1]);
                    int col1 = int.Parse(command[2]);
                    int row2 = int.Parse(command[3]);
                    int col2 = int.Parse(command[4]);
                    if (row1<0||row1>=sizes[0]||col1<0||col1>=sizes[1]||row2<0||row2>=sizes[0]||col2<0||col2>=sizes[1])
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                        string tempA = matrix[row1][col1];
                        string tempB = matrix[row2][col2];
                        matrix[row1][col1] = tempB;
                        matrix[row2][col2] = tempA;
                        foreach (string[] item in matrix)
                        {
                            Console.WriteLine(string.Join(" ",item));
                        }

                    }

                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                input = Console.ReadLine();
            }

        }

       
    }
}
