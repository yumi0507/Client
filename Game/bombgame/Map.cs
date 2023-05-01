using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bombgame.Map
{
    public class map
    {
        public int player_num;
        public bool valid_player_num;
        private int[,] state_init = new int[6, 6] {{ 0, 0, 0, 0, 0, 0 },
                                                  { 0, 0, 0, 0, 0, 0 },
                                                  { 0, 0, 0, 0, 0, 0 },
                                                  { 0, 0, 0, 0, 0, 0 },
                                                  { 0, 0, 0, 0, 0, 0 },
                                                  { 0, 0, 0, 0, 0, 0 }};

        public int[,] map_state = new int[6, 6] {{ 0, 0, 0, 0, 0, 0 },
                                                  { 0, 0, 0, 0, 0, 0 },
                                                  { 0, 0, 0, 0, 0, 0 },
                                                  { 0, 0, 0, 0, 0, 0 },
                                                  { 0, 0, 0, 0, 0, 0 },
                                                  { 0, 0, 0, 0, 0, 0 }};

        public bool Valid_player_num
        {
            get
            {
                if (player_num >= 2 || player_num <= 4)
                { return true; }
                return false;
            }

        }

        public int[,] mapstate_reset()
        {
            return state_init;
        }
    }
}
