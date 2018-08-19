namespace project5
{
    partial class rps_form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rps_form));
            this.player_text = new System.Windows.Forms.TextBox();
            this.comp_text = new System.Windows.Forms.TextBox();
            this.rock = new System.Windows.Forms.Button();
            this.paper = new System.Windows.Forms.Button();
            this.scissors = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.players_choice = new System.Windows.Forms.PictureBox();
            this.computers_choice = new System.Windows.Forms.PictureBox();
            this.outcome = new System.Windows.Forms.Label();
            this.rpslist = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.players_choice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computers_choice)).BeginInit();
            this.SuspendLayout();
            // 
            // player_text
            // 
            this.player_text.Location = new System.Drawing.Point(89, 221);
            this.player_text.Name = "player_text";
            this.player_text.Size = new System.Drawing.Size(100, 20);
            this.player_text.TabIndex = 2;
            this.player_text.Text = "Player\'s Choice";
            // 
            // comp_text
            // 
            this.comp_text.Location = new System.Drawing.Point(89, 15);
            this.comp_text.Name = "comp_text";
            this.comp_text.Size = new System.Drawing.Size(100, 20);
            this.comp_text.TabIndex = 3;
            this.comp_text.Text = "Computer\'s Choice";
            // 
            // rock
            // 
            this.rock.Location = new System.Drawing.Point(247, 269);
            this.rock.Name = "rock";
            this.rock.Size = new System.Drawing.Size(75, 23);
            this.rock.TabIndex = 4;
            this.rock.Text = "Rock";
            this.rock.UseVisualStyleBackColor = true;
            this.rock.Click += new System.EventHandler(this.rock_Click);
            // 
            // paper
            // 
            this.paper.Location = new System.Drawing.Point(247, 322);
            this.paper.Name = "paper";
            this.paper.Size = new System.Drawing.Size(75, 23);
            this.paper.TabIndex = 5;
            this.paper.Text = "Paper";
            this.paper.UseVisualStyleBackColor = true;
            this.paper.Click += new System.EventHandler(this.paper_Click);
            // 
            // scissors
            // 
            this.scissors.Location = new System.Drawing.Point(247, 375);
            this.scissors.Name = "scissors";
            this.scissors.Size = new System.Drawing.Size(75, 23);
            this.scissors.TabIndex = 6;
            this.scissors.Text = "Scissors";
            this.scissors.UseVisualStyleBackColor = true;
            this.scissors.Click += new System.EventHandler(this.scissors_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(423, 400);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 8;
            this.exit.Text = "E&xit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // players_choice
            // 
            this.players_choice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.players_choice.Location = new System.Drawing.Point(35, 247);
            this.players_choice.MaximumSize = new System.Drawing.Size(232, 256);
            this.players_choice.Name = "players_choice";
            this.players_choice.Size = new System.Drawing.Size(206, 176);
            this.players_choice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.players_choice.TabIndex = 1;
            this.players_choice.TabStop = false;
            // 
            // computers_choice
            // 
            this.computers_choice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.computers_choice.Location = new System.Drawing.Point(35, 39);
            this.computers_choice.MaximumSize = new System.Drawing.Size(232, 256);
            this.computers_choice.Name = "computers_choice";
            this.computers_choice.Size = new System.Drawing.Size(206, 176);
            this.computers_choice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.computers_choice.TabIndex = 0;
            this.computers_choice.TabStop = false;
            // 
            // outcome
            // 
            this.outcome.Location = new System.Drawing.Point(420, 322);
            this.outcome.Name = "outcome";
            this.outcome.Size = new System.Drawing.Size(75, 23);
            this.outcome.TabIndex = 10;
            this.outcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rpslist
            // 
            this.rpslist.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("rpslist.ImageStream")));
            this.rpslist.TransparentColor = System.Drawing.Color.Transparent;
            this.rpslist.Images.SetKeyName(0, "rock.jpg");
            this.rpslist.Images.SetKeyName(1, "paper.jpg");
            this.rpslist.Images.SetKeyName(2, "Scissors.jpg");
            // 
            // rps_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 435);
            this.Controls.Add(this.outcome);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.scissors);
            this.Controls.Add(this.paper);
            this.Controls.Add(this.rock);
            this.Controls.Add(this.comp_text);
            this.Controls.Add(this.player_text);
            this.Controls.Add(this.players_choice);
            this.Controls.Add(this.computers_choice);
            this.Name = "rps_form";
            this.Text = "Rock, Paper, Scissors!";
            ((System.ComponentModel.ISupportInitialize)(this.players_choice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computers_choice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox computers_choice;
        private System.Windows.Forms.PictureBox players_choice;
        private System.Windows.Forms.TextBox player_text;
        private System.Windows.Forms.TextBox comp_text;
        private System.Windows.Forms.Button rock;
        private System.Windows.Forms.Button paper;
        private System.Windows.Forms.Button scissors;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label outcome;
        private System.Windows.Forms.ImageList rpslist;
    }
}

