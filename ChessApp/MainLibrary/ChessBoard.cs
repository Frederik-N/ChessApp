using System;
using System.Collections.Generic;
using System.Text;

namespace MainLibrary
{
    public class ChessBoard
    {
        private string[,] chessBoard;
        public const int DIMENSION = 8; // 8x8 board
        private Move move;

        public ChessBoard()
        {
            chessBoard = new string[DIMENSION, DIMENSION];
            move = new Move(chessBoard);
            ChessBoardInitialize();
            Rank = "+---";
            File = "| ";
        }

        private void ChessBoardInitialize()
        {
            for (int r = 0; r < DIMENSION; r++)
            {
                for (int c = 0; c < DIMENSION; c++) {
                    chessBoard[r, c] = Pawn.pawns[r,c] + Rook.rooks[r,c] + Bishop.bishops[r,c] + Queen.queens[r,c] + Knight.knights[r,c] + King.kings[r,c];
                    if(chessBoard[r, c] == String.Empty)
                    {
                        chessBoard[r, c] = " ";
                    }
                }
            }
        }

        public string Rank { get; set; }
        public string File { get; set; }

        public void displayChessBoard()
        {
            while(!move.Exit)
            {
                Console.Clear();
                Console.WriteLine("    0   1   2   3   4   5   6   7");

                for(int r = 0; r < DIMENSION; r++)
                {
                    Console.Write("  ");
                    for(int c = 0; c < DIMENSION; c++)
                    {
                        Console.Write(Rank);
                    }
                    Console.Write("+\n");


                    for(int c = 0; c < DIMENSION; c++)
                    {
                        if(c == 0)
                        {
                            Console.Write(r + " ");
                        }
                        
                        Console.Write(File + chessBoard[r,c] + " ");
                    }

                    Console.Write("|\n");
                }

                Console.Write("  ");
                for (int c = 0; c < DIMENSION; c++)
                {
                    Console.Write(Rank);
                }
                Console.Write("+\n");
                
                move.MakeMove();
                chessBoard = move.getChessBoard();
            }
        }
    }
}
