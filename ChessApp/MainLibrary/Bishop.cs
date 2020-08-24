using System.Linq.Expressions;

namespace MainLibrary
{
    public class Bishop
    {

        public const char BISHOP_SYMBOL = 'B';
        public const char SPACE = ' ';
        public static string[,] bishops;

        public Bishop()
        {
            bishops = new string[ChessBoard.DIMENSION, ChessBoard.DIMENSION];
            initializeBishops();
        }

        private void initializeBishops()
        {
            for (int r = 0; r < ChessBoard.DIMENSION; r++)
            {
                for (int c = 0; c < ChessBoard.DIMENSION; c++)
                {
                    if (r == 0 && (c == 2 || c == 5) || r == 7 && (c == 2 || c == 5))
                    {
                        bishops[r, c] = BISHOP_SYMBOL.ToString();
                    }
                    else
                    {
                        bishops[r, c] = "";
                    }
                }
            }
        }
    }
}