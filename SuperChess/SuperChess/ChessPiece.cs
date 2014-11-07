using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperChess
{
   public class ChessPiece
    {
        public bool isWhite = true;

        public ChessPiece(bool isWhite, int x, int y)
        {
            this.isWhite = isWhite; 
        }
        public ChessPiece()
        { }

        public bool IsChessPieceWhite() //kollar om piece är vit
        {
            if (this.isWhite == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool IsChessPieceBlack()//kollar om piece är svart
        {
            if (this.isWhite == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string GetChessPieceType() //Ger piece färg vit eller svart
        {
            string color = "W";
            if (this.isWhite == false)
            {
                color = "B";
            }
            return color + this.GetChessPieceDescription();
        }

        public virtual string GetChessPieceDescription()
        {
            return "U";
        }
        public int X { get; set; }
        public int Y { get; set; }
        public virtual void PositionWhite(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public virtual void PositionBlack(int x, int y)
        {
            this.X = x;

        }
        public virtual bool ValidateMove(int x, int y, int xTarget, int yTarget)
        {
            return true;
        }
    }
}
