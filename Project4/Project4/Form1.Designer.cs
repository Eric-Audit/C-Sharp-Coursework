namespace Project4
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
            this.Guess = new System.Windows.Forms.Button();
            this.Number = new System.Windows.Forms.TextBox();
            this.Guess_label = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.Outcome = new System.Windows.Forms.Label();
            this.Result_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Guess
            // 
            this.Guess.Location = new System.Drawing.Point(67, 157);
            this.Guess.Name = "Guess";
            this.Guess.Size = new System.Drawing.Size(75, 23);
            this.Guess.TabIndex = 0;
            this.Guess.Text = "Guess";
            this.Guess.UseVisualStyleBackColor = true;
            this.Guess.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Number
            // 
            this.Number.Location = new System.Drawing.Point(110, 51);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(32, 20);
            this.Number.TabIndex = 1;
            this.Number.Tag = "";
            // 
            // Guess_label
            // 
            this.Guess_label.AutoSize = true;
            this.Guess_label.Location = new System.Drawing.Point(15, 54);
            this.Guess_label.Name = "Guess_label";
            this.Guess_label.Size = new System.Drawing.Size(92, 13);
            this.Guess_label.TabIndex = 2;
            this.Guess_label.Text = "Type Your Guess:";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(148, 157);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "E&xit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Outcome
            // 
            this.Outcome.BackColor = System.Drawing.SystemColors.Window;
            this.Outcome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Outcome.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Outcome.Location = new System.Drawing.Point(110, 101);
            this.Outcome.Name = "Outcome";
            this.Outcome.Size = new System.Drawing.Size(200, 37);
            this.Outcome.TabIndex = 4;
            // 
            // Result_label
            // 
            this.Result_label.AutoSize = true;
            this.Result_label.Location = new System.Drawing.Point(64, 102);
            this.Result_label.Name = "Result_label";
            this.Result_label.Size = new System.Drawing.Size(40, 13);
            this.Result_label.TabIndex = 5;
            this.Result_label.Text = "Result:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Guess a number between 1 and 100";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 192);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Result_label);
            this.Controls.Add(this.Outcome);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Guess_label);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.Guess);
            this.Name = "Form1";
            this.Text = "Number Guessing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Guess;
        private System.Windows.Forms.TextBox Number;
        private System.Windows.Forms.Label Guess_label;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label Outcome;
        private System.Windows.Forms.Label Result_label;
        private System.Windows.Forms.Label label1;
    }
}

