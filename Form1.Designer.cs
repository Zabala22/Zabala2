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
            this.A = new System.Windows.Forms.Button();
            this.D = new System.Windows.Forms.Button();
            this.G = new System.Windows.Forms.Button();
            this.B = new System.Windows.Forms.Button();
            this.E = new System.Windows.Forms.Button();
            this.H = new System.Windows.Forms.Button();
            this.C = new System.Windows.Forms.Button();
            this.F = new System.Windows.Forms.Button();
            this.I = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(13, 15);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(116, 112);
            this.A.TabIndex = 0;
            this.A.UseVisualStyleBackColor = true;
            this.A.Click += new System.EventHandler(this.TictactoeClick);
            // 
            // D
            // 
            this.D.Location = new System.Drawing.Point(13, 133);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(116, 112);
            this.D.TabIndex = 1;
            this.D.UseVisualStyleBackColor = true;
            // 
            // G
            // 
            this.G.Location = new System.Drawing.Point(13, 251);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(116, 112);
            this.G.TabIndex = 2;
            this.G.UseVisualStyleBackColor = true;
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(135, 15);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(116, 112);
            this.B.TabIndex = 3;
            this.B.UseVisualStyleBackColor = true;
            // 
            // E
            // 
            this.E.Location = new System.Drawing.Point(135, 133);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(116, 112);
            this.E.TabIndex = 4;
            this.E.UseVisualStyleBackColor = true;
            // 
            // H
            // 
            this.H.Location = new System.Drawing.Point(135, 251);
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(116, 112);
            this.H.TabIndex = 5;
            this.H.UseVisualStyleBackColor = true;
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(257, 15);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(116, 112);
            this.C.TabIndex = 6;
            this.C.UseVisualStyleBackColor = true;
            // 
            // F
            // 
            this.F.Location = new System.Drawing.Point(257, 133);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(116, 112);
            this.F.TabIndex = 7;
            this.F.UseVisualStyleBackColor = true;
            // 
            // I
            // 
            this.I.Location = new System.Drawing.Point(257, 251);
            this.I.Name = "I";
            this.I.Size = new System.Drawing.Size(116, 112);
            this.I.TabIndex = 8;
            this.I.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 42);
            this.button1.TabIndex = 9;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(135, 418);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 42);
            this.button2.TabIndex = 10;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(257, 418);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 42);
            this.button3.TabIndex = 11;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Tictactoe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 484);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.I);
            this.Controls.Add(this.F);
            this.Controls.Add(this.C);
            this.Controls.Add(this.H);
            this.Controls.Add(this.E);
            this.Controls.Add(this.B);
            this.Controls.Add(this.G);
            this.Controls.Add(this.D);
            this.Controls.Add(this.A);
            this.Name = "Tictactoe";
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button A;
        private Button D;
        private Button G;
        private Button B;
        private Button E;
        private Button H;
        private Button C;
        private Button F;
        private Button I;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}