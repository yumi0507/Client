using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bombgame.Player
{
    public class player
    {
        public int id;
        public string name;
        public bool is_alive = true;

        public int pos_x;
        public int pos_y;
        public bool valid_pos;

        public int bomb_hold = 4;

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

    }

    
}
