using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Net;
using System.Net.Sockets;

namespace bombgame.Picture
{
    abstract class picture : PictureBox
    {
        public picture(int x, int y)
        {
            this.BackColor = Color.Transparent;
            this.Location = new Point(x, y);
            this.Size = new Size(160, 160);
        }
    }

    class Bomb : picture
    {
        public Bomb(int x, int y) : base(x, y)
        {
            this.Image = bombgame.Properties.Resources.Bomb;
        }
    }

    class Explode : picture
    {
        public Explode(int x, int y) : base(x, y)
        {
            this.Image = bombgame.Properties.Resources.Explode;
        }
    }
}