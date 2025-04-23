using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Game
{
    internal class Board
    {
        private char[,] grid = new char[3, 3];
        private int Empty_Cells; // Counter for empty cells
        public Board()
        {
            Empty_Cells = 9;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    grid[i, j] = ' ';
                }
            }
        }

        // Method to display ( draw ) the current game board
        public void DrawTheCurrentGameBoard()
        {
            Console.WriteLine("-------------");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("| ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{grid[i, j]} | ");
                }
                Console.WriteLine();
                Console.WriteLine("-------------");
            }
        }

        // Method to check if a move is valid
        public bool isValidMove(int row, int col)
        {
            return (row >= 0 && row < 3 && col >= 0 && col < 3 && grid[row, col] == ' ');
        }

        // Method to make a move
        public void makeMove(int row, int col, char symbol)
        {
            if (isValidMove(row, col))
            {
                grid[row, col] = symbol;
                Empty_Cells--; // Increment counter when a cell is filled
            }
        }

        // Method to check for a win
        public bool CheckWin(char symbol)
        {
            // Check rows
            for (int i = 0; i < 3; i++)
            {
                if (grid[i, 0] == symbol && grid[i, 1] == symbol && grid[i, 2] == symbol)
                {
                    return true;
                }
            }

            // Check columns
            for (int i = 0; i < 3; i++)
            {
                if (grid[0, i] == symbol && grid[1, i] == symbol && grid[2, i] == symbol)
                {
                    return true;
                }
            }

            // Check diagonals
            if (grid[0, 0] == symbol && grid[1, 1] == symbol && grid[2, 2] == symbol)
            {
                return true;
            }
            if (grid[0, 2] == symbol && grid[1, 1] == symbol && grid[2, 0] == symbol)
            {
                return true;
            }

            // No player has won yet.
            return false;
        }

        // Method to check if board is full using the counter( Empty_Cells )
        public bool isFull()
        {
            return (Empty_Cells == 0);
        }

        // Method to get the number of empty cells
        public int getEmptyCellsCount() 
        {
        return Empty_Cells;
        }

}
}
