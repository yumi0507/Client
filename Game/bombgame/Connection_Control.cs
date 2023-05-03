using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
namespace bombgame
{
    public  class Connection_Control
    {
        public TcpClient Client;
        Connect connect;
        public Connection_Control(TcpClient tcpClient,Connect form)
        {
            connect = form;
            Client = tcpClient;
        }
        public Connection_Control(TcpClient tcp)
        {
            Client = tcp;
        }
        public void SenttoServer(string message)
        {
            NetworkStream networkStream = Client.GetStream();
            try
            {
                if (networkStream.CanWrite)
                {
                    byte[] data = Encoding.UTF8.GetBytes(message);
                    networkStream.Write(data);
                    //connect.ADD_TO_LOG(message);
                }
                else
                {
                    //connect.ADD_TO_LOG("Fail to send");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);   
            }
        }
    }
}
