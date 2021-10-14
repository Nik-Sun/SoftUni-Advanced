using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Revolt
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int commandsCount = int.Parse(Console.ReadLine());
            char[,] field = new char[size,size];
            (int row, int col) playerPos = (-1,-1);
            bool hasWon = false;

            for (int row  = 0; row < size; row++)
            {
                List<char> line = Console.ReadLine().ToList();
                if (line.Contains('f'))
                {
                    playerPos = (row, line.FindIndex(c => c == 'f'));
                }
                for (int col = 0; col < size; col++)
                {
                    field[row, col] = line[col];
                }
            }

            field[playerPos.row, playerPos.col] = '-';

            for (int command = 0; command < commandsCount; command++)
            {
                string direction = Console.ReadLine();
                Move(direction);

                if (field[playerPos.row, playerPos.col] == 'B')
                {
                    Move(direction);
                }
                else if (field[playerPos.row,playerPos.col] == 'T')
                {
                    MoveBackwards(direction);
                }
                else if (field[playerPos.row,playerPos.col] == 'F')
                {
                    hasWon = true;
                    break;
                }

            }
            field[playerPos.row, playerPos.col] = 'f'; 
            Console.WriteLine(hasWon ? "Player won!" : "Player lost!");
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(field[row,col]);
                }
                Console.WriteLine();
            }


            void Move(string direction)
            {
                switch (direction)
                {
                    case "up":
                        playerPos.row--;
                        if (playerPos.row < 0)
                        {
                            playerPos.row = size - 1;
                        }
                        break;
                    case "down":
                        playerPos.row++;
                        if (playerPos.row == size)
                        {
                            playerPos.row = 0;
                        }
                        break;
                    case "left":
                        playerPos.col--;
                        if (playerPos.col < 0)
                        {
                            playerPos.col = size - 1;
                        }
                        break;
                    case "right":
                        playerPos.col++;
                        if (playerPos.col == size)
                        {
                            playerPos.col = 0;
                        }
                        break;
                    default:
                        break;
                }
            }
            void MoveBackwards(string direction)
            {
                switch (direction)
                {
                    case "up":
                        playerPos.row++;
                        if (playerPos.row == size)
                        {
                            playerPos.row = 0;
                        }
                        break;
                    case "down":
                        playerPos.row--;
                        if (playerPos.row < 0)
                        {
                            playerPos.row = size - 1;
                        }
                       
                        break;
                    case "left":
                        playerPos.col++;
                        if (playerPos.col == size)
                        {
                            playerPos.col = 0;
                        }
                       
                        break;
                    case "right":
                        playerPos.col--;
                        if (playerPos.col < 0)
                        {
                            playerPos.col = size - 1;
                        }
                        break;
                    default:
                        break;
                }
            }

        }
        

    }
}
