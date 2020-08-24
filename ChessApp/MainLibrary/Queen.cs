using System.Linq.Expressions;

namespace MainLibrary
{
    public class Queen
    {

        public const char QUEEN_SYMBOL = 'Q';
        public const char SPACE = ' ';
        public static string[,] queens;

        public Queen()
        {
            queens = new string[ChessBoard.DIMENSION, ChessBoard.DIMENSION];
            initializeQueens();
        }

        private void initializeQueens()
        {
            for (int r = 0; r < ChessBoard.DIMENSION; r++)
            {
                for (int c = 0; c < ChessBoard.DIMENSION; c++)
                {
                    if (r == 0 && c == 4 || r == 7 && c == 4)
                    {
                        queens[r, c] = QUEEN_SYMBOL.ToString();
                    }
                    else
                    {
                        queens[r, c] = "";
                    }
                }
            }
        }
    }
}