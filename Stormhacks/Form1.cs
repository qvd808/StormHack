using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stormhacks
{
    public partial class Form1 : Form
    {
        Lecture1 lec1;
        Lecture2 lec2;
        Lecture3 lec3;
        Lecture4 lec4;
        Lecture5 lec5;
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
            lec1 = new Lecture1(this);
            lec2 = new Lecture2(this);
            lec3 = new Lecture3(this);
            lec4 = new Lecture4(this);
            lec5 = new Lecture5(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            lec1.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            lec2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            lec3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            lec4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            lec5.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
