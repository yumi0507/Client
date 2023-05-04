using bombgame.Player;
using bombgame.Picture;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Text;

namespace bombgame
{
    public partial class GameUI : Form
    {
        int timeleft;
        int round;
        int ID;
        string Round = "Round ";
        string user;
        Connect connect;
        Dictionary<string, player> players;
        bool GameStart = false;



        public GameUI(Connect form)
        {
            InitializeComponent();
            connect = form;
            round = 0;
            ID = connect.player.ID;
            user = ID.ToString();
            players = new Dictionary<string, player>();
            players.Add(connect.player.ID.ToString(), connect.player);
            Thread thread = new Thread(ClientHandled_For_Game);
            thread.IsBackground = true;
            thread.Start(connect.tcpClient);

            if (GameStart)
                GameLoop();
            else
            {

            }
        }

        private void GameUI_KeyDown(object sender, KeyEventArgs e)
        {

            while (true)
            {
                if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
                {
                    if (players[user].pos_y < 5)
                        players[user].MoveRight();

                }

                else if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
                {
                    if (players[user].pos_y > 0)
                        players[user].MoveLeft();
                }

                else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
                {
                    if (players[user].pos_x < 5)
                        players[user].MoveDown();
                }

                else if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
                {
                    if (players[user].pos_x > 0)
                        players[user].MoveUp();
                }

                else if (e.KeyCode == Keys.Space)
                {
                    if (players[user].bomb > 0)
                    {
                        players[user].SetBomb();
                        players[user].connect.SenttoServer("PB" + players[user].pos_x.ToString() + players[user].pos_y.ToString());
                    }
                    else
                        MessageBox.Show("You have no Bombs left.");

                }
            }
        }
        public void GameLoop()
        {

        }

        private void Round_Start(object sender, EventArgs e)
        {
            round++;
            LB_round.Text = Round + round.ToString();
            timeleft = 30;
            LB_seconds.Text = "30";
            /* Timer ±Ò°Ê */
            timer1.Start();
        }
        public void ClientHandled_For_Game(Object clientobj)
        {
            TcpClient client = (TcpClient)clientobj;
            NetworkStream networkStream = client.GetStream();
            while (true)
            {
                try
                {
                    if (networkStream.CanRead)
                    {
                        byte[] buffer = new byte[2048];
                        int BytesReaded = networkStream.Read(buffer, 0, buffer.Length);
                        if (BytesReaded <= 0)
                        {
                        }
                        else
                        {
                            string Message_From_Server = Encoding.UTF8.GetString(buffer, 0, BytesReaded);
                            string Command = Message_From_Server.Substring(0, 2);
                            switch (Command)
                            {
                                case "GS":
                                    GameStart = true;
                                    break;
                                case "NP":
                                    {
                                        string Player_ID = Message_From_Server.Substring(3, 1);
                                        players.Add(Player_ID, new player(Player_ID));
                                    }
                                    break;
                                case "PL":
                                    {
                                        string Player_ID = Message_From_Server.Substring(2, 1);
                                        string x = Message_From_Server.Substring(3, 1);
                                        string y = Message_From_Server.Substring(4, 1);
                                        players[Player_ID].pos_x = int.Parse(x);
                                        players[Player_ID].pos_y = int.Parse(y);

                                    }
                                    break;
                                case "PO":
                                    {
                                        string Out_Player_ID = Message_From_Server.Substring(3, 1);
                                        int OPID = Convert.ToInt32(Out_Player_ID);
                                        if (Out_Player_ID == ID.ToString())
                                            MessageBox.Show("YOU ARE OUT");
                                        else
                                            MessageBox.Show("Player " + Out_Player_ID + " is OUT");
                                        players[Out_Player_ID].Visible = false;
                                        switch (OPID)
                                        {
                                            case 1:
                                                player1_null.Visible = true;
                                                break;
                                            case 2:
                                                player2_null.Visible = true;
                                                break;
                                            case 3:
                                                player3_null.Visible = true;
                                                break;
                                            case 4:
                                                player4_null.Visible = true;
                                                break;
                                        }
                                        players.Remove(Out_Player_ID);
                                    }
                                    break;
                                case "GE":
                                    {
                                        string Winner_ID = Message_From_Server.Substring(3, 1);
                                        if (Winner_ID == ID.ToString())
                                        {
                                            MessageBox.Show("You are the Winner");
                                            Close();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Player" + Winner_ID + " is WINNER");
                                            Close();
                                        }
                                    }
                                    break;
                            }
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error : " + ex.Message);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeleft > 0)
            {
                timeleft = timeleft - 1;
                LB_seconds.Text = timeleft.ToString();
            }
            else
            {
                timer1.Stop();
                LB_seconds.Text = "0";
            }
        }

        private void GameUI_Load(object sender, EventArgs e)
        {

        }
    }
}

