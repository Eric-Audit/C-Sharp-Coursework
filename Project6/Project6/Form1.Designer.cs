namespace Project6
{
    partial class namePopularity
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
            this.userInput = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.popularBabyNames = new System.Windows.Forms.Label();
            this.userInputLabel = new System.Windows.Forms.Label();
            this.accept = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userInput
            // 
            this.userInput.AccessibleDescription = "";
            this.userInput.AccessibleName = "";
            this.userInput.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.userInput.Location = new System.Drawing.Point(93, 67);
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(103, 20);
            this.userInput.TabIndex = 1;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(201, 130);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(78, 23);
            this.exit.TabIndex = 2;
            this.exit.Text = "E&xit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // popularBabyNames
            // 
            this.popularBabyNames.AllowDrop = true;
            this.popularBabyNames.AutoSize = true;
            this.popularBabyNames.Location = new System.Drawing.Point(90, 9);
            this.popularBabyNames.Name = "popularBabyNames";
            this.popularBabyNames.Size = new System.Drawing.Size(106, 13);
            this.popularBabyNames.TabIndex = 4;
            this.popularBabyNames.Text = "Popular Baby Names";
            this.popularBabyNames.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // userInputLabel
            // 
            this.userInputLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userInputLabel.AutoSize = true;
            this.userInputLabel.Location = new System.Drawing.Point(47, 51);
            this.userInputLabel.Name = "userInputLabel";
            this.userInputLabel.Size = new System.Drawing.Size(202, 13);
            this.userInputLabel.TabIndex = 5;
            this.userInputLabel.Text = "Type a baby name below then hit \"Enter\"";
            // 
            // accept
            // 
            this.accept.Location = new System.Drawing.Point(12, 130);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(79, 23);
            this.accept.TabIndex = 6;
            this.accept.Text = "Accept";
            this.accept.UseCompatibleTextRendering = true;
            this.accept.UseVisualStyleBackColor = true;
            this.accept.Click += new System.EventHandler(this.accept_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(76, 92);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 13);
            this.result.TabIndex = 7;
            // 
            // clear
            // 
            this.clear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clear.Location = new System.Drawing.Point(104, 130);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(81, 23);
            this.clear.TabIndex = 8;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // namePopularity
            // 
            this.AcceptButton = this.accept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clear;
            this.ClientSize = new System.Drawing.Size(291, 165);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.result);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.userInputLabel);
            this.Controls.Add(this.popularBabyNames);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.userInput);
            this.Name = "namePopularity";
            this.Text = "Name Popularity Rater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox userInput;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label popularBabyNames;
        private System.Windows.Forms.Label userInputLabel;
        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button clear;
    }
}

