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
    public partial class Practice2 : Form
    {
        Lecture2 lecture2;
        public Practice2(Lecture2 l2)
        {
            InitializeComponent();
            lecture2 = l2;
            CenterToScreen();
        }

        private void submit1_Click(object sender, EventArgs e)
        {
            if(CorrectAns1.Checked == true)
            {
                Result1.Text = "Correct!!!";
                submit1.Visible = false;
            } else
            {
                Result1.Text = "Wrong! Try again";
            }
        }

        private void submit2_Click(object sender, EventArgs e)
        {
            if (CorrectAns2.Checked == true)
            {
                Result2.Text = "Correct!!!";
                submit2.Visible = false;
            }
            else
            {
                Result2.Text = "Wrong! Try again";
            }
        }

        private void submit3_Click(object sender, EventArgs e)
        {
            if (CorrectAns3.Checked == true)
            {
                Result3.Text = "Correct!!!";
                submit3.Visible = false;
            }
            else
            {
                Result3.Text = "Wrong! Try again";
            }
        }


        private void submit4_Click(object sender, EventArgs e)
        {
            if (CorrectAns4.Checked == true)
            {
                Result4.Text = "Correct!!!";
                submit4.Visible = false;
            }
            else
            {
                Result4.Text = "Wrong! Try again";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (answer1.Text == "name")
            {
                Result5.Text = "Correct!!";
            }
            else
            {
                Result5.Text = "Wrong! Try again!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (answer2.Text == "siro")
            {
                Result6.Text = "Correct!!";
            }
            else
            {
                Result6.Text = "Wrong! Try again!";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            lecture2.Show();
        }

        private void Practice2_Load(object sender, EventArgs e)
        {

        }
    }
}
