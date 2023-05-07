using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bombgame.Player;

namespace bombgame
{
    public partial class Connect : Form
    {
        public TcpClient tcpClient;
        public Connection_Control connect;
        public player player;
        public bool Start_From_Server = false;
        Thread ClientHandler;
        public Connect()
        {
            InitializeComponent();
            tcpClient = new TcpClient();
            txbIPAddress.Text = "";
            tbx_PORT.Text = "10000";
        }

        public string ReceiveFromServer(TcpClient client)
        {
            NetworkStream networkStream = client.GetStream();
            string Message_From_Server;
            byte[] buffer = new byte[2048];
            try
            {
                if (networkStream.CanRead)
                {
                    int bytes = networkStream.Read(buffer);
                    if (bytes <= 0)
                    {
                        ADD_TO_LOG("Fail to Receive");
                        return "F";
                    }
                    else
                    {
                        Message_From_Server = Encoding.UTF8.GetString(buffer, 0, bytes);
                        ADD_TO_LOG("Receive '" + Message_From_Server + "' from server ");
                        return (Message_From_Server);
                    }
                }
            }
            catch (Exception ex)
            {
                ADD_TO_LOG(ex.Message);
                return "F";
            }
            return "F";
        }

        public void ADD_TO_LOG(string message)
        {
            if (list_LOG.InvokeRequired)
            {
                list_LOG.Invoke((MethodInvoker)(() => list_LOG.Items.Add(message)));
            }
            else
            {
                list_LOG.Items.Add(message);
            }
        }

        private void ClientHandle(object clientobj)
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
                            ADD_TO_LOG("Fail to Read");
                        }
                        else
                        {
                            string Message_From_Server = Encoding.UTF8.GetString(buffer, 0, BytesReaded);
                            ADD_TO_LOG(Message_From_Server);
                            //ADD_to_LOG("Receive '" + Message_From_Server + "' Form Server");
                        }
                    }

                }
                catch (Exception ex)
                {
                    ADD_TO_LOG("Error : " + ex.Message);
                }
            }
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            tcpClient.Connect(IPAddress.Parse(txbIPAddress.Text), int.Parse(tbx_PORT.Text));
            if (tcpClient.Connected)
            {
                ADD_TO_LOG("Connected to the Server");
                connect = new Connection_Control(tcpClient, this);
                string ID = ReceiveFromServer(tcpClient).Substring(2, 1);
                player = new player(ID, tcpClient);
                ClientHandler = new Thread(ClientHandle);
                ClientHandler.IsBackground = true;
                ClientHandler.Start(tcpClient);
                Invoke(new MethodInvoker(() => { btn_GameStart.Enabled = true; }));
                Invoke(new MethodInvoker(() => { btn_Connect.Enabled = false; }));
            }
            else
            {
                ADD_TO_LOG("Fail to Connect");
            }
        }

        private void btn_GameStart_Click(object sender, EventArgs e)
        {
            GameUI gameUI = new GameUI(this);
            connect.SenttoServer("OP");
            gameUI.Show();
            ClientHandler = null;
            Invoke(new MethodInvoker(() => { btn_GameStart.Enabled = false; }));
        }

    }
}
