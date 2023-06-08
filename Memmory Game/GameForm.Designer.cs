namespace Memmory_Game
{
    partial class GameForm
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
            components = new System.ComponentModel.Container();
            panel1 = new System.Windows.Forms.Panel();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            liveslab = new System.Windows.Forms.Label();
            tileslab = new System.Windows.Forms.Label();
            Playerlab = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(liveslab);
            panel1.Controls.Add(tileslab);
            panel1.Controls.Add(Playerlab);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new System.Drawing.Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(183, 429);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(56, 59);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(50, 20);
            label5.TabIndex = 9;
            label5.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(54, 22);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(44, 20);
            label4.TabIndex = 8;
            label4.Text = "Time";
            // 
            // liveslab
            // 
            liveslab.AutoSize = true;
            liveslab.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            liveslab.Location = new System.Drawing.Point(113, 203);
            liveslab.Name = "liveslab";
            liveslab.Size = new System.Drawing.Size(13, 20);
            liveslab.TabIndex = 7;
            liveslab.Text = " ";
            // 
            // tileslab
            // 
            tileslab.AutoSize = true;
            tileslab.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            tileslab.Location = new System.Drawing.Point(113, 173);
            tileslab.Name = "tileslab";
            tileslab.Size = new System.Drawing.Size(13, 20);
            tileslab.TabIndex = 6;
            tileslab.Text = " ";
            // 
            // Playerlab
            // 
            Playerlab.AutoSize = true;
            Playerlab.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Playerlab.Location = new System.Drawing.Point(113, 142);
            Playerlab.Name = "Playerlab";
            Playerlab.Size = new System.Drawing.Size(13, 20);
            Playerlab.TabIndex = 5;
            Playerlab.Text = " ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(8, 203);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(80, 20);
            label3.TabIndex = 4;
            label3.Text = "Lives Left:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            label2.Location = new System.Drawing.Point(8, 173);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(77, 20);
            label2.TabIndex = 3;
            label2.Text = "Tiles Left:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(8, 142);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(57, 20);
            label1.TabIndex = 2;
            label1.Text = "Player:";
            // 
            // button2
            // 
            button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button2.Location = new System.Drawing.Point(7, 288);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(163, 29);
            button2.TabIndex = 1;
            button2.Text = "Back To Main Menu";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(7, 240);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(163, 29);
            button1.TabIndex = 0;
            button1.Text = "Start Playing";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new System.Drawing.Point(201, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(587, 429);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick_1;
            // 
            // timer2
            // 
            timer2.Interval = 1000;
            timer2.Tick += timer2_Tick;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(798, 450);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Name = "GameForm";
            Text = "GameForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label liveslab;
        private System.Windows.Forms.Label tileslab;
        private System.Windows.Forms.Label Playerlab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}