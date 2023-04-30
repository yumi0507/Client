using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bombgame.Player
{
    public class player
    {
        private int id;
        private string name;
        private bool is_alive;

        public int pos_x;
        public int pos_y;
        private bool valid_pos;

        private int bomb_hold;
        private List<string> bomb_location;

        public player(string name)
        {
            this.name = name;
            is_alive = true;
            bomb_hold = 4;
            bomb_location = new List<string>();
        }

        public int bomb { get { return bomb_hold; } }

        public void GameSet(int index, int x, int y)
        {
            id = index;
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

        #region Position //每局起始位置由server發送
        public int Pos_x
        {
            set
            {
                if (id % 2 == 1) { pos_x = 0; }
                if (id % 2 == 0) { pos_x = 5; }
            }
        }

        public int Pos_y
        {
            set
            {
                if (id / 3 == 0) { pos_y = 0; }
                if (id / 3 == 1) { pos_y = 5; }
            }
        }

        public bool Valid_pos
        {
            get
            {
                if (pos_x <= 5 && pos_x >= 0 && pos_y <= 5 && pos_y >= 0)
                { return true; }
                return false;
            }
        }
        #endregion

    }

    
}
