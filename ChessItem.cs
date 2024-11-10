using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Xiangqi
{
    internal class ChessItem
    {
        
        public class CItem
        {
            public static class ChessData
            {
                public static int[,] arr = new int[8, 9];
            }
            public float locX, locY;
            public float diaX, diaY;
            public int flag;
            public CItem(Bitmap chessItem, float locX, float locY, PaintEventArgs e,int fl)
            {
                this.locX = 253 + locX * 399 / 8 - 419 / 16;
                this.locY = 527 - locY * 449 / 9 - 469 / 18;
                diaX = 50;
                diaY = 50;
                flag = fl;
                Graphics g = e.Graphics;
                g.DrawImage(chessItem, this.locX, this.locY, diaX, diaY);
                int x = Convert.ToInt32(locX);
                int y = Convert.ToInt32(locY);
                ChessData.arr[x, y] = 1;
                this.locX = x;
                this.locY = y;
            }
            public virtual int ChkRule(float locX, float locY)
            {
                return - 1;
            }
            public virtual void Move(float locX, float locY)
            {

            }

            public virtual int SamePoint(float locX, float locY)
            {
                return -1;
            }

        }
    }
}
