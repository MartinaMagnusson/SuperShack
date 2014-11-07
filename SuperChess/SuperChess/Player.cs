using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperChess
{
    class Player
    {
        public List<ChessPiece> piece = new List<ChessPiece>();
        
        public int X { get; set; }
        public int Y { get; set; }
        public Player(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        

    }
}
