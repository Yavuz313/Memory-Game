namespace Memmory_Game
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            panel1 = new System.Windows.Forms.Panel();
            numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            brdsize = new System.Windows.Forms.Label();
            startbtn = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(149, 21);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(170, 28);
            label1.TabIndex = 0;
            label1.Text = "Memmory Game";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(198, 67);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(51, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(149, 91);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(170, 27);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(112, 131);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(91, 25);
            label3.TabIndex = 3;
            label3.Text = "Difficulty";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Easy", "Medium", "Hard", "Custom" });
            comboBox1.Location = new System.Drawing.Point(235, 132);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(151, 28);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Moccasin;
            panel1.Controls.Add(numericUpDown4);
            panel1.Controls.Add(numericUpDown3);
            panel1.Controls.Add(numericUpDown2);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(brdsize);
            panel1.Location = new System.Drawing.Point(112, 165);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(275, 237);
            panel1.TabIndex = 5;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new System.Drawing.Point(187, 146);
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new System.Drawing.Size(58, 27);
            numericUpDown4.TabIndex = 7;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new System.Drawing.Point(187, 105);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new System.Drawing.Size(58, 27);
            numericUpDown3.TabIndex = 6;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new System.Drawing.Point(187, 67);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new System.Drawing.Size(58, 27);
            numericUpDown2.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new System.Drawing.Point(187, 29);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new System.Drawing.Size(58, 27);
            numericUpDown1.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(24, 148);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(126, 20);
            label7.TabIndex = 3;
            label7.Text = "Number of Tiles:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(24, 107);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(112, 20);
            label6.TabIndex = 2;
            label6.Text = "Showing Time:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(24, 67);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(129, 20);
            label5.TabIndex = 1;
            label5.Text = "Number of Lives:";
            // 
            // brdsize
            // 
            brdsize.AutoSize = true;
            brdsize.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            brdsize.Location = new System.Drawing.Point(24, 28);
            brdsize.Name = "brdsize";
            brdsize.Size = new System.Drawing.Size(86, 20);
            brdsize.TabIndex = 0;
            brdsize.Text = "Board Size:";
            // 
            // startbtn
            // 
            startbtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            startbtn.Location = new System.Drawing.Point(112, 409);
            startbtn.Name = "startbtn";
            startbtn.Size = new System.Drawing.Size(275, 29);
            startbtn.TabIndex = 6;
            startbtn.Text = "Start Game";
            startbtn.UseVisualStyleBackColor = true;
            startbtn.Click += startbtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Coral;
            ClientSize = new System.Drawing.Size(491, 457);
            Controls.Add(startbtn);
            Controls.Add(panel1);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = System.Drawing.Color.Black;
            Name = "Form1";
            Text = "Main Menu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label brdsize;
        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}
