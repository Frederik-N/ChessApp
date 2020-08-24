using System.Numerics;

namespace MainLibrary
{
    public class Game
    {
        public BoardNotation Board { get; private set; }

        public Game(BoardNotation board)
        {
            Board = board;
        } 

        public BoardNotation GetBoard()
        {
            return Board;
        }
    }
}
