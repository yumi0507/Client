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

        public int bomb { get { return bomb_hold; } }

        public void GameSet(int index, int x, int y)
        {
            pos_x = x;
            pos_y = y;
        }

        public void SetBomb(int x, int y)
        {
            bomb_location.Add(x.ToString());
            bomb_location.Add(y.ToString());
            bomb_hold--;
        }

        public void NewRoundSet()
        {
            bomb_location.Clear();
        }

    }

    
}
