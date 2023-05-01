using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bombgame.Player;

namespace bombgame
{
    public partial class Connect : Form
    {
        private Socket ClientSocket;

        public Connect()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

        }

        public void CloseSocket()
        {
            ClientSocket.Close();
        }
    }
}
