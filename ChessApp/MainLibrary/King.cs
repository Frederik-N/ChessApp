using System.Linq.Expressions;

namespace MainLibrary
{
    public class King
    {

        public const char KING_SYMBOL = 'K';
        public const char SPACE = ' ';
        public static string[,] kings;

        public King()
        {
            kings = new string[ChessBoard.DIMENSION, ChessBoard.DIMENSION];
            initializeKings();
        }

        private void initializeKings()
        {
            for (int r = 0; r < ChessBoard.DIMENSION; r++)
            {
                for (int c = 0; c < ChessBoard.DIMENSION; c++)
                {
                    if (r == 0 && c == 3 || r == 7 && c == 3)
                    {
                        kings[r, c] = KING_SYMBOL.ToString();
                    }
                    else
                    {
                        kings[r, c] = "";
                    }
                }
            }
        }
    }
}