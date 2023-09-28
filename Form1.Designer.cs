namespace WinHomeTaskPattern3
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
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox6 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(29, 225);
            button1.Name = "button1";
            button1.Size = new Size(124, 32);
            button1.TabIndex = 0;
            button1.Text = "Створити";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(176, 225);
            button2.Name = "button2";
            button2.Size = new Size(124, 32);
            button2.TabIndex = 1;
            button2.Text = "Вивести";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(28, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(28, 58);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(28, 91);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(28, 124);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(28, 157);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(160, 25);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 7;
            label1.Text = "- модель пк";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(160, 58);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 8;
            label2.Text = "- процесор";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(159, 91);
            label3.Name = "label3";
            label3.Size = new Size(203, 20);
            label3.TabIndex = 9;
            label3.Text = "- об'єм оперативної пам'яті";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(159, 124);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 10;
            label4.Text = "- об'єм пам'яті";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(159, 157);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 11;
            label5.Text = "- відеокарта";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(368, 12);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(271, 252);
            textBox6.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 285);
            Controls.Add(textBox6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox6;
    }
}