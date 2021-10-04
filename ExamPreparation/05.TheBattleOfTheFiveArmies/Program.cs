using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.TheBattleOfTheFiveArmies
{
    class Program
    {
        static void Main(string[] args)
        {
            int armyArmor = int.Parse(Console.ReadLine());
            int battleSize = int.Parse(Console.ReadLine());
            char[][] battleField = new char[battleSize][];
            (int row, int col) armyIndex = (0, 0);
            for (int i = 0; i < battleSize; i++)
            {
                List<char> row = Console.ReadLine().ToList(); 
                if (row.Contains('A'))
                {
                    armyIndex = (i, row.FindIndex(ch => ch == 'A'));
                }
                battleField[i] = row.ToArray();
            }
            bool isMordorReached = false;
            while (true)
            {
                string[] commandData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string direction = commandData[0];
                int spawnRow = int.Parse(commandData[1]);
                int spawnCol = int.Parse(commandData[2]);
                battleField[spawnRow][spawnCol] = 'O';
                battleField[armyIndex.row][armyIndex.col] = '-';
                if (direction == "up")
                {
                    if (armyIndex.row - 1 >= 0)
                    {
                        armyIndex.row--;
                    }
                    
                }
                else if (direction == "down")
                {
                    if (armyIndex.row +1 < battleSize)
                    {
                        armyIndex.row++;
                    }
                    
                }
                else if (direction == "left")
                {
                    if (armyIndex.col -1 >=0)
                    {
                        armyIndex.col--;
                    }
                }
                else if (direction == "right")
                {
                    if (armyIndex.col +1 < battleField[armyIndex.row].Length)
                    {
                        armyIndex.col++;
                    }
                }
                armyArmor--;

                if (battleField[armyIndex.row][armyIndex.col] == 'O')
                {
                    armyArmor -= 2;
                    battleField[armyIndex.row][armyIndex.col] = '-';
                   
                }
                else if (battleField[armyIndex.row][armyIndex.col] == 'M')
                {
                    battleField[armyIndex.row][armyIndex.col] = '-';
                    isMordorReached = true;
                    break;
                }
                if (armyArmor <= 0)
                {
                    battleField[armyIndex.row][armyIndex.col] = 'X';
                    break;
                }
            }

            Console.WriteLine(isMordorReached ? $"The army managed to free the Middle World! Armor left: {armyArmor}" : $"The army was defeated at {armyIndex.row};{armyIndex.col}.");
            foreach (var line in battleField)
            {
                Console.WriteLine(string.Join("", line));
            }
        }
    }
}
