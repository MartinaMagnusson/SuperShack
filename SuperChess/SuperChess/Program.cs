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
            board.Draw();
            board.MoveWhitePiece();
            Thread.Sleep(1000);
           

            //board.MoveWhitePiece(6, 2, 5, 2);

            //board.MoveBlackPiece(1, 3, 2, 3);

            //board.MoveWhitePiece(5, 2, 2, 3);

            //board.MoveBlackPiece(1, 1, 2, 1);





            Console.ReadKey();
        }
    }
}
