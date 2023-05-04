using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using bombgame;

namespace bombgame.Picture
{
    abstract class picture : PictureBox
    {
        private int[] Row = new int[6] { 10, 94, 178, 262, 346, 430 };
        private int[] Col = new int[6] { 16, 101, 186, 271, 356, 441 };

        public picture(int x, int y)
        {
            this.BackColor = Color.Transparent;
            this.Location = new Point(Row[y], Col[x]);
            this.Size = new Size(160, 160);
        }
    }

    class Bomb : picture
    {
        public Bomb(int x, int y) : base(x, y)
        {
            this.Image = Properties.Resources.Bomb;
        }
    }

    class Explode : picture
    {
        public Explode(int x, int y) : base(x, y)
        {
            this.Image = Properties.Resources.Explode;
        }
    }
}