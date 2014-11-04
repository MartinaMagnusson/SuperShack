﻿using System;
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

        public void MoveWhitePiece(int x, int y, int xTarget, int yTarget)//vitas drag
        {
            ChessPiece piece = this.board[x, y];
            ChessPiece targetPiece = this.board[xTarget, yTarget];
            if (piece == null)//fel som kan uppstå för vita
            {
                Console.WriteLine("Det finns ingen vit spelare på denna position");
                return;
            }
            if (piece.IsChessPieceBlack())
            {
                Console.WriteLine("Det går inte att flytta en svart pjäs");
                return;
            }
            if (!piece.ValidateMove(x, y, xTarget, yTarget))
            {
                Console.WriteLine("Ogiltligt drag!");
                return;
            }
            if (targetPiece != null)
            {
                if (targetPiece.IsChessPieceWhite())
                {
                    Console.WriteLine("Du kan inte ta din egna pjäs");
                    return;
                }
            }

            this.board[x, y] = null; //När allt går rätt
            this.board[xTarget, yTarget] = piece;
            this.Draw();
            if (targetPiece != null)
            {
                Console.WriteLine("Vit spelare slog ut" + targetPiece.GetChessPieceDescription());
            }
            Thread.Sleep(1000);
        }

        private string message;
        public string MoveBlackPiece(int x, int y, int xTarget, int yTarget)//drag för svart
        {
            ChessPiece piece = this.board[x, y];
            ChessPiece targetPiece = this.board[xTarget, yTarget];
            if (piece == null)//fel som kan uppstå för svart
            {
                message = "Det finns ingen svart spelare på denna position";
                //Console.WriteLine("Det finns ingen svart spelare på denna position");
                //return;
            }
            if (piece.IsChessPieceWhite())
            {
                message = "Det går inte att flytta en vit pjäs";
                //Console.WriteLine("Det går inte att flytta en vit pjäs");
                //return;
            }
            if (!piece.ValidateMove(x, y, xTarget, yTarget))
            {
                message = "Ogiltligt drag!";
                //Console.WriteLine("Ogiltligt drag!");
                //return;
            }
            if (targetPiece != null)
            {
                if (targetPiece.IsChessPieceBlack())
                {
                    message = "Du kan inte ta din egna pjäs";
                    //Console.WriteLine("Du kan inte ta din egna pjäs");
                    //return;
                }
            }

            this.board[x, y] = null;//när allt går rätt
            this.board[xTarget, yTarget] = piece;
            this.Draw();
            if (targetPiece != null)
            {
                message = "Svart spelare slog ut" + targetPiece.GetChessPieceDescription();
                //Console.WriteLine("Svart spelare slog ut" + targetPiece.GetChessPieceDescription());
            }
            Thread.Sleep(1000);
            return message;
        }

        public void AddChessPiece(ChessPiece piece, int x, int y)//en metod för att kunna lägga til piece
        {
            //List<ChessPiece> whitePiece = new List<ChessPiece>();
            //List<ChessPiece> blackPiece = new List<ChessPiece>(); 
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
            //List<ChessPiece> whitePiece = new List<ChessPiece>();
            //List<ChessPiece> blackPiece = new List<ChessPiece>();


            for (int x = 0; x <= 7; x++)
            {
                if (x == 6)
                    for (int y = 0; y <= 7; y++)
                    {
                        this.AddChessPiece(new Pawn(true), x, y);
                    }
                if (x == 1)
                    for (int y = 0; y <= 7; y++)
                    {
                        this.AddChessPiece(new Pawn(false), x, y);
                    }
            }


            //this.AddChessPiece(new Pawn(true), 6, 0);//vit
            //this.AddChessPiece(new Pawn(true), 6, 1);
            //this.AddChessPiece(new Pawn(true), 6, 2);
            //this.AddChessPiece(new Pawn(true), 6, 3);
            //this.AddChessPiece(new Pawn(true), 6, 4);
            //this.AddChessPiece(new Pawn(true), 6, 5);
            //this.AddChessPiece(new Pawn(true), 6, 6);
            //this.AddChessPiece(new Pawn(true), 6, 7);

            //this.AddChessPiece(new Pawn(false), 1, 0);//svart
            //this.AddChessPiece(new Pawn(false), 1, 1);
            //this.AddChessPiece(new Pawn(false), 1, 2);
            //this.AddChessPiece(new Pawn(false), 1, 3);
            //this.AddChessPiece(new Pawn(false), 1, 4);
            //this.AddChessPiece(new Pawn(false), 1, 5);
            //this.AddChessPiece(new Pawn(false), 1, 6);
            //this.AddChessPiece(new Pawn(false), 1, 7);
        }
    }
}