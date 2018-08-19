using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project4
{
    public partial class Form1 : Form
    {
        int count = 1;
        private dynamic random_number;
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            random_number = rand.Next(100) + 1;
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            //declare some local variables.
            int user_number; //the user input

            //get the users guess
            if (int.TryParse(Number.Text, out user_number))
            {
                if (user_number > random_number)
                {
                    Outcome.Text = "Too high, try again";
                    count = count + 1;
                    Number.Text = "";
                }
                else if (user_number < random_number)
                {
                    Outcome.Text = "Too low, try again";
                    count = count + 1;
                    Number.Text = "";
                }
                else if (user_number == random_number)
                {
                    Outcome.Text = "You guessed it in: " + count.ToString()
                        + " Attempts! Enter a new number to keep playing or hit 'Exit'";
                    Number.Text = "";
                    count = 1;
                    random_number = rand.Next(100) + 1;
                }
            }
            else
            {
                MessageBox.Show("Invalid value, please pick a whole number between 1 and 100, e.g. '1', '45', '66'.");
                Number.Text = "";
            } 
                
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
