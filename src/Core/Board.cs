// Board class implementation 
using System;

namespace ConnectFourGame.Core
{
    public class Board
    {
        private const int Rows = 6;
        private const int Cols = 7;
        private char[,] grid = new char[Rows, Cols];

        public Board()
        {
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Cols; j++)
                    grid[i, j] = '.';
        }

        public void DisplayBoard()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    Console.Write(grid[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
