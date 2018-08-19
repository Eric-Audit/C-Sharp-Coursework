using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project3
{
    public partial class color_mixer : Form
    {
        public color_mixer()
        {
            InitializeComponent();
        }
        private void mix_Click(object sender, EventArgs e)
        {
            if (red1.Checked && red2.Checked)
            {
                this.BackColor = Color.Red;
            }
            else if (red1.Checked && blue2.Checked)
            {
                this.BackColor = Color.Purple;
            }
            else if (red1.Checked && yellow2.Checked)
            {
                this.BackColor = Color.Orange;
            }
            else if (blue1.Checked && red2.Checked)
            {
                this.BackColor = Color.Purple;
            }
            else if (blue1.Checked && blue2.Checked)
            {
                this.BackColor = Color.Blue;
            }
            else if (blue1.Checked && yellow2.Checked)
            {
                this.BackColor = Color.Green;
            }
            else if (yellow1.Checked && red2.Checked)
            {
                this.BackColor = Color.Orange;
            }
            else if (yellow1.Checked && blue2.Checked)
            {
                this.BackColor = Color.Green;
            }
            else if (yellow1.Checked && yellow2.Checked)
            {
                this.BackColor = Color.Yellow;
            }
            else
            {
                MessageBox.Show("Please select two colors.");
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            //Close the form
            this.Close();
        }
    }
}
