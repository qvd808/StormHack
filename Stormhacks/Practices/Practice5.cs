using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stormhacks.Practices
{
    public partial class Practice5 : Form
    {
        Lecture5 lecture5;
        public Practice5(Lecture5 l5)
        {
            InitializeComponent();
            lecture5 = l5;
            CenterToScreen();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (CorrectAns.Checked == true)
            {
                Result.Text = "Correct! Congrats!";
            }
            else
            {
                Result.Text = "Wrong! Try Again!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CorrectAns2.Checked == true)
            {
                Result2.Text = "Correct! Congrats!";
            }
            else
            {
                Result2.Text = "Wrong! Try Again!";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CorrectAns3.Checked == true)
            {
                Result3.Text = "Correct! Congrats!";
            }
            else
            {
                Result3.Text = "Wrong! Try Again!";
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            lecture5.Show();
        }

        private void Practice5_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (answer1.Text == "6789")
            {
                Result4.Text = "Correct!!";
            }
            else
            {
                Result4.Text = "Wrong! Try again!";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (answer2.Text == "30145")
            {
                Result5.Text = "Correct!!";
            }
            else
            {
                Result5.Text = "Wrong! Try again!";
            }
        }
    }
}
