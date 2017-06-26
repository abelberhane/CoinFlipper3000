using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinFlipper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //This is where we create the random logic to pick a random number.
        private static Random rand = new Random();

        //The Flip logic stating the randoms choice is between 0 or 1. Then giving true or false values for them.
        private bool Flip()
        {
            int number = rand.Next(0, 2);
            if (number == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //Here we assign the labels values of 0 to start. 
        private void Form1_Load(object sender, EventArgs e)
        {
            lblHeads.Text = "0";
            lblTails.Text = "0";
        }

        //The button logic to increment the Flip Counters based on if isHeads is true. If the rand above decides its heads, we increment Heads. If not, Tails.
        private void button1_Click(object sender, EventArgs e)
        {
            bool isHeads = Flip();
            if (isHeads)
            {
                lblHeads.Text = (int.Parse(lblHeads.Text) + 1).ToString();
            }
            else
            {
                lblTails.Text = (int.Parse(lblTails.Text) + 1).ToString();
            }
        }
    }
}
