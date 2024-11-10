using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xiangqi
{
    internal class GameManager
    {
        MatchGame matchGame = new MatchGame();

        public readonly Bitmap new_Advisor_A = new Bitmap(Xiangqi.Properties.Resources.black_advisor);
        public readonly Bitmap new_Bishop_A = new Bitmap(Xiangqi.Properties.Resources.black_bishop);
        public readonly Bitmap new_Cannon_A = new Bitmap(Xiangqi.Properties.Resources.black_cannon);
        public readonly Bitmap new_King_A = new Bitmap(Xiangqi.Properties.Resources.black_king);
        public readonly Bitmap new_Knight_A = new Bitmap(Xiangqi.Properties.Resources.black_knight);
        public readonly Bitmap new_Pawn_A = new Bitmap(Xiangqi.Properties.Resources.black_pawn);
        public readonly Bitmap new_Rook_A = new Bitmap(Xiangqi.Properties.Resources.black_rook);

        public readonly Bitmap new_Advisor_B = new Bitmap(Xiangqi.Properties.Resources.red_advisor);
        public readonly Bitmap new_Bishop_B = new Bitmap(Xiangqi.Properties.Resources.red_bishop);
        public readonly Bitmap new_Cannon_B = new Bitmap(Xiangqi.Properties.Resources.red_cannon);
        public readonly Bitmap new_King_B = new Bitmap(Xiangqi.Properties.Resources.red_king);
        public readonly Bitmap new_Knight_B = new Bitmap(Xiangqi.Properties.Resources.red_knight);
        public readonly Bitmap new_Pawn_B = new Bitmap(Xiangqi.Properties.Resources.red_pawn);
        public readonly Bitmap new_Rook_B = new Bitmap(Xiangqi.Properties.Resources.red_rook);

        List<ChessItem.CItem> chessItemBlack;
        List<ChessItem.CItem> chessItemRed;
        //need these for chess interactions

        public GameManager(MatchGame matchGame)
        {
            this.matchGame = matchGame;
        }

        public void PlaceDefaultChessItems(PaintEventArgs e)
        {
            chessItemBlack = new List<ChessItem.CItem>();
            chessItemRed = new List<ChessItem.CItem>();

            chessItemBlack.Add(new ChessItem.CItem(new_Advisor_A, 3, 9, e,1));
          
            chessItemBlack.Add(new ChessItem.CItem(new_Advisor_A, 5, 9, e, 1));
            chessItemBlack.Add(new ChessItem.CItem(new_Bishop_A, 2, 9, e, 1));
            chessItemBlack.Add(new ChessItem.CItem(new_Bishop_A, 6, 9, e, 1));
            chessItemBlack.Add(new ChessItem.CItem(new_Cannon_A, 1, 7, e, 1));
            chessItemBlack.Add(new ChessItem.CItem(new_Cannon_A, 7, 7, e, 1));
            chessItemBlack.Add(new ChessItem.CItem(new_King_A, 4, 9, e, 1));
            chessItemBlack.Add(new ChessItem.CItem(new_Knight_A, 1, 9, e, 1));
            chessItemBlack.Add(new ChessItem.CItem(new_Knight_A, 7, 9, e, 1));
            chessItemBlack.Add(new ChessItem.CItem(new_Rook_A, 0, 9, e, 1));
            chessItemBlack.Add(new ChessItem.CItem(new_Rook_A, 8, 9, e, 1));
            chessItemBlack.Add(new ChessItem.CItem(new_Pawn_A, 0, 6, e, 1));
            chessItemBlack.Add(new ChessItem.CItem(new_Pawn_A, 2, 6, e, 1));
            chessItemBlack.Add(new ChessItem.CItem(new_Pawn_A, 4, 6, e, 1));
            chessItemBlack.Add(new ChessItem.CItem(new_Pawn_A, 6, 6, e, 1));
            chessItemBlack.Add(new ChessItem.CItem(new_Pawn_A, 8, 6, e, 1));

            chessItemRed.Add(new ChessItem.CItem(new_Advisor_B, 3, 0, e,0));
            chessItemRed.Add(new ChessItem.CItem(new_Advisor_B, 5, 0, e,0));
            chessItemRed.Add(new ChessItem.CItem(new_Bishop_B, 2, 0, e,0));
            chessItemRed.Add(new ChessItem.CItem(new_Bishop_B, 6, 0, e,0));
            chessItemRed.Add(new ChessItem.CItem(new_Cannon_B, 1, 2, e,0));
            chessItemRed.Add(new ChessItem.CItem(new_Cannon_B, 7, 2, e,0));
            chessItemRed.Add(new ChessItem.CItem(new_King_B, 4, 0, e,0));
            chessItemRed.Add(new ChessItem.CItem(new_Knight_B, 1, 0, e,0));
            chessItemRed.Add(new ChessItem.CItem(new_Knight_B, 7, 0, e,0));
            chessItemRed.Add(new ChessItem.CItem(new_Rook_B, 0, 0, e,0));
            chessItemRed.Add(new ChessItem.CItem(new_Rook_B, 8, 0, e,0));
            chessItemRed.Add(new ChessItem.CItem(new_Pawn_B, 0, 3, e,0));
            chessItemRed.Add(new ChessItem.CItem(new_Pawn_B, 2, 3, e,0));
            chessItemRed.Add(new ChessItem.CItem(new_Pawn_B, 4, 3, e,0));
            chessItemRed.Add(new ChessItem.CItem(new_Pawn_B, 6, 3, e, 0));
            chessItemRed.Add(new ChessItem.CItem(new_Pawn_B, 8, 3, e, 0));
        }
    }
}
