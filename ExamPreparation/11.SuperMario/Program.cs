using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.SuperMario
{
    class Program
    {
        static void Main(string[] args)
        {
            int lives = int.Parse(Console.ReadLine());
            int towerRows = int.Parse(Console.ReadLine());
            char[][] tower = new char[towerRows][];
            (int row, int col) marioPos = (-1, -1);
            for (int row = 0; row < towerRows; row++)
            {
                List<char> line = Console.ReadLine().ToList();
                if (line.Contains('M'))
                {
                    marioPos = (row, line.FindIndex(m => m == 'M'));
                }
                tower[row] = line.ToArray(); 
            }
            tower[marioPos.row][marioPos.col] = '-';
            bool isPrincessSaved = false;
            while (true)
            {
                string[] turnInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                
                string direction = turnInfo[0];
                int spawnRow = int.Parse(turnInfo[1]);
                int spawnCol = int.Parse(turnInfo[2]);
                tower[spawnRow][spawnCol] = 'B';

                Move(direction);

                if (tower[marioPos.row][marioPos.col] == 'B')
                {
                    lives -= 2;
                    tower[marioPos.row][marioPos.col] = '-';
                }
                else if (tower[marioPos.row][marioPos.col] == 'P')
                {
                    tower[marioPos.row][marioPos.col] = '-';
                    isPrincessSaved = true;
                    break;
                }
                if (lives <=0)
                {
                    tower[marioPos.row][marioPos.col] = 'X';
                    break;
                }
                
               
                
            }
            if (isPrincessSaved)
            {
                Console.WriteLine($"Mario has successfully saved the princess! Lives left: {lives}");
            }
            else
            {
                Console.WriteLine($"Mario died at { marioPos.row};{ marioPos.col}.");
                
            }

            foreach (var floor in tower)
            {
                Console.WriteLine(string.Join("",floor));
            }


            void Move(string direction)
            {
                lives--;
                tower[marioPos.row][marioPos.col] = '-';
                switch (direction)
                {
                    case "W": //Up
                        marioPos.row--;
                        if (marioPos.row < 0)
                        {
                            marioPos.row = 0;
                        }
                        break;
                    case "S": //Down
                        marioPos.row++;
                        if (marioPos.row == towerRows)
                        {
                            marioPos.row = towerRows - 1;
                        }
                        break;
                    case "A": //Left
                        marioPos.col--;
                        if (marioPos.col < 0)
                        {
                            marioPos.col = 0;
                        }
                        break;
                    case "D": //Right
                        marioPos.col++;
                        if (marioPos.col == tower[marioPos.row].Length)
                        {
                            marioPos.col = tower[marioPos.row].Length - 1;
                        }
                        break;
                    default:
                        break;
                }
                tower[marioPos.row][marioPos.col] = 'M';
            }
        }
    }
}
