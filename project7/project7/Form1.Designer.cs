namespace project7
{
    partial class wordcounter
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
            this.exit = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.accept = new System.Windows.Forms.Button();
            this.userInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(250, 197);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(80, 23);
            this.exit.TabIndex = 0;
            this.exit.Text = "E&xit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // clear
            // 
            this.clear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clear.Location = new System.Drawing.Point(164, 197);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(80, 23);
            this.clear.TabIndex = 1;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // accept
            // 
            this.accept.Location = new System.Drawing.Point(80, 197);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(80, 23);
            this.accept.TabIndex = 2;
            this.accept.Text = "Accept";
            this.accept.UseVisualStyleBackColor = true;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // userInput
            // 
            this.userInput.Location = new System.Drawing.Point(80, 113);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(250, 20);
            this.userInput.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Type a sentence below:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "This program will count words and display \r\nthe average number of letters in each" +
    " word";
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(77, 136);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(0, 13);
            this.output.TabIndex = 6;
            // 
            // wordcounter
            // 
            this.AcceptButton = this.accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clear;
            this.ClientSize = new System.Drawing.Size(410, 257);
            this.Controls.Add(this.output);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userInput);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Location = new System.Drawing.Point(1000, 1000);
            this.Name = "wordcounter";
            this.Text = "Word and Letter Counter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.TextBox userInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label output;
    }
}

