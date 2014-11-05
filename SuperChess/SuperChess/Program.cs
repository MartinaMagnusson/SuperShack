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
            //board.MoveWhitePiece();
            Thread.Sleep(1000);



            Random rnd = new Random();
            
            int x;
            int y;
            int xTarget;
            int yTarget;

            for (int i = 0; i <= 1000000000; i++)
            {
                for (int i = 0; i <= 1; i++)
                {
                    x = rnd.Next(0, 7);
                    y = rnd.Next(0, 7);
                    xTarget = rnd.Next(0, 7);
                    yTarget = rnd.Next(0, 7);
                    board.MoveWhitePiece(x, y, xTarget, yTarget);

                }
                for (int i = 0; i <= 1; i++)
                {
                    x = rnd.Next(0, 7);
                    y = rnd.Next(0, 7);
                    xTarget = rnd.Next(0, 7);
                    yTarget = rnd.Next(0, 7);
                    board.MoveBlackPiece(x, y, xTarget, yTarget);

                }
            }


            //board.MoveWhitePiece(6, 2, 5, 2);

            //board.MoveBlackPiece(1, 3, 2, 3);

            //board.MoveWhitePiece(5, 2, 2, 3);

            //board.MoveBlackPiece(1, 1, 2, 1);





            Console.ReadKey();
        }
    }
}
