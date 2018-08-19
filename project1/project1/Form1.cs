using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1
{
    public partial class project1 : Form
    {
        public project1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Star1.Text = "Betelgeuse";
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Star2.Text = "Meissa";
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Star3.Text = "Alnitak";
        }

        private void Star4_Click(object sender, EventArgs e)
        {
            Star4.Text = "Alnilam";
        }

        private void Star5_Click(object sender, EventArgs e)
        {
            Star5.Text = "Mintaka";
        }

        private void Star6_Click(object sender, EventArgs e)
        {
            Star6.Text = "Saiph";
        }

        private void Star7_Click(object sender, EventArgs e)
        {
            Star7.Text = "Rigel";
        }

        private void ShowStars_Click(object sender, EventArgs e)
        {
            Star1.Visible = true;
            Star2.Visible = true;
            Star3.Visible = true;
            Star4.Visible = true;
            Star5.Visible = true;
            Star6.Visible = true;
            Star7.Visible = true;
        }

        private void HideStars_Click(object sender, EventArgs e)
        {
            Star1.Visible = false;
            Star2.Visible = false;
            Star3.Visible = false;
            Star4.Visible = false;
            Star5.Visible = false;
            Star6.Visible = false;
            Star7.Visible = false;
        }

        private void ExitProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
