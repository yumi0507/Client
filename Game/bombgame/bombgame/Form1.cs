using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace bombgame
{
    public partial class Form1 : Form
    {
        int timeleft;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timeleft = 30;
            label2.Text = "30";
            /* Timer ±Ò°Ê */
            timer1.Start();
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

