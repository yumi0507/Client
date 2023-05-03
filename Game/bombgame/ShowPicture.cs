using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Net;
using System.Net.Sockets;

namespace Picture
{
    abstract class picture : PictureBox
    {
        public picture(int x, int y)
        {
            this.BackColor = Color.Transparent;
            this.Location = new Point(x, y);
            this.Size = new Size(160,160);
        }
    }

    class Bomb : picture
    {
        public Bomb(int x, int y) : base(x, y)
        {
            this.Image = Properties.Resources.Bomb; //  等圖片
        }
    }

    class Explode : picture
    {
        public Explode(int x, int y) : base(x, y)
        {
            this.Image = Properties.Resources.Explode; //   等圖片
        }
    }
}