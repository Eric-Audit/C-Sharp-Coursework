using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project7
{
    public partial class wordcounter : Form
    {
        public wordcounter()
        {
            InitializeComponent();
            userInput.Focus(); //set the focus.
        }
        
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close(); // exit button.
        }
        private int wordSearch(string s)
        {
            s = s.Trim(); //remove leading and trailing spaces.
            int index = 0;
            int words = 1;
            if(s.Length == 0) //if the user enters nothing this will catch it.
            {
                words = 0;
                return words;
            }
            else
            
            while (index < s.Length) //this searches my entire string.
            {
                if (s[index] == ' ')
                {
                    words++; //im counting words by spaces
                }
                index++;
            }
            return words;
        }
        private double letterSearch(string s, int words)
        {
            s = s.Trim();
            double letters;
            if (s.Length == 0)
            {
                letters = 0;
                return words;
            }
            else
                letters = s.Count(char.IsLetter) / (double) words;
                letters = Math.Round(letters, 1);
            return letters;
        }

        private void accept_Click(object sender, EventArgs e)
        {
            string selection;
            selection = userInput.Text;
            int words = wordSearch(selection);
            double letters = letterSearch(selection, words);
            output.Text = "The number of words is " + words + " and the average \n" +
                "number of leters in each world is " + letters;

        }

        private void clear_Click(object sender, EventArgs e)
        {
            userInput.Clear();
            userInput.Focus();
            output.Text = "";
        }
    }
}
