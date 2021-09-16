using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] board = new char[size, size];
            int[] atkCoords = new int[] { 2, 1, 2, -1, -2, 1, -2, -1, 1, -2, 1, 2, -1, -2, -1, 2 };// All Possible moves

            for (int r = 0; r < size; r++)
            {
                string row = Console.ReadLine().ToUpper();
                for (int c = 0; c < size; c++)
                {
                    board[r, c] = row[c];
                }
            }
            int piecesRemoved = 0;
            int piecesThreatened = 0;
            int maxPiecesThreatened = int.MinValue;
            int[] knightToRemove = new int[2];
            bool isClear = false;
            while (!isClear)
            {
                for (int r = 0; r < size; r++)
                {
                    for (int c = 0; c < size; c++)
                    {
                        if (board[r, c] == 'K')
                        {
                            piecesThreatened = 0;
                            for (int i = 0; i < 16; i += 2)
                            {

                                int atkRow = atkCoords[i] + r;
                                int atkCol = atkCoords[i + 1] + c;

                                if (atkRow >= 0 && atkRow < size && atkCol >= 0 && atkCol < size)
                                {
                                    if (board[atkRow, atkCol] == 'K')
                                    {
                                        piecesThreatened++;
                                    }
                                }
                            }
                            if (piecesThreatened > maxPiecesThreatened)
                            {
                                maxPiecesThreatened = piecesThreatened;
                                knightToRemove[0] = r;
                                knightToRemove[1] = c;
                            }
                        }
                    }
                }
                if (maxPiecesThreatened == 0)
                {
                    isClear = true;
                }
                else
                {
                    board[knightToRemove[0], knightToRemove[1]] = '0';
                    piecesRemoved++;
                    maxPiecesThreatened = 0;
                }
            }
            
            
            Console.WriteLine(piecesRemoved);

        }
    }
}
