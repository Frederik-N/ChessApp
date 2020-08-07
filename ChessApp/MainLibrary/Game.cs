using System;
using System.Numerics;

namespace MainLibrary
{
    public class Game
    {
        public Board Board { get; private set; }

        public Game(Board board)
        {
            Board = board;
        } 

        public Board GetBoard()
        {
            return Board;
        }
    }

    public class Board
    {
        public String[,] Boardcoordinates { get; private set; }

        public Board()
        {
            Boardcoordinates = MakeBoard();
        }

        private String[,] MakeBoard()
        {
            String[,] initialboard = new String[8, 8];

            for (int i = 0; i<8; i++)
            {
                for (int j = 0; j<8; j++)
                {
                    initialboard[i, j] = ((char) (i+97)).ToString()+(j+1).ToString().Replace("-","");
                }
            }

            return initialboard;
        }

        public String[,] GetCoordinates()
        {
            return Boardcoordinates;
        }
    }
}
