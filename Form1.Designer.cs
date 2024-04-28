namespace Pokemon_API
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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(281, 21);
            button1.Name = "button1";
            button1.Size = new Size(96, 23);
            button1.TabIndex = 0;
            button1.Text = "Get Pokemon";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(162, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(125, 70);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(542, 23);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 73);
            label1.Name = "label1";
            label1.Size = new Size(92, 15);
            label1.TabIndex = 3;
            label1.Text = "Base Happiness:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 113);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 4;
            label2.Text = "Capture Rate:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 153);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 5;
            label3.Text = "Habitat:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(125, 110);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(542, 23);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(125, 150);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(542, 23);
            textBox4.TabIndex = 7;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 194);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 8;
            label4.Text = "Growth Rate:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 238);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 9;
            label5.Text = "Egg Group:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 284);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 10;
            label6.Text = "Flavor Text:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(125, 194);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(542, 23);
            textBox5.TabIndex = 11;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(125, 235);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(542, 23);
            textBox6.TabIndex = 12;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(125, 281);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(542, 23);
            textBox7.TabIndex = 13;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 25);
            label7.Name = "label7";
            label7.Size = new Size(135, 15);
            label7.TabIndex = 14;
            label7.Text = "Enter a Pokemon Name:";
            label7.Click += label7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 336);
            Controls.Add(label7);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label7;
    }
}
