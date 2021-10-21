using System;
using System.Collections.Generic;
using System.Linq;

namespace _16.Selling
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] bakery = new char[size, size];
            (int row, int col) playerPos = (-1, -1);
            int money = 0;
            List<(int row, int col)> pillars = new List<(int row, int col)>();

            for (int row = 0; row < size; row++)
            {
                List<char> line = new List<char>(Console.ReadLine());
                for (int col = 0; col < size; col++)
                {
                    if (line[col] == 'S')
                    {
                        playerPos = (row,col);
                        line[col] = '-';
                    }
                    else if (line[col] == 'O')
                    {
                        pillars.Add((row,col));
                    }
                    bakery[row, col] = line[col];
                }
            }

            while (money <50 && ValidateCoords(playerPos,bakery) == true)
            {
                string direction = Console.ReadLine();

                if (Move(direction, ref playerPos, ref bakery))
                {
                    if (char.IsDigit(bakery[playerPos.row, playerPos.col]))
                    {
                        money += (int)char.GetNumericValue(bakery[playerPos.row, playerPos.col]);
                        bakery[playerPos.row, playerPos.col] = '-';
                    }
                    else if (bakery[playerPos.row, playerPos.col] == 'O')
                    {
                        playerPos = pillars.Find(x=>x.row!= playerPos.row && x.col != playerPos.col);
                        foreach (var coords in pillars)
                        {
                            bakery[coords.row, coords.col] = '-';
                        }
                    }

                }
                
            }
            if (ValidateCoords(playerPos,bakery) == true)
            {
                Console.WriteLine("Good news! You succeeded in collecting enough money!");
                bakery[playerPos.row, playerPos.col] = 'S';
            }
            else
            {
                Console.WriteLine("Bad news, you are out of the bakery.");
            }
            Console.WriteLine($"Money: {money}");
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(bakery[row,col]);
                }
                Console.WriteLine();
            }

        }

        private static bool Move(string direction, ref (int row, int col) playerPos, ref char[,] bakery)
        {
            switch (direction)
            {

                case "left":
                    playerPos.col--;
                    break;
                case "right":
                    playerPos.col++;
                    break;
                case "up":
                    playerPos.row--;
                    break;
                case "down":
                    playerPos.row++;
                    break;
                default:
                    break;
            }
            return ValidateCoords(playerPos, bakery);
        }

        public static bool ValidateCoords((int row, int col) tuple,char [,] bakery)
        {
            if (tuple.row >= 0 && tuple.row < bakery.GetLength(0) && tuple.col >= 0 && tuple.col < bakery.GetLength(1))
            {
                return true;
            }
            return false;
        }
    }
}
