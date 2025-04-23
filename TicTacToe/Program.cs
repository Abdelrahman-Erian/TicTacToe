using System;

namespace TicTacToe_Game
{
    internal class Program
    {      
        static bool IsValidName(string name)
        {
            return !string.IsNullOrWhiteSpace(name) &&
                   name.Any(char.IsLetter) &&
                   name.Length <= 15;
        }
        static void Main()
        {
            Console.WriteLine("Note that the name has a maximum length of 15 characters.");
            Console.WriteLine("Symbol for first player : X");
            Console.WriteLine("Symbol for second player : O");
            string First_Player, Second_Player;

            // Read the first player's name with verification

            do
            {
                Console.Write("Enter the name of the first player: ");
                First_Player = Console.ReadLine();

                if (!IsValidName(First_Player))
                    Console.WriteLine("Invalid name. It must contain at least one character, not be empty, and not exceed 15 characters.");

            } while (!IsValidName(First_Player));

            // Read the second player's name with verification
            do
            {
                Console.Write("Enter the name of the second player: ");
                Second_Player = Console.ReadLine();

                if (!IsValidName(Second_Player))
                    Console.WriteLine("Invalid name. It must contain at least one character, not be empty, and not exceed 15 characters.");

            } while (!IsValidName(Second_Player));

            Console.WriteLine();

            TicTacToe game = new TicTacToe( First_Player , Second_Player );

            game.play(); 

        }
    }
}