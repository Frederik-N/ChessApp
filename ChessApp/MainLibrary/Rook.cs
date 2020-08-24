using System.Linq.Expressions;

namespace MainLibrary
{
    public class Rook
    {

        public const char ROOK_SYMBOL = 'R';
        public const char SPACE = ' ';
        public static string[,] rooks;

        public Rook()
        {
            rooks = new string[ChessBoard.DIMENSION, ChessBoard.DIMENSION];
            initializeRooks();
        }

        private void initializeRooks()
        {
            for (int r = 0; r < ChessBoard.DIMENSION; r++)
            {
                for (int c = 0; c < ChessBoard.DIMENSION; c++)
                {
                    if (r == 0 && (c == 0 || c == 7) || r == 7 && (c == 0 || c == 7))
                    {
                        rooks[r, c] = ROOK_SYMBOL.ToString();
                    }
                    else
                    {
                        rooks[r, c] = "";
                    }
                }
            }
        }
    }
}