using System;
using ConnectFourGame.src.Core;

namespace ConnectFourGame
{
    public class Game
    {
        private Board board;
        private Player player1;
        private Player player2;
        private Player currentPlayer;

        public Game()
        {
            board = new Board();
            player1 = new HumanPlayer('X');
            player2 = new AIPlayer('O');
            currentPlayer = player1;
        }

        public void Start()
        {
            Console.WriteLine("Welcome to Connect Four!");
            board.Render();

            while (!board.IsFull())
            {
                Console.WriteLine($"Player {currentPlayer.Token}'s turn");
                int column = currentPlayer.GetMove(board);

                if (board.DropToken(column, currentPlayer.Token))
                {
                    board.Render();

                    if (board.CheckWin(currentPlayer.Token))
                    {
                        Console.WriteLine($"Player {currentPlayer.Token} wins!");
                        return;
                    }

                    currentPlayer = (currentPlayer == player1) ? player2 : player1;
                }
                else
                {
                    Console.WriteLine("Invalid move. Try again.");
                }
            }

            Console.WriteLine("It's a draw!");
        }
    }
}
