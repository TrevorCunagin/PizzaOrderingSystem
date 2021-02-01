using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrdering
{
    public partial class Form3 : Form
    {
        public Form3(int cheese, int pepperoni, int sausage, int supreme, double total)
        {
            InitializeComponent();
            label6.Text = cheese.ToString();
            label7.Text = pepperoni.ToString();
            label8.Text = sausage.ToString();
            label9.Text = supreme.ToString();
            label11.Text = total.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }
        //cheese
        private void label6_Click(object sender, EventArgs e)
        {

        }
        //pepperoni
        private void label7_Click(object sender, EventArgs e)
        {

        }
        //sausage
        private void label8_Click(object sender, EventArgs e)
        {

        }
        //supreme
        private void label9_Click(object sender, EventArgs e)
        {

        }

    }
}
