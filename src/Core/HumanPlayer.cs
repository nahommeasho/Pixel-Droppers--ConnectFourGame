using System;

namespace ConnectFourGame.Core
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(string name, char token) : base(name, token) { }

        public override int ChooseColumn(Board board)
        {
            int column;
            Console.Write($"{Name}, choose a column (0-6): ");
            while (!int.TryParse(Console.ReadLine(), out column) || column < 0 || column >= 7)
            {
                Console.Write("Invalid input. Please choose a column between 0 and 6: ");
            }
            return column;
        }
    }
}
