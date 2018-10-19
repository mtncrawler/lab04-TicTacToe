using System;
using Xunit;
using Lab04_TicTacToe.Classes;

namespace TicTacToeTest
{
    public class UnitTest1
    {
        [Fact]
        public void WinnerWinnerChickenDinner()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);
            Board board = new Board();

            board.GameBoard = new string[,]
            {
            {"1", "X", "3"},
            {"4", "X", "6"},
            {"7", "X", "9"},
            };

            Assert.True(game.CheckForWinner(game.Board));
        }
    }
}
