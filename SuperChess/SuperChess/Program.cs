using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SuperChess
{
    class Program
    {
        static void Main(string[] args)
        {
            Chessboard board = new Chessboard();
            ChessPiece whitePiece = new ChessPiece(true);
            ChessPiece blacwPiece = new ChessPiece(false);
            board.Draw();
            //board.MoveWhitePiece();
            Thread.Sleep(1500);

            Random rnd = new Random();

            int x;
            int y;
            int xTarget;
            int yTarget;

            for (int i = 0; i <= 100000; i++)
            {
                do
                {
                    x = rnd.Next(0, 8);
                    y = rnd.Next(0, 8);
                    xTarget = rnd.Next(0, 8);
                    yTarget = rnd.Next(0, 8);
                    if (whitePiece.IsChessPieceWhite() == true)
                    {
                        board.MoveWhitePiece(x, y, xTarget, yTarget);

                    }
                } while (whitePiece.IsChessPieceWhite() != true);

                do
                {
                    x = rnd.Next(0, 8);
                    y = rnd.Next(0, 8);
                    xTarget = rnd.Next(0, 8);
                    yTarget = rnd.Next(0, 8);
                    if (blacwPiece.IsChessPieceBlack() == true)
                    {

                        board.MoveBlackPiece(x, y, xTarget, yTarget);
                    }
                } while (blacwPiece.IsChessPieceBlack() != true);
                

            }
            Console.ReadKey();
        }
    }
}
