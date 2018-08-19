namespace project3
{
    partial class color_mixer
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
            this.first_color = new System.Windows.Forms.GroupBox();
            this.yellow1 = new System.Windows.Forms.RadioButton();
            this.blue1 = new System.Windows.Forms.RadioButton();
            this.red1 = new System.Windows.Forms.RadioButton();
            this.second_color = new System.Windows.Forms.GroupBox();
            this.red2 = new System.Windows.Forms.RadioButton();
            this.yellow2 = new System.Windows.Forms.RadioButton();
            this.blue2 = new System.Windows.Forms.RadioButton();
            this.mix = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.first_color.SuspendLayout();
            this.second_color.SuspendLayout();
            this.SuspendLayout();
            // 
            // first_color
            // 
            this.first_color.Controls.Add(this.yellow1);
            this.first_color.Controls.Add(this.blue1);
            this.first_color.Controls.Add(this.red1);
            this.first_color.Location = new System.Drawing.Point(12, 20);
            this.first_color.Name = "first_color";
            this.first_color.Size = new System.Drawing.Size(141, 111);
            this.first_color.TabIndex = 0;
            this.first_color.TabStop = false;
            this.first_color.Text = "Select the First Color";
            // 
            // yellow1
            // 
            this.yellow1.AutoSize = true;
            this.yellow1.Location = new System.Drawing.Point(43, 75);
            this.yellow1.Name = "yellow1";
            this.yellow1.Size = new System.Drawing.Size(56, 17);
            this.yellow1.TabIndex = 2;
            this.yellow1.TabStop = true;
            this.yellow1.Text = "Yellow";
            this.yellow1.UseVisualStyleBackColor = true;
            // 
            // blue1
            // 
            this.blue1.AutoSize = true;
            this.blue1.Location = new System.Drawing.Point(43, 52);
            this.blue1.Name = "blue1";
            this.blue1.Size = new System.Drawing.Size(46, 17);
            this.blue1.TabIndex = 1;
            this.blue1.TabStop = true;
            this.blue1.Text = "Blue";
            this.blue1.UseVisualStyleBackColor = true;
            // 
            // red1
            // 
            this.red1.AutoSize = true;
            this.red1.Checked = true;
            this.red1.Location = new System.Drawing.Point(44, 29);
            this.red1.Name = "red1";
            this.red1.Size = new System.Drawing.Size(45, 17);
            this.red1.TabIndex = 0;
            this.red1.TabStop = true;
            this.red1.Text = "Red";
            this.red1.UseVisualStyleBackColor = true;
            // 
            // second_color
            // 
            this.second_color.Controls.Add(this.red2);
            this.second_color.Controls.Add(this.yellow2);
            this.second_color.Controls.Add(this.blue2);
            this.second_color.Location = new System.Drawing.Point(181, 20);
            this.second_color.Name = "second_color";
            this.second_color.Size = new System.Drawing.Size(151, 111);
            this.second_color.TabIndex = 1;
            this.second_color.TabStop = false;
            this.second_color.Text = "Select the Second Color";
            // 
            // red2
            // 
            this.red2.AutoSize = true;
            this.red2.Checked = true;
            this.red2.Location = new System.Drawing.Point(40, 29);
            this.red2.Name = "red2";
            this.red2.Size = new System.Drawing.Size(45, 17);
            this.red2.TabIndex = 3;
            this.red2.TabStop = true;
            this.red2.Text = "Red";
            this.red2.UseVisualStyleBackColor = true;
            // 
            // yellow2
            // 
            this.yellow2.AutoSize = true;
            this.yellow2.Location = new System.Drawing.Point(40, 75);
            this.yellow2.Name = "yellow2";
            this.yellow2.Size = new System.Drawing.Size(56, 17);
            this.yellow2.TabIndex = 5;
            this.yellow2.TabStop = true;
            this.yellow2.Text = "Yellow";
            this.yellow2.UseVisualStyleBackColor = true;
            // 
            // blue2
            // 
            this.blue2.AutoSize = true;
            this.blue2.Location = new System.Drawing.Point(40, 52);
            this.blue2.Name = "blue2";
            this.blue2.Size = new System.Drawing.Size(46, 17);
            this.blue2.TabIndex = 4;
            this.blue2.TabStop = true;
            this.blue2.Text = "Blue";
            this.blue2.UseVisualStyleBackColor = true;
            // 
            // mix
            // 
            this.mix.Location = new System.Drawing.Point(100, 156);
            this.mix.Name = "mix";
            this.mix.Size = new System.Drawing.Size(75, 23);
            this.mix.TabIndex = 2;
            this.mix.Text = "Mix";
            this.mix.UseVisualStyleBackColor = true;
            this.mix.Click += new System.EventHandler(this.mix_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(181, 156);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 3;
            this.exit.Text = "E&xit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // color_mixer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 192);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.mix);
            this.Controls.Add(this.second_color);
            this.Controls.Add(this.first_color);
            this.Name = "color_mixer";
            this.Text = "Color Mixer";
            this.first_color.ResumeLayout(false);
            this.first_color.PerformLayout();
            this.second_color.ResumeLayout(false);
            this.second_color.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox first_color;
        private System.Windows.Forms.RadioButton yellow1;
        private System.Windows.Forms.RadioButton blue1;
        private System.Windows.Forms.RadioButton red1;
        private System.Windows.Forms.GroupBox second_color;
        private System.Windows.Forms.RadioButton red2;
        private System.Windows.Forms.RadioButton blue2;
        private System.Windows.Forms.RadioButton yellow2;
        private System.Windows.Forms.Button mix;
        private System.Windows.Forms.Button exit;
    }
}

