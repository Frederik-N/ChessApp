using System.Linq.Expressions;

namespace MainLibrary
{
    public class Pawn
    {

        public const char PAWN_SYMBOL = 'P';
        public const char SPACE = ' ';
        public static char[,] pawns;

        public Pawn()
        {
            pawns = new char[ChessBoard.DIMENSION, ChessBoard.DIMENSION];
            initializePawns();
        }

        private void initializePawns()
        {
            for (int r = 0; r < ChessBoard.DIMENSION; r++)
            {
                for (int c = 0; c < ChessBoard.DIMENSION; c++)
                {
                    if (r == 1 || r == 6)
                    {
                        pawns[r, c] = PAWN_SYMBOL;
                    }
                    else
                    {
                        pawns[r, c] = SPACE;
                    }
                }
            }
        }
    }
}