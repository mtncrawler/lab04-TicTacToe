﻿using Lab04_TicTacToe.Classes;
using System;


namespace Lab04_TicTacToe
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Let's Play Tic Tac Toe!");
            
		}

		static void PlayGame()
		{
            
            // TODO: Instantiate your players
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
            //Game game = new Game(player1, player2);


            // Play the Game
            // Output the winner





        }
    }
}
