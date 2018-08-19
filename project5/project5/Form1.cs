using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project5
{
    public partial class rps_form : Form
    {
        public rps_form()
        {
            InitializeComponent();
        }
        //global variable user
        int user = 0;
        int ran = 0;
        //this code should get a random number for us
        private int GetRandomNumber()
        {
            Random rand = new Random();
            ran = rand.Next(3) + 1;
            return ran;
        }
        //this code will allow us to display an image based on what the random image is.
        private void CpuImage(int ran)
        {
            if (ran == 1)
            {
                computers_choice.Image = rpslist.Images[0];
            }
            else if (ran == 2)
            {
                computers_choice.Image = rpslist.Images[1];
            }
            else
            {
                computers_choice.Image = rpslist.Images[2];
            }
        }
        private void UserImage(int user)
        {
            if (user == 1)
            {
                players_choice.Image = rpslist.Images[0];
            }
            else if (user == 2)
            {
                players_choice.Image = rpslist.Images[1];
            }
            else
            {
                players_choice.Image = rpslist.Images[2];
            }
        }
        private void TheGame(int user, int ran)
        {
            if (user == 1 && ran == 1)
            {
                computers_choice.Visible = true;
                outcome.Text = "Tie!";
               
            }
            else if (user == 1 && ran == 2)
            {
                computers_choice.Visible = true;
                outcome.Text = "You Lose!";
                
            }
            else if (user == 1 && ran == 3)
            {
                computers_choice.Visible = true;
                outcome.Text = "You Win!";
                
            }
            else if (user == 2 && ran == 1)
            {
                computers_choice.Visible = true;
                outcome.Text = "You Win!";
                
            }
            else if (user == 2 && ran == 2)
            {
                computers_choice.Visible = true;
                outcome.Text = "Tie!";
                
            }
            else if (user == 2 && ran == 3)
            {
                computers_choice.Visible = true;
                outcome.Text = "You lose!";
                
            }
            else if (user == 3 && ran == 1)
            {
                computers_choice.Visible = true;
                outcome.Text = "You Lose!";
                
            }
            else if (user == 3 && ran == 2)
            {
                computers_choice.Visible = true;
                outcome.Text = "You Win!";
                
            }
            else if (user == 3 && ran == 3)
            {
                computers_choice.Visible = true;
                outcome.Text = "Tie!";
                
            }
        }
        private void rock_Click(object sender, EventArgs e)
        {
            user = 1; //set the users choice to rock(1) paper(2) or scissors(3).
            UserImage(1); //set the players picturebox image.
            GetRandomNumber(); //get the computers "choice"
            CpuImage(ran); //set the computers picture image
            TheGame(user, ran); //determine the winner!
        }

        private void paper_Click(object sender, EventArgs e)
        {
            user = 2;
            UserImage(2);
            GetRandomNumber();
            CpuImage(ran);
            TheGame(user, ran);
        }

        private void scissors_Click(object sender, EventArgs e)
        {
            user = 3;
            UserImage(3);
            GetRandomNumber();
            CpuImage(ran);
            TheGame(user, ran);
        }
        private void exit_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }
    }
}
