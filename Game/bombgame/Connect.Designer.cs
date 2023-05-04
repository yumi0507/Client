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
            this.lblIPAddress = new System.Windows.Forms.Label();
            this.txbIPAddress = new System.Windows.Forms.TextBox();
            this.lblIPPort = new System.Windows.Forms.Label();
            this.tbx_PORT = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btn_GameStart = new System.Windows.Forms.Button();
            this.list_LOG = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.AutoSize = true;
            this.lblIPAddress.Location = new System.Drawing.Point(76, 160);
            this.lblIPAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Size = new System.Drawing.Size(65, 15);
            this.lblIPAddress.TabIndex = 2;
            this.lblIPAddress.Text = "IP Address";
            // 
            // txbIPAddress
            // 
            this.txbIPAddress.Location = new System.Drawing.Point(152, 158);
            this.txbIPAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txbIPAddress.Name = "txbIPAddress";
            this.txbIPAddress.Size = new System.Drawing.Size(114, 23);
            this.txbIPAddress.TabIndex = 3;
            // 
            // lblIPPort
            // 
            this.lblIPPort.AutoSize = true;
            this.lblIPPort.Location = new System.Drawing.Point(99, 198);
            this.lblIPPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIPPort.Name = "lblIPPort";
            this.lblIPPort.Size = new System.Drawing.Size(43, 15);
            this.lblIPPort.TabIndex = 4;
            this.lblIPPort.Text = "IP Port";
            // 
            // tbx_PORT
            // 
            this.tbx_PORT.Location = new System.Drawing.Point(152, 196);
            this.tbx_PORT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbx_PORT.Name = "tbx_PORT";
            this.tbx_PORT.Size = new System.Drawing.Size(114, 23);
            this.tbx_PORT.TabIndex = 5;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(310, 143);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(89, 32);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // btn_GameStart
            // 
            this.btn_GameStart.Location = new System.Drawing.Point(310, 191);
            this.btn_GameStart.Name = "btn_GameStart";
            this.btn_GameStart.Size = new System.Drawing.Size(89, 31);
            this.btn_GameStart.TabIndex = 7;
            this.btn_GameStart.Text = "Game Start";
            this.btn_GameStart.UseVisualStyleBackColor = true;
            // 
            // list_LOG
            // 
            this.list_LOG.FormattingEnabled = true;
            this.list_LOG.ItemHeight = 15;
            this.list_LOG.Location = new System.Drawing.Point(12, 232);
            this.list_LOG.Name = "list_LOG";
            this.list_LOG.Size = new System.Drawing.Size(428, 94);
            this.list_LOG.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::bombgame.Properties.Resources.BombGame1;
            this.pictureBox1.Location = new System.Drawing.Point(99, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 128);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Connect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 338);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.list_LOG);
            this.Controls.Add(this.btn_GameStart);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tbx_PORT);
            this.Controls.Add(this.lblIPPort);
            this.Controls.Add(this.txbIPAddress);
            this.Controls.Add(this.lblIPAddress);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Connect";
            this.Text = "Connecting";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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