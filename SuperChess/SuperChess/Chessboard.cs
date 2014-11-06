using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SuperChess
{
    class Chessboard
    {
        ChessPiece[,] board = new ChessPiece[8, 8];

        public Chessboard() //sätter ut alla piece
        {
            this.InitBoard();
        }
        public List<string> message = new List<string>();
        public void MoveWhitePiece(int x, int y, int xTarget, int yTarget)//vitas drag
        {
            ChessPiece piece = this.board[x, y];
            ChessPiece targetPiece = this.board[xTarget, yTarget];

            if (piece == null)//fel som kan uppstå för vita
            {
                message.Add("Det finns ingen vit spelare på denna position");
                // Console.WriteLine("Det finns ingen vit spelare på denna position");
                return;
            }
            if (piece.IsChessPieceBlack())
            {
                message.Add("Det går inte att flytta en svart pjäs");
                return;
            }
            if (!piece.ValidateMove(x, y, xTarget, yTarget))
            {
                message.Add("Ogiltligt drag!");
                return;
            }
            if (targetPiece != null)
            {
                if (targetPiece.IsChessPieceWhite())
                {
                    message.Add("Du kan inte ta din egna pjäs");
                    return;
                }
            }

            this.board[x, y] = null; //När allt går rätt
            this.board[xTarget, yTarget] = piece;
            this.Draw();
            Console.WriteLine("{0},{1} till {2},{3}", x, y, xTarget, yTarget);
            foreach (var item in message)
            {
                //Console.WriteLine(item);
            }
            if (targetPiece != null)
            {
                Console.WriteLine("Vit spelare slog ut " + targetPiece.GetChessPieceType());
            }
            Thread.Sleep(1000);


        }
        public void MoveBlackPiece(int x, int y, int xTarget, int yTarget)//vitas drag
        {
            ChessPiece piece = this.board[x, y];
            ChessPiece targetPiece = this.board[xTarget, yTarget];

            if (piece == null)//fel som kan uppstå för vita
            {
              //  Console.WriteLine("Det finns ingen svart spelare på denna position");
                return;
            }
            if (piece.IsChessPieceWhite())
            {
             //   Console.WriteLine("Det går inte att flytta en vit pjäs");
                return;
            }
            if (!piece.ValidateMove(x, y, xTarget, yTarget))
            {
               // Console.WriteLine("Ogiltligt drag!");
                return;
            }
            if (targetPiece != null)
            {
                if (targetPiece.IsChessPieceBlack())
                {
                   // Console.WriteLine("Du kan inte ta din egna pjäs");
                    return;
                }
            }
            
            this.board[x, y] = null; //När allt går rätt
            this.board[xTarget, yTarget] = piece;
            this.Draw();
            Console.WriteLine("{0},{1} till {2},{3}", x, y, xTarget, yTarget);
            if (targetPiece != null)
            {
               Console.WriteLine("Svart spelare slog ut vit " + targetPiece.GetChessPieceType());
            }
            Thread.Sleep(1000);
        }
        public void AddChessPiece(ChessPiece piece, int x, int y)//en metod för att kunna lägga til piece
        {
            this.board[x, y] = piece;
        }

        public void Draw()//ritar upp spelbrädan 
        {
            Console.Clear();
            for (int x = 0; x < 8; x++)
            {
                Console.Write("|");
                for (int y = 0; y < 8; y++)
                {
                    ChessPiece piece = this.board[x, y];
                    if (piece != null)
                    {
                        Console.Write(piece.GetChessPieceType());
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                    Console.Write("|");
                }
                Console.WriteLine("");
            }
        }
        public void InitBoard()
        {
                       
            //Sätter ut pjäserna
            for (int x = 7; x >= 0; x--)
            {
                if (x == 6)
                    for (int y = 0; y <= 7; y++)
                    {
                        //Sätter ut vita
                        this.AddChessPiece(new Pawn(true), x, y);
                    }
                if (x == 1)
                    for (int y = 0; y <= 7; y++)
                    {
                        //Sätter ut svarta
                        this.AddChessPiece(new Pawn(false), x, y);
                    }
            }
        }
    }
}
