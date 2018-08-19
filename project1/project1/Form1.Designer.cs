namespace project1
{
    partial class project1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(project1));
            this.StarMap = new System.Windows.Forms.PictureBox();
            this.Star1 = new System.Windows.Forms.Label();
            this.Star7 = new System.Windows.Forms.Label();
            this.Star6 = new System.Windows.Forms.Label();
            this.Star5 = new System.Windows.Forms.Label();
            this.Star4 = new System.Windows.Forms.Label();
            this.Star3 = new System.Windows.Forms.Label();
            this.Star2 = new System.Windows.Forms.Label();
            this.ShowStars = new System.Windows.Forms.Button();
            this.HideStars = new System.Windows.Forms.Button();
            this.ExitProgram = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StarMap)).BeginInit();
            this.SuspendLayout();
            // 
            // StarMap
            // 
            this.StarMap.Image = ((System.Drawing.Image)(resources.GetObject("StarMap.Image")));
            this.StarMap.Location = new System.Drawing.Point(2, 2);
            this.StarMap.Name = "StarMap";
            this.StarMap.Size = new System.Drawing.Size(400, 470);
            this.StarMap.TabIndex = 0;
            this.StarMap.TabStop = false;
            // 
            // Star1
            // 
            this.Star1.AutoSize = true;
            this.Star1.Location = new System.Drawing.Point(66, 60);
            this.Star1.Name = "Star1";
            this.Star1.Size = new System.Drawing.Size(60, 13);
            this.Star1.TabIndex = 1;
            this.Star1.Text = "Betelgeuse";
            this.Star1.Visible = false;
            this.Star1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Star7
            // 
            this.Star7.AutoSize = true;
            this.Star7.Location = new System.Drawing.Point(260, 356);
            this.Star7.Name = "Star7";
            this.Star7.Size = new System.Drawing.Size(31, 13);
            this.Star7.TabIndex = 2;
            this.Star7.Text = "Rigel";
            this.Star7.Visible = false;
            this.Star7.Click += new System.EventHandler(this.Star7_Click);
            // 
            // Star6
            // 
            this.Star6.AutoSize = true;
            this.Star6.Location = new System.Drawing.Point(66, 388);
            this.Star6.Name = "Star6";
            this.Star6.Size = new System.Drawing.Size(34, 13);
            this.Star6.TabIndex = 3;
            this.Star6.Text = "Saiph";
            this.Star6.Visible = false;
            this.Star6.Click += new System.EventHandler(this.Star6_Click);
            // 
            // Star5
            // 
            this.Star5.AutoSize = true;
            this.Star5.Location = new System.Drawing.Point(208, 215);
            this.Star5.Name = "Star5";
            this.Star5.Size = new System.Drawing.Size(45, 13);
            this.Star5.TabIndex = 4;
            this.Star5.Text = "Mintaka";
            this.Star5.Visible = false;
            this.Star5.Click += new System.EventHandler(this.Star5_Click);
            // 
            // Star4
            // 
            this.Star4.AutoSize = true;
            this.Star4.Location = new System.Drawing.Point(165, 230);
            this.Star4.Name = "Star4";
            this.Star4.Size = new System.Drawing.Size(40, 13);
            this.Star4.TabIndex = 5;
            this.Star4.Text = "Alnilam";
            this.Star4.Visible = false;
            this.Star4.Click += new System.EventHandler(this.Star4_Click);
            // 
            // Star3
            // 
            this.Star3.AutoSize = true;
            this.Star3.Location = new System.Drawing.Point(115, 248);
            this.Star3.Name = "Star3";
            this.Star3.Size = new System.Drawing.Size(39, 13);
            this.Star3.TabIndex = 6;
            this.Star3.Text = "Alnitak";
            this.Star3.Visible = false;
            this.Star3.Click += new System.EventHandler(this.label6_Click);
            // 
            // Star2
            // 
            this.Star2.AutoSize = true;
            this.Star2.Location = new System.Drawing.Point(260, 95);
            this.Star2.Name = "Star2";
            this.Star2.Size = new System.Drawing.Size(40, 13);
            this.Star2.TabIndex = 7;
            this.Star2.Text = "Meissa";
            this.Star2.Visible = false;
            this.Star2.Click += new System.EventHandler(this.label7_Click);
            // 
            // ShowStars
            // 
            this.ShowStars.Location = new System.Drawing.Point(69, 426);
            this.ShowStars.Name = "ShowStars";
            this.ShowStars.Size = new System.Drawing.Size(75, 35);
            this.ShowStars.TabIndex = 8;
            this.ShowStars.Text = "Show Star Names";
            this.ShowStars.UseVisualStyleBackColor = true;
            this.ShowStars.Click += new System.EventHandler(this.ShowStars_Click);
            // 
            // HideStars
            // 
            this.HideStars.Location = new System.Drawing.Point(150, 426);
            this.HideStars.Name = "HideStars";
            this.HideStars.Size = new System.Drawing.Size(75, 35);
            this.HideStars.TabIndex = 9;
            this.HideStars.Text = "Hide Star Names";
            this.HideStars.UseVisualStyleBackColor = true;
            this.HideStars.Click += new System.EventHandler(this.HideStars_Click);
            // 
            // ExitProgram
            // 
            this.ExitProgram.Location = new System.Drawing.Point(231, 426);
            this.ExitProgram.Name = "ExitProgram";
            this.ExitProgram.Size = new System.Drawing.Size(75, 35);
            this.ExitProgram.TabIndex = 10;
            this.ExitProgram.Text = "Exit";
            this.ExitProgram.UseVisualStyleBackColor = true;
            this.ExitProgram.Click += new System.EventHandler(this.ExitProgram_Click);
            // 
            // project1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 473);
            this.Controls.Add(this.ExitProgram);
            this.Controls.Add(this.HideStars);
            this.Controls.Add(this.ShowStars);
            this.Controls.Add(this.Star2);
            this.Controls.Add(this.Star3);
            this.Controls.Add(this.Star4);
            this.Controls.Add(this.Star5);
            this.Controls.Add(this.Star6);
            this.Controls.Add(this.Star7);
            this.Controls.Add(this.Star1);
            this.Controls.Add(this.StarMap);
            this.Name = "project1";
            this.Text = "Orion Constellation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StarMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox StarMap;
        private System.Windows.Forms.Label Star1;
        private System.Windows.Forms.Label Star7;
        private System.Windows.Forms.Label Star6;
        private System.Windows.Forms.Label Star5;
        private System.Windows.Forms.Label Star4;
        private System.Windows.Forms.Label Star3;
        private System.Windows.Forms.Label Star2;
        private System.Windows.Forms.Button ShowStars;
        private System.Windows.Forms.Button HideStars;
        private System.Windows.Forms.Button ExitProgram;
    }
}

