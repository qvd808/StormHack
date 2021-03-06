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
    public partial class Practice3 : Form
    {
        Lecture3 lecture3;
        public Practice3(Lecture3 l3)
        {
            InitializeComponent();
            lecture3 = l3;
            CenterToScreen();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            lecture3.Show();
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (CorrectAns4.Checked == true)
            {
                Result3.Text = "Correct! Congrats!";
            }
            else
            {
                Result3.Text = "Wrong! Try Again!";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (answer.Text == "dancer")
            {
                label4.Text = "Correct!!";
            }
            else
            {
                label4.Text = "Wrong! Try again!";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (answer2.Text == "farmer")
            {
                label6.Text = "Correct!!";
            }
            else
            {
                label6.Text = "Wrong! Try again!";
            }
        }
    }
}
