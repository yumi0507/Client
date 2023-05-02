using bombgame.Player;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace bombgame
{
    public partial class GameUI : Form
    {
        int timeleft;
        int round;
        int ID;
        string Round = "Round ";
        Connect connect;
        List<player> players;
        //player User;



        public GameUI(Connect form)
        {
            InitializeComponent();
            connect = form;
            round = 0;
            ID = connect.player.ID;
            players = new List<player>();
        }

        private void Round_Start(object sender, EventArgs e)
        {
            round++;
            label1.Text = Round + round.ToString();
            timeleft = 30;
            label3.Text = "30";
            /* Timer 啟動 */
            timer1.Start();

            /*
            if (players.Count > 2)
            {
                label4.Text = players[0].bomb.ToString();
                label11.Text = players[1].bomb.ToString();
            }
            if (players.Count > 3) { label10.Text = players[2].bomb.ToString(); }
            if (players.Count > 4) { label9.Text = players[3].bomb.ToString(); }
            */
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeleft > 0)
            {
                timeleft = timeleft - 1;
                label3.Text = timeleft.ToString();
            }
            else
            {
                timer1.Stop();
                label3.Text = "0";
            }

            if (players[ID].bomb != 4)
            {
                for (int i = 0; i < players[ID].bomb; i += 2)
                {
                    //  bomb appear(i, i+1)
                }
            }
        }

        public void OtherPlayerAction(string id, string state)
        {
            int num = Convert.ToInt32(id);
            if (num == ID)
            {
                return;
            }
            
            if (state[0] == '-')
            {
                // 顯示此玩家已淘汰
                return;
            }
            int row = Convert.ToInt32(state[0]);
            int col = Convert.ToInt32(state[2]);

            players[num].pos_x = row;
            players[num].pos_y = col;

        }

        private void GameUI_Load(object sender, EventArgs e)
        {

        }
    }
}

