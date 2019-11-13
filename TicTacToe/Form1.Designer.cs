namespace TicTacToe
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.A00 = new System.Windows.Forms.Button();
            this.A10 = new System.Windows.Forms.Button();
            this.A20 = new System.Windows.Forms.Button();
            this.A21 = new System.Windows.Forms.Button();
            this.A11 = new System.Windows.Forms.Button();
            this.A01 = new System.Windows.Forms.Button();
            this.A22 = new System.Windows.Forms.Button();
            this.A12 = new System.Windows.Forms.Button();
            this.A02 = new System.Windows.Forms.Button();
            this.newGameButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.Xwins = new System.Windows.Forms.Label();
            this.Owins = new System.Windows.Forms.Label();
            this.Draws = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // A00
            // 
            this.A00.BackColor = System.Drawing.SystemColors.ControlLight;
            this.A00.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.A00.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A00.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A00.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.A00.Location = new System.Drawing.Point(12, 12);
            this.A00.Name = "A00";
            this.A00.Size = new System.Drawing.Size(93, 84);
            this.A00.TabIndex = 0;
            this.A00.UseVisualStyleBackColor = false;
            this.A00.Click += new System.EventHandler(this.ButtonClick);
            // 
            // A10
            // 
            this.A10.BackColor = System.Drawing.SystemColors.ControlLight;
            this.A10.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.A10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A10.Font = new System.Drawing.Font("Georgia", 24F);
            this.A10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.A10.Location = new System.Drawing.Point(12, 102);
            this.A10.Name = "A10";
            this.A10.Size = new System.Drawing.Size(93, 84);
            this.A10.TabIndex = 1;
            this.A10.UseVisualStyleBackColor = false;
            this.A10.Click += new System.EventHandler(this.ButtonClick);
            // 
            // A20
            // 
            this.A20.BackColor = System.Drawing.SystemColors.ControlLight;
            this.A20.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.A20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A20.Font = new System.Drawing.Font("Georgia", 24F);
            this.A20.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.A20.Location = new System.Drawing.Point(12, 192);
            this.A20.Name = "A20";
            this.A20.Size = new System.Drawing.Size(93, 84);
            this.A20.TabIndex = 2;
            this.A20.UseVisualStyleBackColor = false;
            this.A20.Click += new System.EventHandler(this.ButtonClick);
            // 
            // A21
            // 
            this.A21.BackColor = System.Drawing.SystemColors.ControlLight;
            this.A21.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.A21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A21.Font = new System.Drawing.Font("Georgia", 24F);
            this.A21.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.A21.Location = new System.Drawing.Point(111, 192);
            this.A21.Name = "A21";
            this.A21.Size = new System.Drawing.Size(93, 84);
            this.A21.TabIndex = 5;
            this.A21.UseVisualStyleBackColor = false;
            this.A21.Click += new System.EventHandler(this.ButtonClick);
            // 
            // A11
            // 
            this.A11.BackColor = System.Drawing.SystemColors.ControlLight;
            this.A11.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.A11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A11.Font = new System.Drawing.Font("Georgia", 24F);
            this.A11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.A11.Location = new System.Drawing.Point(111, 102);
            this.A11.Name = "A11";
            this.A11.Size = new System.Drawing.Size(93, 84);
            this.A11.TabIndex = 4;
            this.A11.UseVisualStyleBackColor = false;
            this.A11.Click += new System.EventHandler(this.ButtonClick);
            // 
            // A01
            // 
            this.A01.BackColor = System.Drawing.SystemColors.ControlLight;
            this.A01.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.A01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A01.Font = new System.Drawing.Font("Georgia", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.A01.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.A01.Location = new System.Drawing.Point(111, 12);
            this.A01.Name = "A01";
            this.A01.Size = new System.Drawing.Size(93, 84);
            this.A01.TabIndex = 3;
            this.A01.UseVisualStyleBackColor = false;
            this.A01.Click += new System.EventHandler(this.ButtonClick);
            // 
            // A22
            // 
            this.A22.BackColor = System.Drawing.SystemColors.ControlLight;
            this.A22.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.A22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A22.Font = new System.Drawing.Font("Georgia", 24F);
            this.A22.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.A22.Location = new System.Drawing.Point(210, 192);
            this.A22.Name = "A22";
            this.A22.Size = new System.Drawing.Size(93, 84);
            this.A22.TabIndex = 8;
            this.A22.UseVisualStyleBackColor = false;
            this.A22.Click += new System.EventHandler(this.ButtonClick);
            // 
            // A12
            // 
            this.A12.BackColor = System.Drawing.SystemColors.ControlLight;
            this.A12.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.A12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A12.Font = new System.Drawing.Font("Georgia", 24F);
            this.A12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.A12.Location = new System.Drawing.Point(210, 102);
            this.A12.Name = "A12";
            this.A12.Size = new System.Drawing.Size(93, 84);
            this.A12.TabIndex = 7;
            this.A12.UseVisualStyleBackColor = false;
            this.A12.Click += new System.EventHandler(this.ButtonClick);
            // 
            // A02
            // 
            this.A02.BackColor = System.Drawing.SystemColors.ControlLight;
            this.A02.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.A02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A02.Font = new System.Drawing.Font("Georgia", 24F);
            this.A02.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.A02.Location = new System.Drawing.Point(210, 12);
            this.A02.Name = "A02";
            this.A02.Size = new System.Drawing.Size(93, 84);
            this.A02.TabIndex = 6;
            this.A02.UseVisualStyleBackColor = false;
            this.A02.Click += new System.EventHandler(this.ButtonClick);
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(12, 312);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(93, 31);
            this.newGameButton.TabIndex = 9;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(111, 312);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(93, 31);
            this.resetButton.TabIndex = 10;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(210, 312);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(93, 31);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // Xwins
            // 
            this.Xwins.Location = new System.Drawing.Point(381, 46);
            this.Xwins.Name = "Xwins";
            this.Xwins.Size = new System.Drawing.Size(100, 23);
            this.Xwins.TabIndex = 12;
            this.Xwins.Text = "X wins:";
            // 
            // Owins
            // 
            this.Owins.Location = new System.Drawing.Point(381, 136);
            this.Owins.Name = "Owins";
            this.Owins.Size = new System.Drawing.Size(100, 23);
            this.Owins.TabIndex = 13;
            this.Owins.Text = "O wins:";
            // 
            // Draws
            // 
            this.Draws.Location = new System.Drawing.Point(381, 226);
            this.Draws.Name = "Draws";
            this.Draws.Size = new System.Drawing.Size(100, 23);
            this.Draws.TabIndex = 14;
            this.Draws.Text = "Draws:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(493, 436);
            this.Controls.Add(this.Draws);
            this.Controls.Add(this.Owins);
            this.Controls.Add(this.Xwins);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.A22);
            this.Controls.Add(this.A12);
            this.Controls.Add(this.A02);
            this.Controls.Add(this.A21);
            this.Controls.Add(this.A11);
            this.Controls.Add(this.A01);
            this.Controls.Add(this.A20);
            this.Controls.Add(this.A10);
            this.Controls.Add(this.A00);
            this.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button A00;
        private System.Windows.Forms.Button A10;
        private System.Windows.Forms.Button A20;
        private System.Windows.Forms.Button A21;
        private System.Windows.Forms.Button A11;
        private System.Windows.Forms.Button A01;
        private System.Windows.Forms.Button A22;
        private System.Windows.Forms.Button A12;
        private System.Windows.Forms.Button A02;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label Xwins;
        private System.Windows.Forms.Label Owins;
        private System.Windows.Forms.Label Draws;
    }
}

