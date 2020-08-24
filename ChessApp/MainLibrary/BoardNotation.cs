using System;

namespace MainLibrary
{
    public class BoardNotation
    {
        public String[,] Boardcoordinates { get; private set; }

        public BoardNotation()
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
