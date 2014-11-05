using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperChess
{
    class ChessPiece
    {
        bool isWhite = true;       

        public ChessPiece(bool isWhite)
        {
            this.isWhite = isWhite; //Sätter om pjäsen är vit eller svart
            //this.X = x;
            //this.y = y; 
        }

        public bool IsChessPieceWhite() //kollar om piece är vit
        {
            if(this.isWhite == true)
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
            if(this.isWhite == false)
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
            if(this.isWhite == false)
            {
                color = "B";
            }
            return color + this.GetChessPieceDescription(); 
        }

        public virtual string GetChessPieceDescription()
        {
            return "U";
        }

        public virtual bool ValidateMove(int x, int y, int xTarget, int yTarget)
        {
            return true;
        }
    }
}
