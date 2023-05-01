namespace bombgame
{
    partial class Form2
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(303, 210);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(223, 38);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(339, 164);
            label1.Name = "label1";
            label1.Size = new Size(155, 30);
            label1.TabIndex = 1;
            label1.Text = "Player Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 320);
            label2.Name = "label2";
            label2.Size = new Size(132, 30);
            label2.TabIndex = 2;
            label2.Text = "IP Address";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(303, 317);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(223, 38);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(198, 395);
            label3.Name = "label3";
            label3.Size = new Size(87, 30);
            label3.TabIndex = 4;
            label3.Text = "IP Port";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(303, 392);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(223, 38);
            textBox3.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(600, 359);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 6;
            button1.Text = "Connect";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(14F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 677);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Button button1;
    }
}