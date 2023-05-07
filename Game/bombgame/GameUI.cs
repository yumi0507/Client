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
using System.Timers;

namespace bombgame
{
    public partial class GameUI : Form
    {
        int countdown;
        int timeleft;
        int round;
        int ID;
        string Round = "Round ";
        string user;
        Connect connect;
        Dictionary<string, player> players;
        List<Explode> explodes;
        bool GameStart = false;
        System.Timers.Timer Countdown;


        public GameUI(Connect form)
        {
            InitializeComponent();
            player1_null.Visible = true;
            player2_null.Visible = true;
            player3_null.Visible = true;
            player4_null.Visible = true;
            connect = form;
            round = 0;
            ID = connect.player.ID;
            user = ID.ToString();
            players = new Dictionary<string, player>();
            players.Add(connect.player.ID.ToString(), connect.player);
            show_player(ID);
            explodes = new List<Explode>();
            Countdown = new System.Timers.Timer();
            Countdown.Interval = 1000;

            Thread thread = new Thread(ClientHandled_For_Game);
            thread.IsBackground = true;
            thread.Start(connect.tcpClient);
            //players[user].connect.SenttoServer("OP");

            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.KeyPreview = true;

        }

        private void GameUI_KeyDown(object sender, KeyEventArgs e)
        {

            while (GameStart)
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
                            MessageBox.Show("Can't read");
                        }
                        else
                        {
                            string Message_From_Server = Encoding.UTF8.GetString(buffer, 0, BytesReaded);
                            connect.ADD_TO_LOG(Message_From_Server);
                            string Command = Message_From_Server.Substring(0, 2);
                            switch (Command)
                            {
                                case "GS":
                                    {
                                        if (players.Count > 2)
                                        {
                                            if (players.Count == 4)
                                                Invoke(new MethodInvoker(() => { player4_null.Visible = true; }));
                                            Invoke(new MethodInvoker(() => { player3_null.Visible = true; }));
                                        }
                                        GameStart = true;
                                        string str = Message_From_Server.Substring(2, 1);
                                        round = Convert.ToInt32(str);
                                        Invoke(new MethodInvoker(() => { LB_round.Text = Round + round.ToString(); }));
                                        countdown = 3;
                                        Invoke(new MethodInvoker(() => { LB_countdown.Text = "3"; }));
                                        Countdown.Start();
                                    }
                                    break;
                                case "NP":
                                    {
                                        string NewPlayerID = Message_From_Server.Substring(2, 1);
                                        try
                                        {
                                            players.Add(NewPlayerID, new player(NewPlayerID));
                                        }
                                        catch(Exception e)
                                        {
                                            MessageBox.Show(e.Message);
                                        }
                                        show_player(int.Parse(NewPlayerID));
                                    }
                                    break;
                                case "PP":
                                    {
                                        string Player_ID = Message_From_Server.Substring(2, 1);
                                        string X = Message_From_Server.Substring(3, 1);
                                        string Y = Message_From_Server.Substring(4, 1);
                                        int x = Convert.ToInt32(X);
                                        int y = Convert.ToInt32(Y);
                                        players[Player_ID].GameSet(x, y);
                                    }
                                    break;
                                case "BS":
                                    {
                                        string x = Message_From_Server.Substring(2, 1);
                                        string y = Message_From_Server.Substring(3, 1);
                                        explodes.Add(new Explode(Convert.ToInt32(x), Convert.ToInt32(y)));
                                    }
                                    break;
                                case "PL":
                                    {
                                        string Alive = Message_From_Server.Substring(2, 1);
                                        string Player_ID = Message_From_Server.Substring(3, 1);
                                        string x = Message_From_Server.Substring(4, 1);
                                        string y = Message_From_Server.Substring(5, 1);
                                        players[Player_ID].pos_x = int.Parse(x);
                                        players[Player_ID].pos_y = int.Parse(y);

                                        if (Alive == "D")
                                        {
                                            int Out_Player_ID = Convert.ToInt32(Player_ID);
                                            if (Out_Player_ID == ID)
                                                MessageBox.Show("YOU ARE OUT");
                                            else
                                                MessageBox.Show("Player " + Out_Player_ID + " is OUT");
                                            players[Player_ID].Visible = false;
                                            switch (Out_Player_ID)
                                            {
                                                case 1:
                                                    Invoke(new MethodInvoker(() => { player1_null.Visible = true; }));
                                                    break;
                                                case 2:
                                                    Invoke(new MethodInvoker(() => { player2_null.Visible = true; }));
                                                    break;
                                                case 3:
                                                    Invoke(new MethodInvoker(() => { player3_null.Visible = true; }));
                                                    break;
                                                case 4:
                                                    Invoke(new MethodInvoker(() => { player4_null.Visible = true; }));
                                                    break;
                                            }
                                            players.Remove(Player_ID);

                                        }

                                    }
                                    break;
                                case "ER":
                                    {
                                        Round_End();
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
                                        else if (Winner_ID == "N")
                                        {
                                            MessageBox.Show("No one won the game.");
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

        #region timer1_set
        /*
        private void timer1_Set(object sender, EventArgs e)
        {
            round++;
            LB_round.Text = Round + round.ToString();
            timeleft = 30;
            LB_seconds.Text = "30";
            timer1.Start();
        }
        */
        #endregion

        private void time_Tick(object sender, EventArgs e)
        {
            if (countdown > 0)
            {
                countdown -= 1;
                LB_countdown.Text = countdown.ToString();

            }
            else
            {
                Countdown.Stop();
                Invoke(new MethodInvoker(() => { LB_countdown.Text = "0"; }));
                Invoke(new MethodInvoker(() => { LB_countdown.Visible = false; }));
                timeleft = 30;
                Invoke(new MethodInvoker(() => { LB_seconds.Text = "30"; }));
                timer1.Start();
            }

            Refresh();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeleft > 0)
            {
                timeleft -= 1;
                LB_seconds.Text = timeleft.ToString();
            }
            else
            {
                timer1.Stop();
                Invoke(new MethodInvoker(() => { LB_seconds.Text = "0"; }));
                GameStart = false;
            }

            Refresh();
        }
        public void show_player(int i)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<int>(show_player), i);
                return;
            }
            if (i == 1)
                player1_null.Visible =  false ;
            else if(i == 2)
                player2_null.Visible = false ;
            else if(i == 3)
            {
                player3_null.Visible = false ;
            }
            else
            {
                player4_null.Visible = false ;
            }
        }
        public void notshow_player(int i)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<int>(notshow_player), i);
                return;
            }
            if (i == 1)
                player1_null.Visible = true;
            else if (i == 2)
                player2_null.Visible = true;
            else if (i == 3)
            {
                player3_null.Visible = true;
            }
            else
            {
                player4_null.Visible = true;
            }
        }
        private void Round_End()
        {
            foreach (Explode explode in explodes)
            {
                Invoke(new MethodInvoker(() => { explode.Invalidate(); }));
            }
            explodes.Clear();
            players[ID.ToString()].ClearBomb();
        }


    }
}

