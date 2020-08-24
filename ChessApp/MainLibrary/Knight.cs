using System.Linq.Expressions;

namespace MainLibrary
{
    public class Knight
    {

        public const char KNIGHT_SYMBOL = 'N';
        public const char SPACE = ' ';
        public static string[,] knights;

        public Knight()
        {
            knights = new string[ChessBoard.DIMENSION, ChessBoard.DIMENSION];
            initializeKnights();
        }

        private void initializeKnights()
        {
            for (int r = 0; r < ChessBoard.DIMENSION; r++)
            {
                for (int c = 0; c < ChessBoard.DIMENSION; c++)
                {
                    if (r == 0 && (c==1 || c == 6) || r == 7 && (c==1 || c == 6))
                    {
                        knights[r, c] = KNIGHT_SYMBOL.ToString();
                    }
                    else
                    {
                        knights[r, c] = "";
                    }
                }
            }
        }
    }
}