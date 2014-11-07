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
        {Random rnd = new Random();

            int x;
            int y;
            int xTarget;
            int yTarget;

            int playerWhite;
            int playerBlack; 

            Chessboard board = new Chessboard();
            board.Draw();
            //board.MoveWhitePiece();
            Thread.Sleep(1500);

            
            for (int i = 0; i <= 100000; i++)
            {
                playerWhite = rnd.Next(0, 8);

          
                    x = rnd.Next(0, 8);
                    y = rnd.Next(0, 8);
                    xTarget = rnd.Next(0, 8);
                    yTarget = rnd.Next(0, 8);
                    ChessPiece whitePiece = new ChessPiece(true, x, y);
                    ChessPiece blacwPiece = new ChessPiece(false, x, y);
                   

             
                    x = rnd.Next(0, 8);
                    y = rnd.Next(0, 8);
                    xTarget = rnd.Next(0, 8);
                    yTarget = rnd.Next(0, 8);
        
            }
            Console.ReadKey();
        }
    }
}
