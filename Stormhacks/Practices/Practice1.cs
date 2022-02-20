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
    public partial class Practice1 : Form
    {
        Lecture1 lecture1;
        public Practice1(Lecture1 l1)
        {
            InitializeComponent();
            lecture1 = l1;
        }

        private void A_btn_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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

        private void D_btn_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MultipleChoice1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CorrectAns2.Checked == true)
            {
                Result2.Text = "Correct!!";
            }
            else
            {
                Result2.Text = "Wrong! Try again!";
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (answer.Text == "hello")
            {
                Result3.Text = "Correct!!";
            }
            else
            {
                Result3.Text = "Wrong! Try again!";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            lecture1.Show();
        }

        private void answer_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (answer2.Text == "bye")
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
            if (answer3.Text == "hobby")
            {
                Result5.Text = "Correct!!";
            }
            else
            {
                Result5.Text = "Wrong! Try again!";
            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }
    }
}
