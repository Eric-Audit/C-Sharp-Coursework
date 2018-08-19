using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project6
{
    public partial class namePopularity : Form
    {
        public namePopularity()
        {
            InitializeComponent();
            userInput.Focus();
        }
        //This is my exit button
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //this function fills an array with the boynames file and returns it
        private string[] getboys()
        {
            try
            { 
                const int NAMES = 200;
                string[] boys = new string[NAMES];
                int counterb = 0;
                StreamReader inputFileb;
                inputFileb = File.OpenText("BoyNames.txt");
                while (counterb < boys.Length && !inputFileb.EndOfStream)
                {
                boys[counterb] = inputFileb.ReadLine();
                counterb++;
                }
                inputFileb.Close();
                return boys;
            }
            catch (Exception ex)
            {
                string[] boys = new string[1]; 
                MessageBox.Show(ex.Message); //I figure it doesn't matter if i return something because this will stop the program.
                return boys; //felt silly to return boys, but i had to or VS yelled at me.
            }
        }
        //this function fills an array with the boynames file and returns it
        private string[] getgirls()
        {
            try
            {
                const int NAMES = 200;
                string[] girls = new string[NAMES];
                int counterg = 0;
                StreamReader inputFileg;
                inputFileg = File.OpenText("GirlNames.txt");
                while (counterg < girls.Length && !inputFileg.EndOfStream)
                {
                    girls[counterg] = inputFileg.ReadLine();
                    counterg++;
                }
                inputFileg.Close();
                return girls;
            }
            catch (Exception ex)
            {
                string[] girls = new string[1];
                MessageBox.Show(ex.Message);
                return girls;
            }
        }
        //this function searches through the array and user input to compare them
        private int SequentialSearch(string[] sArray, string value)
        {
            bool found = false;
            int index = 0;
            int position = -1;
            while (!found && index < sArray.Length) //this searches my entire array
            {
                if (sArray[index].ToLower() == value.ToLower()) //all i had to include was the .ToLower method to get free extra points. easy.
                {
                    found = true;
                    position = index;
                }
                index++;
            }
            return position; //returns a simple 0 or -1 so my if statement can execute
        }
        private void accept_Click(object sender, EventArgs e) //enter key works this time!
        {
            string selection;
            selection = userInput.Text; //get my user input
            string[] boys = getboys(); //function calls
            string[] girls = getgirls();
            if (SequentialSearch(boys, selection) != -1) //pass my arrays through the compare function
            {
                result.Text = "This is a popular boy name.";
            }
            else if (SequentialSearch(girls, selection) != -1)
            {
                result.Text = "This is a popular girl name.";
            }
            else
            {
                result.Text = "This is not a popular name.";
            }
            userInput.Focus();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            userInput.Clear();
            userInput.Focus();
        }
    }
}
