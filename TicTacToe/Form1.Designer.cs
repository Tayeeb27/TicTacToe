namespace TicTacToe
{
    partial class Form1
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
            this.A1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.winStreakLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // A1
            // 
            this.A1.BackColor = System.Drawing.Color.White;
            this.A1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.A1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.A1.Location = new System.Drawing.Point(18, 65);
            this.A1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(112, 115);
            this.A1.TabIndex = 0;
            this.A1.UseVisualStyleBackColor = false;
            this.A1.Click += new System.EventHandler(this.buttonClick);
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.Color.White;
            this.B2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.B2.Location = new System.Drawing.Point(140, 189);
            this.B2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(112, 115);
            this.B2.TabIndex = 1;
            this.B2.UseVisualStyleBackColor = false;
            this.B2.Click += new System.EventHandler(this.buttonClick);
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.Color.White;
            this.B3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.B3.Location = new System.Drawing.Point(261, 189);
            this.B3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(112, 115);
            this.B3.TabIndex = 2;
            this.B3.UseVisualStyleBackColor = false;
            this.B3.Click += new System.EventHandler(this.buttonClick);
            // 
            // C3
            // 
            this.C3.BackColor = System.Drawing.Color.White;
            this.C3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.C3.Location = new System.Drawing.Point(261, 314);
            this.C3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(112, 115);
            this.C3.TabIndex = 3;
            this.C3.UseVisualStyleBackColor = false;
            this.C3.Click += new System.EventHandler(this.buttonClick);
            // 
            // C1
            // 
            this.C1.BackColor = System.Drawing.Color.White;
            this.C1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.C1.Location = new System.Drawing.Point(18, 314);
            this.C1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(112, 115);
            this.C1.TabIndex = 4;
            this.C1.UseVisualStyleBackColor = false;
            this.C1.Click += new System.EventHandler(this.buttonClick);
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.Color.White;
            this.B1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.B1.Location = new System.Drawing.Point(18, 189);
            this.B1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(112, 115);
            this.B1.TabIndex = 5;
            this.B1.UseVisualStyleBackColor = false;
            this.B1.Click += new System.EventHandler(this.buttonClick);
            // 
            // A3
            // 
            this.A3.BackColor = System.Drawing.Color.White;
            this.A3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.A3.Location = new System.Drawing.Point(261, 65);
            this.A3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(112, 115);
            this.A3.TabIndex = 6;
            this.A3.UseVisualStyleBackColor = false;
            this.A3.Click += new System.EventHandler(this.buttonClick);
            // 
            // A2
            // 
            this.A2.BackColor = System.Drawing.Color.White;
            this.A2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.A2.Location = new System.Drawing.Point(140, 65);
            this.A2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(112, 115);
            this.A2.TabIndex = 7;
            this.A2.UseVisualStyleBackColor = false;
            this.A2.Click += new System.EventHandler(this.buttonClick);
            // 
            // C2
            // 
            this.C2.BackColor = System.Drawing.Color.White;
            this.C2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.C2.Location = new System.Drawing.Point(140, 314);
            this.C2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(112, 115);
            this.C2.TabIndex = 9;
            this.C2.UseVisualStyleBackColor = false;
            this.C2.Click += new System.EventHandler(this.buttonClick);
            // 
            // winStreakLabel
            // 
            this.winStreakLabel.AutoSize = true;
            this.winStreakLabel.Location = new System.Drawing.Point(15, 446);
            this.winStreakLabel.Name = "winStreakLabel";
            this.winStreakLabel.Size = new System.Drawing.Size(281, 20);
            this.winStreakLabel.TabIndex = 11;
            this.winStreakLabel.Text = "X is on a win streak of 50, click to reset";
            this.winStreakLabel.Click += new System.EventHandler(this.winStreakLabel_Click);
            this.winStreakLabel.ForeColor = System.Drawing.Color.Red;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(399, 487);
            this.Controls.Add(this.winStreakLabel);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.A1);
            this.ForeColor = System.Drawing.Color.Lime;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic-Tac-Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Label winStreakLabel;
    }
}
