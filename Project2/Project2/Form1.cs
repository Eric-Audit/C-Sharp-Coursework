using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class Sentence_builder : Form
    {
        //button constants
        const string A_value = "A";
        const string Alow_value = "a";
        const string An_value = "An";
        const string Anlow_value = "an";
        const string The_value = "The";
        const string Thelow_value = "the";
        const string Man_value = "man";
        const string Woman_value = "woman";
        const string Dog_value = "dog";
        const string Cat_value = "cat";
        const string Car_value = "car";
        const string Bicycle_value = "bicycle";
        const string Beautiful_value = "beautiful";
        const string Big_value = "big";
        const string Small_value = "small";
        const string Strange_value = "strange";
        const string Looked_at_value = "looked at";
        const string Rode_value = "rode";
        const string Spoke_to_value = "spoke to";
        const string Laughed_at_value = "laughed at";
        const string Drove_value = "drove";
        const string Space_value = " ";
        const string Period_value = ".";
        const string Exclaimation_value = "!";

        //Field variable to hold the total
        //initialized blank
        private string Total = "";

        public Sentence_builder()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form
            this.Close();
        }

        private void A_button_Click(object sender, EventArgs e)
        {
            Total += A_value;
            Builder_label.Text = Total;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Total += An_value;
            Builder_label.Text = Total;
        }

        private void Button_a_Click(object sender, EventArgs e)
        {
            Total += Alow_value;
            Builder_label.Text = Total;
        }

        private void The_button_Click(object sender, EventArgs e)
        {
            Total += The_value;
            Builder_label.Text = Total;
        }

        private void Button_the_Click(object sender, EventArgs e)
        {
            Total += Thelow_value;
            Builder_label.Text = Total;
        }

        private void Woman_button_Click(object sender, EventArgs e)
        {
            Total += Woman_value;
            Builder_label.Text = Total;
        }

        private void Dog_button_Click(object sender, EventArgs e)
        {
            Total += Dog_value;
            Builder_label.Text = Total;
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            Total = "";
            Builder_label.Text = "";
        }

        private void Cat_button_Click(object sender, EventArgs e)
        {
            Total += Cat_value;
            Builder_label.Text = Total;
        }

        private void Car_button_Click(object sender, EventArgs e)
        {
            Total += Car_value;
            Builder_label.Text = Total;
        }

        private void Bicycle_button_Click(object sender, EventArgs e)
        {
            Total += Bicycle_value;
            Builder_label.Text = Total;
        }

        private void Beautiful_button_Click(object sender, EventArgs e)
        {
            Total += Beautiful_value;
            Builder_label.Text = Total;
        }

        private void Big_button_Click(object sender, EventArgs e)
        {
            Total += Big_value;
            Builder_label.Text = Total;
        }

        private void Small_button_Click(object sender, EventArgs e)
        {
            Total += Small_value;
            Builder_label.Text = Total;
        }

        private void Strange_button_Click(object sender, EventArgs e)
        {
            Total += Strange_value;
            Builder_label.Text = Total;
        }

        private void Looked_at_button_Click(object sender, EventArgs e)
        {
            Total += Looked_at_value;
            Builder_label.Text = Total;
        }

        private void Rode_button_Click(object sender, EventArgs e)
        {
            Total += Rode_value;
            Builder_label.Text = Total;
        }

        private void Spoke_to_button_Click(object sender, EventArgs e)
        {
            Total += Spoke_to_value;
            Builder_label.Text = Total;
        }

        private void Laughed_at_button_Click(object sender, EventArgs e)
        {
            Total += Laughed_at_value;
            Builder_label.Text = Total;
        }

        private void Drove_button_Click(object sender, EventArgs e)
        {
            Total += Drove_value;
            Builder_label.Text = Total;
        }

        private void Space_button_Click(object sender, EventArgs e)
        {
            Total += Space_value;
            Builder_label.Text = Total;
        }

        private void Period_button_Click(object sender, EventArgs e)
        {
            Total += Period_value;
            Builder_label.Text = Total;
        }

        private void Exclaimation_button_Click(object sender, EventArgs e)
        {
            Total += Exclaimation_value;
            Builder_label.Text = Total;
        }

        private void Man_Button_Click(object sender, EventArgs e)
        {
            Total += Man_value;
            Builder_label.Text = Total;
        }
    }
}
