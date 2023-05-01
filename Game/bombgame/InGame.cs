using bombgame.Player;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace bombgame
{
    public partial class InGame : Form
    {
        int timeleft;
        int round;
        string Round = "Round ";
        List<player> players;
        player User;



        public InGame(Connect form)
        {
            InitializeComponent();
            round = 0;
            players = new List<player>();
            User = new player(form.name);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timeleft = 30;
            label3.Text = "30";
            /* Timer ±Ò°Ê */
            timer1.Start();
            round++;
            label1.Text = Round + round.ToString();

            if (players.Count > 2)
            {
                label4.Text = players[0].bomb.ToString();
                label11.Text = players[1].bomb.ToString();
            }
            if (players.Count > 3) { label10.Text = players[2].bomb.ToString(); }
            if (players.Count > 4) { label9.Text = players[3].bomb.ToString(); }


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

    }
}

