using bombgame.Player;
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
        Connect connect;
        Dictionary<string,player> players;
        bool GameStart = false;
        this.Control.Add(new Bomb(0,0));
        this.Control.Add(new Explode(0,0));
        //player User;



        public GameUI(Connect form)
        {
            InitializeComponent();
            connect = form;
            round = 0;
            ID = connect.player.ID;
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

        public void GameLoop()
        {
            Round_Start();
        }
        private void Round_Start(object sender, EventArgs e)
        {
            round++;
            label1.Text = Round + round.ToString();
            timeleft = 30;
            label3.Text = "30";
            /* Timer 啟動 */
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
                                        players.Add(Player_ID,new player(Player_ID));
                                    }
                                    break;
                                case "PL":
                                    {
                                        string Player_ID = Message_From_Server.Substring(2, 1);
                                        string x = Message_From_Server.Substring(3,1);
                                        string y = Message_From_Server.Substring(4, 1);
                                        players[Player_ID].pos_x = int.Parse(x);
                                        players[Player_ID].pos_y = int.Parse(y);
                                        
                                    }
                                    break;
                                case "PO":
                                    {
                                        string Out_Player_ID = Message_From_Server.Substring(3, 1);
                                        if (Out_Player_ID == ID.ToString())
                                            MessageBox.Show("YOU ARE OUT");
                                        else
                                            MessageBox.Show("Player " + Out_Player_ID + " is OUT");
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
            if (num == ID) { return; }
            
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

