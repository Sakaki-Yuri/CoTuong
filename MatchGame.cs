using System.Windows.Forms;

namespace Xiangqi
{
    
    public partial class MatchGame : Form
    {
        public Rectangle chessLocation;

        public readonly Bitmap banCo = new Bitmap(Xiangqi.Properties.Resources.JanggiBrown);

        public MatchGame()
        {
            InitializeComponent();

            chessLocation.Width = 451;
            chessLocation.Height = 501;
            chessLocation.Location = new Point(225, 50);
        }

        private void MatchGame_Paint(object sender, PaintEventArgs e)
        {
            GameManager manager = new GameManager(this);
            Graphics g = e.Graphics;

            g.DrawImage(banCo, chessLocation);
            manager.PlaceDefaultChessItems(e);
        }

        private void testRestart_Click(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
