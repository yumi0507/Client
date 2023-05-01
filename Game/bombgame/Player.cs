using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace bombgame.Player
{
    public class player
    {
        private string id;

        public int pos_x;
        public int pos_y;
        public TcpClient tcpClient;

        private int bomb_hold;
        private List<string> bomb_location;

        public player(string ID, TcpClient client)
        {
            tcpClient = client;
            id = ID;
            bomb_hold = 4;
            bomb_location = new List<string>();
        }

        public int ID { get { return int.Parse(id); } }
        public int bomb { get { return bomb_hold; } }

        public void GameSet(int index, int x, int y)
        {
            pos_x = x;
            pos_y = y;
        }

        public void SetBomb()
        {
            bomb_location.Add(pos_x.ToString());
            bomb_location.Add(pos_y.ToString());
            bomb_hold--;
        }

        public void NewRoundSet()
        {
            bomb_location.Clear();
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
                    }

                }
            }

    
}
