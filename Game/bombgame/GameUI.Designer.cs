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
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            label4 = new Label();
            pictureBox83 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox83).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cooper Black", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(637, 9);
            label1.Name = "label1";
            label1.Size = new Size(153, 31);
            label1.TabIndex = 63;
            label1.Text = "Round 01";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(565, 300);
            label5.Name = "label5";
            label5.Size = new Size(82, 19);
            label5.TabIndex = 76;
            label5.Text = "Player01";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(663, 427);
            label6.Name = "label6";
            label6.Size = new Size(82, 19);
            label6.TabIndex = 77;
            label6.Text = "Player04";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(565, 427);
            label7.Name = "label7";
            label7.Size = new Size(82, 19);
            label7.TabIndex = 78;
            label7.Text = "Player03";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(663, 300);
            label8.Name = "label8";
            label8.Size = new Size(82, 19);
            label8.TabIndex = 79;
            label8.Text = "Player02";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(551, 141);
            label2.Name = "label2";
            label2.Size = new Size(131, 43);
            label2.TabIndex = 80;
            label2.Text = "Remaining \r\nBombs";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Cooper Black", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(672, 72);
            label3.Name = "label3";
            label3.Size = new Size(62, 42);
            label3.TabIndex = 85;
            label3.Text = "30";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Cooper Black", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(684, 139);
            label4.Name = "label4";
            label4.Size = new Size(40, 42);
            label4.TabIndex = 86;
            label4.Text = "4";
            // 
            // pictureBox83
            // 
            pictureBox83.BackColor = Color.Transparent;
            pictureBox83.Image = (Image)resources.GetObject("pictureBox83.Image");
            pictureBox83.Location = new Point(570, 47);
            pictureBox83.Name = "pictureBox83";
            pictureBox83.Size = new Size(85, 84);
            pictureBox83.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox83.TabIndex = 174;
            pictureBox83.TabStop = false;
            // 
            // GameUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(782, 526);
            Controls.Add(label3);
            Controls.Add(pictureBox83);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "GameUI";
            Text = "Form1";
            Load += GameUI_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox83).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox83;
    }

}