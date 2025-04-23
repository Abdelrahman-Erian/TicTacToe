using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Game
{
    internal class TicTacToe
    {
        private Board board;
        private Player[] players = new Player[2];
        private int currentPlayerIndex;
        public TicTacToe( string First_Player , string Second_Player )
        {
            board = new Board();
            currentPlayerIndex = 0;
            players[0] = new Player('X', First_Player);
            players[1] = new Player('O', Second_Player);
        }

        // Method to get the current player
        public Player getCurrentPlayer()
        {
            return players[currentPlayerIndex];
        }

        // Method to switch players
        public void SwitchTurn()
        {
            currentPlayerIndex = (currentPlayerIndex + 1) % 2;
        }

        // Method to play the game
        public void play()
        {
            int row, col;
            Console.WriteLine("Welcome to Tic-Tac-Toe!" );
            Console.WriteLine();

            while (!board.isFull())
            {
                // Display the board
                board.DrawTheCurrentGameBoard();

                Player currentPlayer = getCurrentPlayer();

                // Get valid input

                while (true)
                {
                    Console.WriteLine($"{currentPlayer.getName()} ( {currentPlayer.getSymbol()} )");
                    Console.Write("Enter row (1 - 3): ");
                    string _row = Console.ReadLine();
                    Console.Write("Enter column (1 - 3): ");
                    string _col = Console.ReadLine();
                    bool validRow = int.TryParse(_row, out row);
                    bool validCol = int.TryParse(_col, out col);

                    // Convert to 0-indexed
                    if (validRow) row--;
                    if (validCol) col--;

                    // Verify the validity of the entry
                    if (!validRow || !validCol || !board.isValidMove(row, col))
                    {
                        Console.WriteLine("Invalid move. Try again.");                        
                    }
                    else
                    {
                        break;
                    }
                }



                // Make move
                board.makeMove(row, col, currentPlayer.getSymbol());


                // Check for win
                if (board.CheckWin(currentPlayer.getSymbol()))
                {
                    board.DrawTheCurrentGameBoard();
                    Console.WriteLine($"{currentPlayer.getName()} wins!");
                    return;
                }

                // Switch turns
                SwitchTurn();
            }

            // Game ended in a draw
            board.DrawTheCurrentGameBoard();
            Console.WriteLine("It's a draw!");
        }
    }
}
