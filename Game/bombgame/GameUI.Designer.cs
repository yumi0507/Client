using System.Windows.Forms;

namespace bombgame
{
    partial class GameUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameUI));
            player1_sculpture = new PictureBox();
            player4_sculpture = new PictureBox();
            player3_sculpture = new PictureBox();
            player2_sculpture = new PictureBox();
            LB_round = new Label();
            LB_Player01 = new Label();
            LB_Player02 = new Label();
            LB_Player03 = new Label();
            LB_Player04 = new Label();
            LB_Remaining_Bombs = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            LB_seconds = new Label();
            LB_remaining = new Label();
            player1_null = new PictureBox();
            timer = new PictureBox();
            player4_null = new PictureBox();
            player3_null = new PictureBox();
            player2_null = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)player1_sculpture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player4_sculpture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player3_sculpture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player2_sculpture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player1_null).BeginInit();
            ((System.ComponentModel.ISupportInitialize)timer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player4_null).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player3_null).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player2_null).BeginInit();
            SuspendLayout();
            // 
            // player1_sculpture
            // 
            player1_sculpture.BackColor = Color.Transparent;
            player1_sculpture.Image = (Image)resources.GetObject("player1_sculpture.Image");
            player1_sculpture.Location = new Point(1120, 416);
            player1_sculpture.Margin = new Padding(6);
            player1_sculpture.Name = "player1_sculpture";
            player1_sculpture.Size = new Size(182, 178);
            player1_sculpture.SizeMode = PictureBoxSizeMode.StretchImage;
            player1_sculpture.TabIndex = 69;
            player1_sculpture.TabStop = false;
            // 
            // player4_sculpture
            // 
            player4_sculpture.BackColor = Color.Transparent;
            player4_sculpture.Image = (Image)resources.GetObject("player4_sculpture.Image");
            player4_sculpture.Location = new Point(1314, 670);
            player4_sculpture.Margin = new Padding(6);
            player4_sculpture.Name = "player4_sculpture";
            player4_sculpture.Size = new Size(182, 178);
            player4_sculpture.SizeMode = PictureBoxSizeMode.StretchImage;
            player4_sculpture.TabIndex = 70;
            player4_sculpture.TabStop = false;
            // 
            // player3_sculpture
            // 
            player3_sculpture.BackColor = Color.Transparent;
            player3_sculpture.Image = (Image)resources.GetObject("player3_sculpture.Image");
            player3_sculpture.Location = new Point(1120, 670);
            player3_sculpture.Margin = new Padding(6);
            player3_sculpture.Name = "player3_sculpture";
            player3_sculpture.Size = new Size(182, 178);
            player3_sculpture.SizeMode = PictureBoxSizeMode.StretchImage;
            player3_sculpture.TabIndex = 71;
            player3_sculpture.TabStop = false;
            // 
            // player2_sculpture
            // 
            player2_sculpture.BackColor = Color.Transparent;
            player2_sculpture.Image = (Image)resources.GetObject("player2_sculpture.Image");
            player2_sculpture.Location = new Point(1314, 416);
            player2_sculpture.Margin = new Padding(6);
            player2_sculpture.Name = "player2_sculpture";
            player2_sculpture.Size = new Size(182, 178);
            player2_sculpture.SizeMode = PictureBoxSizeMode.StretchImage;
            player2_sculpture.TabIndex = 72;
            player2_sculpture.TabStop = false;
            // 
            // LB_round
            // 
            LB_round.BackColor = Color.Transparent;
            LB_round.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LB_round.Location = new Point(1284, 26);
            LB_round.Margin = new Padding(6, 0, 6, 0);
            LB_round.Name = "LB_round";
            LB_round.Size = new Size(256, 62);
            LB_round.TabIndex = 63;
            LB_round.Text = "Round 01";
            // 
            // LB_Player01
            // 
            LB_Player01.AutoSize = true;
            LB_Player01.BackColor = Color.Transparent;
            LB_Player01.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LB_Player01.Location = new Point(1130, 600);
            LB_Player01.Margin = new Padding(6, 0, 6, 0);
            LB_Player01.Name = "LB_Player01";
            LB_Player01.Size = new Size(158, 36);
            LB_Player01.TabIndex = 76;
            LB_Player01.Text = "Player01";
            // 
            // LB_Player02
            // 
            LB_Player02.AutoSize = true;
            LB_Player02.BackColor = Color.Transparent;
            LB_Player02.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LB_Player02.Location = new Point(1326, 600);
            LB_Player02.Margin = new Padding(6, 0, 6, 0);
            LB_Player02.Name = "LB_Player02";
            LB_Player02.Size = new Size(158, 36);
            LB_Player02.TabIndex = 79;
            LB_Player02.Text = "Player02";
            // 
            // LB_Player03
            // 
            LB_Player03.AutoSize = true;
            LB_Player03.BackColor = Color.Transparent;
            LB_Player03.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LB_Player03.Location = new Point(1130, 854);
            LB_Player03.Margin = new Padding(6, 0, 6, 0);
            LB_Player03.Name = "LB_Player03";
            LB_Player03.Size = new Size(158, 36);
            LB_Player03.TabIndex = 78;
            LB_Player03.Text = "Player03";
            // 
            // LB_Player04
            // 
            LB_Player04.AutoSize = true;
            LB_Player04.BackColor = Color.Transparent;
            LB_Player04.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LB_Player04.Location = new Point(1326, 860);
            LB_Player04.Margin = new Padding(6, 0, 6, 0);
            LB_Player04.Name = "LB_Player04";
            LB_Player04.Size = new Size(158, 36);
            LB_Player04.TabIndex = 77;
            LB_Player04.Text = "Player04";
            // 
            // LB_Remaining_Bombs
            // 
            LB_Remaining_Bombs.BackColor = Color.Transparent;
            LB_Remaining_Bombs.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LB_Remaining_Bombs.Location = new Point(1102, 282);
            LB_Remaining_Bombs.Margin = new Padding(6, 0, 6, 0);
            LB_Remaining_Bombs.Name = "LB_Remaining_Bombs";
            LB_Remaining_Bombs.Size = new Size(262, 86);
            LB_Remaining_Bombs.TabIndex = 80;
            LB_Remaining_Bombs.Text = "Remaining \r\nBombs";
            LB_Remaining_Bombs.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            // 
            // LB_seconds
            // 
            LB_seconds.AutoSize = true;
            LB_seconds.BackColor = Color.Transparent;
            LB_seconds.Font = new Font("Cooper Black", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            LB_seconds.Location = new Point(1344, 144);
            LB_seconds.Margin = new Padding(6, 0, 6, 0);
            LB_seconds.Name = "LB_seconds";
            LB_seconds.Size = new Size(125, 85);
            LB_seconds.TabIndex = 85;
            LB_seconds.Text = "30";
            // 
            // LB_remaining
            // 
            LB_remaining.AutoSize = true;
            LB_remaining.BackColor = Color.Transparent;
            LB_remaining.Font = new Font("Cooper Black", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            LB_remaining.Location = new Point(1368, 278);
            LB_remaining.Margin = new Padding(6, 0, 6, 0);
            LB_remaining.Name = "LB_remaining";
            LB_remaining.Size = new Size(81, 85);
            LB_remaining.TabIndex = 86;
            LB_remaining.Text = "4";
            // 
            // player1_null
            // 
            player1_null.BackColor = Color.Transparent;
            player1_null.Image = (Image)resources.GetObject("player1_null.Image");
            player1_null.Location = new Point(1150, 446);
            player1_null.Margin = new Padding(6);
            player1_null.Name = "player1_null";
            player1_null.Size = new Size(124, 122);
            player1_null.SizeMode = PictureBoxSizeMode.StretchImage;
            player1_null.TabIndex = 97;
            player1_null.TabStop = false;
            player1_null.Visible = false;
            // 
            // timer
            // 
            timer.BackColor = Color.Transparent;
            timer.Image = (Image)resources.GetObject("timer.Image");
            timer.Location = new Point(1140, 94);
            timer.Margin = new Padding(6);
            timer.Name = "timer";
            timer.Size = new Size(170, 168);
            timer.SizeMode = PictureBoxSizeMode.Zoom;
            timer.TabIndex = 174;
            timer.TabStop = false;
            // 
            // player4_null
            // 
            player4_null.BackColor = Color.Transparent;
            player4_null.Image = (Image)resources.GetObject("player4_null.Image");
            player4_null.Location = new Point(1344, 700);
            player4_null.Margin = new Padding(6);
            player4_null.Name = "player4_null";
            player4_null.Size = new Size(124, 122);
            player4_null.SizeMode = PictureBoxSizeMode.StretchImage;
            player4_null.TabIndex = 175;
            player4_null.TabStop = false;
            player4_null.Visible = false;
            // 
            // player3_null
            // 
            player3_null.BackColor = Color.Transparent;
            player3_null.Image = (Image)resources.GetObject("player3_null.Image");
            player3_null.Location = new Point(1150, 700);
            player3_null.Margin = new Padding(6);
            player3_null.Name = "player3_null";
            player3_null.Size = new Size(124, 122);
            player3_null.SizeMode = PictureBoxSizeMode.StretchImage;
            player3_null.TabIndex = 176;
            player3_null.TabStop = false;
            player3_null.Visible = false;
            // 
            // player2_null
            // 
            player2_null.BackColor = Color.Transparent;
            player2_null.Image = (Image)resources.GetObject("player2_null.Image");
            player2_null.Location = new Point(1344, 446);
            player2_null.Margin = new Padding(6);
            player2_null.Name = "player2_null";
            player2_null.Size = new Size(124, 122);
            player2_null.SizeMode = PictureBoxSizeMode.StretchImage;
            player2_null.TabIndex = 177;
            player2_null.TabStop = false;
            player2_null.Visible = false;
            // 
            // GameUI
            // 
            AutoScaleDimensions = new SizeF(14F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1564, 1052);
            Controls.Add(player2_null);
            Controls.Add(player3_null);
            Controls.Add(player4_null);
            Controls.Add(LB_seconds);
            Controls.Add(timer);
            Controls.Add(player1_null);
            Controls.Add(LB_Player04);
            Controls.Add(LB_remaining);
            Controls.Add(LB_Remaining_Bombs);
            Controls.Add(LB_Player02);
            Controls.Add(LB_Player03);
            Controls.Add(LB_Player01);
            Controls.Add(player2_sculpture);
            Controls.Add(player3_sculpture);
            Controls.Add(player4_sculpture);
            Controls.Add(player1_sculpture);
            Controls.Add(LB_round);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            Name = "GameUI";
            Text = "Bomb Game";
            Load += GameUI_Load;
            ((System.ComponentModel.ISupportInitialize)player1_sculpture).EndInit();
            ((System.ComponentModel.ISupportInitialize)player4_sculpture).EndInit();
            ((System.ComponentModel.ISupportInitialize)player3_sculpture).EndInit();
            ((System.ComponentModel.ISupportInitialize)player2_sculpture).EndInit();
            ((System.ComponentModel.ISupportInitialize)player1_null).EndInit();
            ((System.ComponentModel.ISupportInitialize)timer).EndInit();
            ((System.ComponentModel.ISupportInitialize)player4_null).EndInit();
            ((System.ComponentModel.ISupportInitialize)player3_null).EndInit();
            ((System.ComponentModel.ISupportInitialize)player2_null).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox player1_sculpture;
        private PictureBox player2_sculpture;
        private PictureBox player3_sculpture;
        private PictureBox player4_sculpture;
        private Label LB_round;
        private Label LB_seconds;
        private Label LB_Remaining_Bombs;
        private Label LB_remaining;
        private Label LB_Player01;
        private Label LB_Player02;
        private Label LB_Player03;
        private Label LB_Player04;
        private PictureBox player1_null;
        private PictureBox player2_null;
        private PictureBox player3_null;
        private PictureBox player4_null;
        private PictureBox timer;
        private System.Windows.Forms.Timer timer1;
    }

}