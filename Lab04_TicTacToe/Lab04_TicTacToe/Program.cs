using Lab04_TicTacToe.Classes;
using System;


namespace Lab04_TicTacToe
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Let's Play Tic Tac Toe!");
            PlayGame();
		}

		static void PlayGame()
		{
            
            // DONE: Instantiate your players
            Console.WriteLine("Player 1, enter your name: ");
            string player1Name = Console.ReadLine();

            Player player1 = new Player
            {
                Name = player1Name,
                Marker = "X",
                IsTurn = true
            };

            Console.WriteLine("Opponent, enter your name: ");
            string player2Name = Console.ReadLine();

            Player player2 = new Player
            {
                Name = player2Name,
                Marker = "O",
                IsTurn = true
            };

            // Create the Game
            Game game = new Game(player1, player2);

            // Play the Game
            Player winner = game.Play();

            // Output the winner
            if (winner != null)
            {
                Console.WriteLine($"{winner.Name}, you are the winner!");
            } else
            {
                Console.WriteLine("It's a draw!");
            }

        }
    }
}
