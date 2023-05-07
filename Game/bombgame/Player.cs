using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using bombgame.Properties;
using System.Web;
using bombgame.Picture;
using System.Numerics;
using bombgame;
namespace bombgame.Player
{
    public class player : PictureBox
    {
        private string id;

        public int pos_x;
        public int pos_y;
        public TcpClient tcpClient;
        public Connection_Control connect;

        private int bomb_hold;
        private bool[,] bomb_location;
        private List<Bomb> bomb_onTile;
        private int[] Row = new int[6] {10,94,178,262,346,430};
        private int[] Col = new int[6] {16,101,186,271,356,441};

        public player(string ID, TcpClient client)//For local client
        {
            tcpClient = client;
            id = ID;
            bomb_hold = 4;
            connect = new Connection_Control(client);
            bomb_location = new bool[6, 6];
            for(int i = 0;  i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                    bomb_location[i, j] = false;
            }
            bomb_onTile = new List<Bomb>();
            
            SetImage();

        }
        public player(string ID)//For not local client
        {
            id = ID; 
            int pos_x = 0;
            int pos_y = 0;
            SetImage();
        }

        public void SetImage()
        {
            int Player_ID = int.Parse(id);
            switch (Player_ID)
            {
                case 1:
                    this.Image = Resources.alienPink_stand;
                    break;
                case 2:
                    this.Image = Resources.alienYellow_stand;
                    break;
                case 3:
                    this.Image = Resources.alienBlue_stand;
                    break;
                case 4:
                    this.Image = Resources.alienGreen_stand;
                    break;
            }
            this.Visible = false;
        }

        public int ID { get { return int.Parse(id); } }
        public int bomb { get { return bomb_hold; } }

        public void GameSet(int x, int y)
        {
            pos_x = x;
            pos_y = y;
            this.Left = Row[y];
            this.Top = Col[x];
            // = new Point(Row[y], Col[x]);
            Invoke(new MethodInvoker(() => { this.Visible = true; }));
        }

        public void SetBomb()
        {
            bomb_location[pos_x, pos_y] = true;
            bomb_onTile.Add(new Bomb(pos_y, pos_x));
            bomb_hold--;
        }

        public void ClearBomb()
        {
            foreach(Bomb bomb in bomb_onTile) 
            { 
                Invoke(new MethodInvoker(() => { bomb.Invalidate(); })); 
            }
            bomb_onTile.Clear();
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                    bomb_location[i, j] = false;
            }
            bomb_hold = 4;
        }

        public void MoveLeft()
        {
            pos_y--;
            Invoke(new MethodInvoker(() => { this.Left -= 84; }));
        }

        public void MoveRight()
        {
            pos_y++;
            Invoke(new MethodInvoker(() => { this.Left += 84; }));
        }

        public void MoveUp()
        {
            pos_x--;
            Invoke(new MethodInvoker(() => { this.Top -= 85; }));
        }

        public void MoveDown() 
        {
            pos_x++;
            Invoke(new MethodInvoker(() => { this.Top += 85; }));
        }
        
    }
    
}
