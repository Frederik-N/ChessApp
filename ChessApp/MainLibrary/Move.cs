using System;

namespace MainLibrary
{
    public class Move : Pieces
    {
        private int x;
        private int y;
        private int desX;
        private int desY;
        private readonly string[,] chessBoard;

        public bool Exit { get; set; }

        public Move(string[,] chessBoard)
        {
            this.chessBoard = chessBoard;
            x = 0;
            y = 0;
            desX = 0;
            desY = 0;
            Exit = false;
        }

        public void MakeMove()
        {
            GetInput();
            if (!Exit)
            {
                RearrengePieces();
            }
        }

        private void RearrengePieces()
        {
            // TODO: tjek hvilken type brik der flyttes så der kan flyttes andre end pawns
            chessBoard[desX, desY] = chessBoard[x, y];
            chessBoard[x, y] = " ";
        }

        public string[,] getChessBoard()
        {
            return chessBoard;
        }

        private bool ValidateInput(bool parsed)
        {
            bool error = false;
            if(!parsed)
            {
                error = true;
            }
            else if(x <0 || y < 0 || desX < 0|| desY <0)
            {
                error = true;
            }
            else if (x > ChessBoard.DIMENSION -1 || y > ChessBoard.DIMENSION - 1 || desX > ChessBoard.DIMENSION - 1 || desY > ChessBoard.DIMENSION - 1)
            {
                error = true;
            }
            if(error)
            {
                Console.WriteLine("Invalid input exiting program");
            }

            return error;
        }

        private void GetInput()
        {

            Console.WriteLine("Enter X'axis: ");
            Exit = ValidateInput(int.TryParse(Console.ReadLine(), out x));

            if(!Exit)
            {
                Console.WriteLine("Enter Y'axis: ");
                Exit = ValidateInput(int.TryParse(Console.ReadLine(), out y));
            }

            Console.WriteLine("Enter destination X'axis: ");
            Exit = ValidateInput(int.TryParse(Console.ReadLine(), out desX));

            if (!Exit)
            {
                Console.WriteLine("Enter destionation Y'axis: ");
                Exit = ValidateInput(int.TryParse(Console.ReadLine(), out desY));
            }
        }
    }
}