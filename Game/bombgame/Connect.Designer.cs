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
            lblName = new Label();
            lblIPAddress = new Label();
            txbIPAddress = new TextBox();
            lblIPPort = new Label();
            tbx_PORT = new TextBox();
            btnConnect = new Button();
            btn_GameStart = new Button();
            list_LOG = new ListBox();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(135, 87);
            lblName.Margin = new Padding(2, 0, 2, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(150, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Welcome to Bomb Game";
            // 
            // lblIPAddress
            // 
            lblIPAddress.AutoSize = true;
            lblIPAddress.Location = new Point(76, 160);
            lblIPAddress.Margin = new Padding(2, 0, 2, 0);
            lblIPAddress.Name = "lblIPAddress";
            lblIPAddress.Size = new Size(65, 15);
            lblIPAddress.TabIndex = 2;
            lblIPAddress.Text = "IP Address";
            // 
            // txbIPAddress
            // 
            txbIPAddress.Location = new Point(152, 158);
            txbIPAddress.Margin = new Padding(2);
            txbIPAddress.Name = "txbIPAddress";
            txbIPAddress.Size = new Size(114, 23);
            txbIPAddress.TabIndex = 3;
            // 
            // lblIPPort
            // 
            lblIPPort.AutoSize = true;
            lblIPPort.Location = new Point(99, 198);
            lblIPPort.Margin = new Padding(2, 0, 2, 0);
            lblIPPort.Name = "lblIPPort";
            lblIPPort.Size = new Size(43, 15);
            lblIPPort.TabIndex = 4;
            lblIPPort.Text = "IP Port";
            // 
            // tbx_PORT
            // 
            tbx_PORT.Location = new Point(152, 196);
            tbx_PORT.Margin = new Padding(2);
            tbx_PORT.Name = "tbx_PORT";
            tbx_PORT.Size = new Size(114, 23);
            tbx_PORT.TabIndex = 5;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(310, 143);
            btnConnect.Margin = new Padding(2);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(89, 32);
            btnConnect.TabIndex = 6;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btn_GameStart
            // 
            btn_GameStart.Location = new Point(310, 191);
            btn_GameStart.Name = "btn_GameStart";
            btn_GameStart.Size = new Size(89, 31);
            btn_GameStart.TabIndex = 7;
            btn_GameStart.Text = "Game Start";
            btn_GameStart.UseVisualStyleBackColor = true;
            btn_GameStart.Click += btn_GameStart_Click;
            // 
            // list_LOG
            // 
            list_LOG.FormattingEnabled = true;
            list_LOG.ItemHeight = 15;
            list_LOG.Location = new Point(12, 232);
            list_LOG.Name = "list_LOG";
            list_LOG.Size = new Size(428, 94);
            list_LOG.TabIndex = 8;
            // 
            // Connect
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 338);
            Controls.Add(list_LOG);
            Controls.Add(btn_GameStart);
            Controls.Add(btnConnect);
            Controls.Add(tbx_PORT);
            Controls.Add(lblIPPort);
            Controls.Add(txbIPAddress);
            Controls.Add(lblIPAddress);
            Controls.Add(lblName);
            Margin = new Padding(2);
            Name = "Connect";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblName;
        private Label lblIPAddress;
        private TextBox txbIPAddress;
        private Label lblIPPort;
        private TextBox tbx_PORT;
        private Button btnConnect;
        private Button btn_GameStart;
        private ListBox list_LOG;
    }
}