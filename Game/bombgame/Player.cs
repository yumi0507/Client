using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Net;
using System.Net.Sockets;

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

        public player(string ID, TcpClient client)
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
        }
        public player(string ID)
        {
            id = ID; 
            int pos_x = 0;
            int pos_y = 0;
    }

        public int ID { get { return int.Parse(id); } }
        public int bomb { get { return bomb_hold; } }

        public void GameSet(int x, int y)
        {
            pos_x = x;
            pos_y = y;
        }

        public void SetBomb()
        {
            bomb_location[pos_x, pos_y] = true;
            bomb_hold--;
        }

        public void NewRoundSet()
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                    bomb_location[i, j] = false;
            }
            bomb_hold = 4;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            while (true)
            {
                if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
                {
                    if (pos_y < 5)
                        pos_y++;
                    
                }

                else if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
                {
                    if (pos_y > 0)
                        pos_y--;
                }

                else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
                {
                    if (pos_x < 5)
                        pos_x++;
                }

                else if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
                {
                    if (pos_x > 0) 
                        pos_x--;
                }

                else if (e.KeyCode == Keys.Space)
                {
                    if (bomb > 0)
                    {
                        SetBomb();
                        connect.SenttoServer("PB"+pos_x.ToString()+pos_y.ToString());
                    }
                    else
                        MessageBox.Show("You have no Bombs left.");

                }
            }
        }
    }
    
}
