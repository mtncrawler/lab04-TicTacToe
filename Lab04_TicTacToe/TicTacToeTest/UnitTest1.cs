using System;
using Xunit;
using Lab04_TicTacToe.Classes;

namespace TicTacToeTest
{
    public class UnitTest1
    {
        /// <summary>
        /// test for horizontal winner
        /// </summary>
        [Fact]
        public void HorizontalWinner()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);
            Board board = new Board();
            
            Position mark1 = new Position(0, 0);
            Position mark2 = new Position(0, 1);
            Position mark3 = new Position(0, 2);

            game.Board.GameBoard[mark1.Row, mark1.Column] = "X";
            game.Board.GameBoard[mark2.Row, mark2.Column] = "X";
            game.Board.GameBoard[mark3.Row, mark3.Column] = "X";

            Assert.True(game.CheckForWinner(game.Board));
        }

        /// <summary>
        /// test for vertical winner
        /// </summary>
        [Fact]
        public void VerticalWinner()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);
            Board board = new Board();

            Position mark1 = new Position(0, 0);
            Position mark2 = new Position(1, 0);
            Position mark3 = new Position(2, 0);

            game.Board.GameBoard[mark1.Row, mark1.Column] = "X";
            game.Board.GameBoard[mark2.Row, mark2.Column] = "X";
            game.Board.GameBoard[mark3.Row, mark3.Column] = "X";

            Assert.True(game.CheckForWinner(game.Board));
        }

        /// <summary>
        /// test for diagonal winner
        /// </summary>
        [Fact]
        public void DiagonalWinner()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);
            Board board = new Board();

            Position mark1 = new Position(0, 0);
            Position mark2 = new Position(1, 1);
            Position mark3 = new Position(2, 2);

            game.Board.GameBoard[mark1.Row, mark1.Column] = "X";
            game.Board.GameBoard[mark2.Row, mark2.Column] = "X";
            game.Board.GameBoard[mark3.Row, mark3.Column] = "X";

            Assert.True(game.CheckForWinner(game.Board));
        }

        /// <summary>
        /// test for player switch
        /// </summary>
       [Fact]
       public void PlayerSwitch()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);

            p1.IsTurn = true;
            game.SwitchPlayer();

            Assert.True(p2.IsTurn);
        }

        /// <summary>
        /// test for position correlation to array index
        /// </summary>
        [Fact]
        public void PositionCorrelatesToArrayIndex()
        {
            Player p1 = new Player();
            Player p2 = new Player();
            Game game = new Game(p1, p2);

            Position test = new Position(0, 0);
            Position coordinates = Player.PositionForNumber(1);

            Assert.True(test.Row == coordinates.Row && test.Column == coordinates.Column);
        }
        
    }
}
