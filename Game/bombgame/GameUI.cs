using bombgame.Player;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Windows.Forms;
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
            connect = new Connect();
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
            /* Timer ±Ò°Ê */
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
        }

        private void Bomb_appear()
        {
            while (true)
            {
                if (players[ID].bomb != 4)
                {
                    for (int i = 0; i < players[ID].bomb; i += 2)
                    {
                        //  
                    }
                }
            }
        }

        private void GameUI_Load(object sender, EventArgs e)
        {

        }
    }
}

