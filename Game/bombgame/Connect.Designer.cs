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
            lblIPAddress = new Label();
            txbIPAddress = new TextBox();
            lblIPPort = new Label();
            tbx_PORT = new TextBox();
            btnConnect = new Button();
            btn_GameStart = new Button();
            list_LOG = new ListBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblIPAddress
            // 
            lblIPAddress.AutoSize = true;
            lblIPAddress.Location = new Point(152, 320);
            lblIPAddress.Margin = new Padding(4, 0, 4, 0);
            lblIPAddress.Name = "lblIPAddress";
            lblIPAddress.Size = new Size(132, 30);
            lblIPAddress.TabIndex = 2;
            lblIPAddress.Text = "IP Address";
            // 
            // txbIPAddress
            // 
            txbIPAddress.Location = new Point(304, 316);
            txbIPAddress.Margin = new Padding(4, 4, 4, 4);
            txbIPAddress.Name = "txbIPAddress";
            txbIPAddress.Size = new Size(224, 38);
            txbIPAddress.TabIndex = 3;
            // 
            // lblIPPort
            // 
            lblIPPort.AutoSize = true;
            lblIPPort.Location = new Point(198, 396);
            lblIPPort.Margin = new Padding(4, 0, 4, 0);
            lblIPPort.Name = "lblIPPort";
            lblIPPort.Size = new Size(87, 30);
            lblIPPort.TabIndex = 4;
            lblIPPort.Text = "IP Port";
            // 
            // tbx_PORT
            // 
            tbx_PORT.Location = new Point(304, 392);
            tbx_PORT.Margin = new Padding(4, 4, 4, 4);
            tbx_PORT.Name = "tbx_PORT";
            tbx_PORT.Size = new Size(224, 38);
            tbx_PORT.TabIndex = 5;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(620, 286);
            btnConnect.Margin = new Padding(4, 4, 4, 4);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(178, 64);
            btnConnect.TabIndex = 6;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btn_GameStart
            // 
            btn_GameStart.Location = new Point(620, 382);
            btn_GameStart.Margin = new Padding(6, 6, 6, 6);
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
            list_LOG.Margin = new Padding(6, 6, 6, 6);
            list_LOG.Name = "list_LOG";
            list_LOG.Size = new Size(852, 184);
            list_LOG.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.BombGame1;
            pictureBox1.Location = new Point(328, 118);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 158);
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
            Controls.Add(btnConnect);
            Controls.Add(tbx_PORT);
            Controls.Add(lblIPPort);
            Controls.Add(txbIPAddress);
            Controls.Add(lblIPAddress);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 4, 4, 4);
            Name = "Connect";
            Text = "Connecting";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblIPAddress;
        private TextBox txbIPAddress;
        private Label lblIPPort;
        private TextBox tbx_PORT;
        private Button btnConnect;
        private Button btn_GameStart;
        private ListBox list_LOG;
        private PictureBox pictureBox1;
    }
}