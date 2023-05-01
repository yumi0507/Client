using bombgame.Player;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace bombgame
{
    public partial class Form1 : Form
    {
        int timeleft;
        int round;
        string Round = "Round ";
        List<player> players;
        player User;
        


        public Form1(Form2 form)
        {
            InitializeComponent();
            round = 0;
            players = new List<player>();
            User(form.)
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timeleft = 30;
            label3.Text = "30";
            /* Timer ±Ò°Ê */
            timer1.Start();
            round++;
            label1.Text = Round + round.ToString();

            label4.Text = player1.bomb.ToString();
            label11.Text = player2.bomb.ToString();
            label10.Text = player3.bomb.ToString();
            label9.Text = player4.bomb.ToString();


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

