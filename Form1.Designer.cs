namespace Tictactoe
{
    partial class Tictactoe
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
            this.A01 = new System.Windows.Forms.Button();
            this.A11 = new System.Windows.Forms.Button();
            this.A21 = new System.Windows.Forms.Button();
            this.A02 = new System.Windows.Forms.Button();
            this.A12 = new System.Windows.Forms.Button();
            this.A22 = new System.Windows.Forms.Button();
            this.A03 = new System.Windows.Forms.Button();
            this.A13 = new System.Windows.Forms.Button();
            this.A23 = new System.Windows.Forms.Button();
            this.Startbutton = new System.Windows.Forms.Button();
            this.Resetbutton = new System.Windows.Forms.Button();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.PlayerX = new System.Windows.Forms.Label();
            this.PlayerO = new System.Windows.Forms.Label();
            this.Draw = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // A01
            // 
            this.A01.Location = new System.Drawing.Point(13, 15);
            this.A01.Name = "A01";
            this.A01.Size = new System.Drawing.Size(116, 112);
            this.A01.TabIndex = 0;
            this.A01.UseVisualStyleBackColor = true;
            this.A01.Click += new System.EventHandler(this.TictactoeClick);
            // 
            // A11
            // 
            this.A11.Location = new System.Drawing.Point(13, 133);
            this.A11.Name = "A11";
            this.A11.Size = new System.Drawing.Size(116, 112);
            this.A11.TabIndex = 1;
            this.A11.UseVisualStyleBackColor = true;
            this.A11.Click += new System.EventHandler(this.TictactoeClick);
            // 
            // A21
            // 
            this.A21.Location = new System.Drawing.Point(13, 251);
            this.A21.Name = "A21";
            this.A21.Size = new System.Drawing.Size(116, 112);
            this.A21.TabIndex = 2;
            this.A21.UseVisualStyleBackColor = true;
            this.A21.Click += new System.EventHandler(this.TictactoeClick);
            // 
            // A02
            // 
            this.A02.Location = new System.Drawing.Point(135, 15);
            this.A02.Name = "A02";
            this.A02.Size = new System.Drawing.Size(116, 112);
            this.A02.TabIndex = 3;
            this.A02.UseVisualStyleBackColor = true;
            this.A02.Click += new System.EventHandler(this.TictactoeClick);
            // 
            // A12
            // 
            this.A12.Location = new System.Drawing.Point(135, 133);
            this.A12.Name = "A12";
            this.A12.Size = new System.Drawing.Size(116, 112);
            this.A12.TabIndex = 4;
            this.A12.UseVisualStyleBackColor = true;
            this.A12.Click += new System.EventHandler(this.TictactoeClick);
            // 
            // A22
            // 
            this.A22.Location = new System.Drawing.Point(135, 251);
            this.A22.Name = "A22";
            this.A22.Size = new System.Drawing.Size(116, 112);
            this.A22.TabIndex = 5;
            this.A22.UseVisualStyleBackColor = true;
            this.A22.Click += new System.EventHandler(this.TictactoeClick);
            // 
            // A03
            // 
            this.A03.Location = new System.Drawing.Point(257, 15);
            this.A03.Name = "A03";
            this.A03.Size = new System.Drawing.Size(116, 112);
            this.A03.TabIndex = 6;
            this.A03.UseVisualStyleBackColor = true;
            this.A03.Click += new System.EventHandler(this.TictactoeClick);
            // 
            // A13
            // 
            this.A13.Location = new System.Drawing.Point(257, 133);
            this.A13.Name = "A13";
            this.A13.Size = new System.Drawing.Size(116, 112);
            this.A13.TabIndex = 7;
            this.A13.UseVisualStyleBackColor = true;
            this.A13.Click += new System.EventHandler(this.TictactoeClick);
            // 
            // A23
            // 
            this.A23.Location = new System.Drawing.Point(257, 251);
            this.A23.Name = "A23";
            this.A23.Size = new System.Drawing.Size(116, 112);
            this.A23.TabIndex = 8;
            this.A23.UseVisualStyleBackColor = true;
            this.A23.Click += new System.EventHandler(this.TictactoeClick);
            // 
            // Startbutton
            // 
            this.Startbutton.Location = new System.Drawing.Point(13, 539);
            this.Startbutton.Name = "Startbutton";
            this.Startbutton.Size = new System.Drawing.Size(116, 42);
            this.Startbutton.TabIndex = 9;
            this.Startbutton.Text = "Start";
            this.Startbutton.UseVisualStyleBackColor = true;
            // 
            // Resetbutton
            // 
            this.Resetbutton.Location = new System.Drawing.Point(135, 539);
            this.Resetbutton.Name = "Resetbutton";
            this.Resetbutton.Size = new System.Drawing.Size(116, 42);
            this.Resetbutton.TabIndex = 10;
            this.Resetbutton.Text = "Reset";
            this.Resetbutton.UseVisualStyleBackColor = true;
            // 
            // Exitbutton
            // 
            this.Exitbutton.Location = new System.Drawing.Point(257, 539);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(116, 42);
            this.Exitbutton.TabIndex = 11;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = true;
            // 
            // PlayerX
            // 
            this.PlayerX.AutoSize = true;
            this.PlayerX.Location = new System.Drawing.Point(13, 381);
            this.PlayerX.Name = "PlayerX";
            this.PlayerX.Size = new System.Drawing.Size(48, 15);
            this.PlayerX.TabIndex = 12;
            this.PlayerX.Text = "Player 1";
            this.PlayerX.Click += new System.EventHandler(this.label1_Click);
            // 
            // PlayerO
            // 
            this.PlayerO.AutoSize = true;
            this.PlayerO.Location = new System.Drawing.Point(135, 381);
            this.PlayerO.Name = "PlayerO";
            this.PlayerO.Size = new System.Drawing.Size(48, 15);
            this.PlayerO.TabIndex = 13;
            this.PlayerO.Text = "Player 2";
            this.PlayerO.Click += new System.EventHandler(this.PlayerO_Click);
            // 
            // Draw
            // 
            this.Draw.AutoSize = true;
            this.Draw.Location = new System.Drawing.Point(257, 381);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(34, 15);
            this.Draw.TabIndex = 14;
            this.Draw.Text = "Draw";
            // 
            // Tictactoe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 591);
            this.Controls.Add(this.Draw);
            this.Controls.Add(this.PlayerO);
            this.Controls.Add(this.PlayerX);
            this.Controls.Add(this.Exitbutton);
            this.Controls.Add(this.Resetbutton);
            this.Controls.Add(this.Startbutton);
            this.Controls.Add(this.A23);
            this.Controls.Add(this.A13);
            this.Controls.Add(this.A03);
            this.Controls.Add(this.A22);
            this.Controls.Add(this.A12);
            this.Controls.Add(this.A02);
            this.Controls.Add(this.A21);
            this.Controls.Add(this.A11);
            this.Controls.Add(this.A01);
            this.Name = "Tictactoe";
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button A01;
        private Button A11;
        private Button A21;
        private Button A02;
        private Button A12;
        private Button A22;
        private Button A03;
        private Button A13;
        private Button A23;
        private Button Startbutton;
        private Button Resetbutton;
        private Button Exitbutton;
        private Label PlayerX;
        private Label PlayerO;
        private Label Draw;
    }
}