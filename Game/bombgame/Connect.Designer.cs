namespace bombgame
{
    partial class Connect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connect));
            lbl_IPAddress = new Label();
            txbIPAddress = new TextBox();
            lbl_IPPort = new Label();
            tbx_PORT = new TextBox();
            btn_Connect = new Button();
            btn_GameStart = new Button();
            list_LOG = new ListBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbl_IPAddress
            // 
            lbl_IPAddress.AutoSize = true;
            lbl_IPAddress.Location = new Point(152, 320);
            lbl_IPAddress.Margin = new Padding(4, 0, 4, 0);
            lbl_IPAddress.Name = "lbl_IPAddress";
            lbl_IPAddress.Size = new Size(132, 30);
            lbl_IPAddress.TabIndex = 2;
            lbl_IPAddress.Text = "IP Address";
            // 
            // txbIPAddress
            // 
            txbIPAddress.Location = new Point(304, 316);
            txbIPAddress.Margin = new Padding(4);
            txbIPAddress.Name = "txbIPAddress";
            txbIPAddress.Size = new Size(224, 38);
            txbIPAddress.TabIndex = 3;
            // 
            // lbl_IPPort
            // 
            lbl_IPPort.AutoSize = true;
            lbl_IPPort.Location = new Point(198, 396);
            lbl_IPPort.Margin = new Padding(4, 0, 4, 0);
            lbl_IPPort.Name = "lbl_IPPort";
            lbl_IPPort.Size = new Size(87, 30);
            lbl_IPPort.TabIndex = 4;
            lbl_IPPort.Text = "IP Port";
            // 
            // tbx_PORT
            // 
            tbx_PORT.Location = new Point(304, 392);
            tbx_PORT.Margin = new Padding(4);
            tbx_PORT.Name = "tbx_PORT";
            tbx_PORT.Size = new Size(224, 38);
            tbx_PORT.TabIndex = 5;
            // 
            // btn_Connect
            // 
            btn_Connect.Location = new Point(620, 286);
            btn_Connect.Margin = new Padding(4);
            btn_Connect.Name = "btn_Connect";
            btn_Connect.Size = new Size(178, 64);
            btn_Connect.TabIndex = 6;
            btn_Connect.Text = "Connect";
            btn_Connect.UseVisualStyleBackColor = true;
            btn_Connect.Click += btn_Connect_Click;
            // 
            // btn_GameStart
            // 
            btn_GameStart.Enabled = false;
            btn_GameStart.Location = new Point(620, 382);
            btn_GameStart.Margin = new Padding(6);
            btn_GameStart.Name = "btn_GameStart";
            btn_GameStart.Size = new Size(178, 62);
            btn_GameStart.TabIndex = 7;
            btn_GameStart.Text = "Game Start";
            btn_GameStart.UseVisualStyleBackColor = true;
            btn_GameStart.Click += btn_GameStart_Click;
            // 
            // list_LOG
            // 
            list_LOG.FormattingEnabled = true;
            list_LOG.ItemHeight = 30;
            list_LOG.Location = new Point(24, 464);
            list_LOG.Margin = new Padding(6);
            list_LOG.Name = "list_LOG";
            list_LOG.Size = new Size(852, 184);
            list_LOG.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.BombGame1;
            pictureBox1.Location = new Point(198, 52);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(396, 256);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Connect
            // 
            AutoScaleDimensions = new SizeF(14F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 676);
            Controls.Add(pictureBox1);
            Controls.Add(list_LOG);
            Controls.Add(btn_GameStart);
            Controls.Add(btn_Connect);
            Controls.Add(tbx_PORT);
            Controls.Add(lbl_IPPort);
            Controls.Add(txbIPAddress);
            Controls.Add(lbl_IPAddress);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Connect";
            Text = "Connecting";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_IPAddress;
        private TextBox txbIPAddress;
        private Label lbl_IPPort;
        private TextBox tbx_PORT;
        private Button btn_Connect;
        private Button btn_GameStart;
        private ListBox list_LOG;
        private PictureBox pictureBox1;
    }
}