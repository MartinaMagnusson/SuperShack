﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperChess
{
    class Pawn : ChessPiece
    {
        public Pawn(bool isWhite)
            : base(isWhite)
        {
        }

        public override string GetChessPieceDescription() //Piece blir en bonde
        {
            return "P";
        }
        public override bool ValidateMove(int x, int y, int xTarget, int yTarget) 
        {
            bool move = true;
            
            //logik för vita
            if ((this.IsChessPieceWhite()) && (xTarget >= x || xTarget < x - 1))
                move = false;
            if (this.IsChessPieceWhite() && (yTarget != y))
                move = false;

            //Logik för svarta
            if ((this.IsChessPieceBlack()) && (xTarget <= x || xTarget > x + 1))
                move = false;
            if (this.IsChessPieceBlack() && (yTarget != y))
                move = false;            
           
            return move; //Här måste vi kolla om draget är tillåtet, om det inte är tillåtet returnerar vi false.
        }

    }
}
