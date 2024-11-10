using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Xiangqi.ChessItem;

namespace Xiangqi.Pawns
{
    internal class Rook:CItem
    {
        public Rook(Bitmap chessItem, float locX, float locY, PaintEventArgs e,int fl)
            : base(chessItem, locX, locY, e,fl)
        {

        }
        public override int ChkRule(float locX, float locY)
        {
            if(flag == 1)
            {
                
            }
            return 0;
        }
    }
}
