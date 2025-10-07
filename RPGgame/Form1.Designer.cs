namespace RPGgame
{
    partial class Form1
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
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            button1 = new Button();
            listBox1 = new ListBox();
            label2 = new Label();
            label9 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 42);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 0;
            label3.Text = "EXP:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 66);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 0;
            label4.Text = "Level:";
            label4.Click += label4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(57, 17);
            label6.Name = "label6";
            label6.Size = new Size(13, 15);
            label6.TabIndex = 0;
            label6.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(57, 42);
            label7.Name = "label7";
            label7.Size = new Size(13, 15);
            label7.TabIndex = 0;
            label7.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(57, 66);
            label8.Name = "label8";
            label8.Size = new Size(13, 15);
            label8.TabIndex = 0;
            label8.Text = "0";
            label8.Click += label4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 50F);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(311, 261);
            button1.Name = "button1";
            button1.Size = new Size(242, 125);
            button1.TabIndex = 1;
            button1.Text = "Roll";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.LightSkyBlue;
            listBox1.Cursor = Cursors.Cross;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(765, 70);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(221, 424);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 17);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 0;
            label2.Text = "Gold:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(830, 32);
            label9.Name = "label9";
            label9.Size = new Size(66, 15);
            label9.TabIndex = 3;
            label9.Text = "Your Items:";
            // 
            // button2
            // 
            button2.BackColor = Color.DarkRed;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 45F);
            button2.Location = new Point(765, 500);
            button2.Name = "button2";
            button2.Size = new Size(221, 89);
            button2.TabIndex = 4;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Segoe UI", 45F);
            button3.Location = new Point(311, 413);
            button3.Name = "button3";
            button3.Size = new Size(242, 90);
            button3.TabIndex = 5;
            button3.Text = "Rebirth";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Segoe UI", 20F);
            button4.Location = new Point(48, 413);
            button4.Name = "button4";
            button4.Size = new Size(148, 81);
            button4.TabIndex = 6;
            button4.Text = "The Shop";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(278, 526);
            label1.Name = "label1";
            label1.Size = new Size(305, 15);
            label1.TabIndex = 7;
            label1.Text = "You need more than 15000 EXP and  2000 gold to rebirth.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(1076, 613);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label9);
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label2);
            Name = "Form1";
            Text = "wwww";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button button1;
        private ListBox listBox1;
        private Label label2;
        private Label label9;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
    }
}
