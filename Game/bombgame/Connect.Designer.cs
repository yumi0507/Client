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
            txbName = new TextBox();
            lblName = new Label();
            lblIPAddress = new Label();
            txbIPAddress = new TextBox();
            lblIPPort = new Label();
            textBox3 = new TextBox();
            btnConnect = new Button();
            SuspendLayout();
            // 
            // txbName
            // 
            txbName.Location = new Point(304, 210);
            txbName.Margin = new Padding(4);
            txbName.Name = "txbName";
            txbName.Size = new Size(224, 38);
            txbName.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(340, 164);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(155, 30);
            lblName.TabIndex = 1;
            lblName.Text = "Player Name";
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
            txbIPAddress.Margin = new Padding(4);
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
            // textBox3
            // 
            textBox3.Location = new Point(304, 392);
            textBox3.Margin = new Padding(4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(224, 38);
            textBox3.TabIndex = 5;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(600, 360);
            btnConnect.Margin = new Padding(4);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(150, 46);
            btnConnect.TabIndex = 6;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // Connect
            // 
            AutoScaleDimensions = new SizeF(14F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 676);
            Controls.Add(btnConnect);
            Controls.Add(textBox3);
            Controls.Add(lblIPPort);
            Controls.Add(txbIPAddress);
            Controls.Add(lblIPAddress);
            Controls.Add(lblName);
            Controls.Add(txbName);
            Margin = new Padding(4);
            Name = "Connect";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbName;
        private Label lblName;
        private Label lblIPAddress;
        private TextBox txbIPAddress;
        private Label lblIPPort;
        private TextBox textBox3;
        private Button btnConnect;
    }
}