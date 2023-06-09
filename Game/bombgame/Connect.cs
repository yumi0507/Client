﻿using System;
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
        public List<string> message_from_server;
        public Connect()
        {
            InitializeComponent();
            tcpClient = new TcpClient();
            message_from_server = new List<string>() ;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            tcpClient.Connect(IPAddress.Parse(txbIPAddress.Text), int.Parse(tbx_PORT.Text));
            if (tcpClient.Connected)
            {
                ADD_TO_LOG("Connected to the Server");
                connect = new Connection_Control(tcpClient,this);
                player = new player(ReceiveFromServer(tcpClient),tcpClient);
                Thread thread = new Thread(ClientHandle);
                thread.IsBackground = true;
                thread.Start(tcpClient);
            }
            else
            {
                ADD_TO_LOG("Fail to Connect");
            }

        }
        public void ReceiveFromServer(TcpClient client)
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
                    }
                    else
                    {
                        Message_From_Server = Encoding.UTF8.GetString(buffer, 0, bytes);
                        ADD_TO_LOG("Receive '" + Message_From_Server + "' from server ");
                        message_from_server.Add(Message_From_Server);
                    }
                }
            }
            catch (Exception ex)
            {
                ADD_TO_LOG(ex.Message);
            }
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
        private void btn_GameStart_Click(object sender, EventArgs e)
        {
            GameUI gameUI = new GameUI(this);
            gameUI.Show();
            //this.Close();
        }
    }
}
