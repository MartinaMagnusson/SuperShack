using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperChess
{
    class Pawn : ChessPiece
    {
        //public int X { get; set; }
        //public int Y { get; set; }
        public Pawn(bool isWhite)
            : base(isWhite)
        {
            //this.X = x;
            //this.Y = y;
        }

        public override string GetChessPieceDescription() //Piece blir en bonde
        {
            return "P";
        }


    }
}
