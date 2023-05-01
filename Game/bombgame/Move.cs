using bombgame.Player;
using bombgame.Map;
using bombgame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace bombgame.Move
{
    public class Move
    {
        player pr;

        public Move(player pr, map mp)
        {
            this.pr = pr;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            while (true)
            {            
                if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
                {
                    if (pr.pos_y < 5)
                        pr.pos_y++;
                }

                else if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
                {
                    if (pr.pos_y > 0)
                        pr.pos_y--;
                }

                else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
                {
                    if (pr.pos_x < 5)
                        pr.pos_x++;
                }

                else if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
                {
                    if (pr.pos_x > 0)
                        pr.pos_x--;
                }

                else if (e.KeyCode == Keys.Space)
                {
                    if (pr.bomb > 0)
                    {
                        pr.SetBomb(pr.pos_x, pr.pos_y);
                    }

                }

                /*
                if (timeleft! > 0)
                    break;
                */
            }
        }
    }
    
}
