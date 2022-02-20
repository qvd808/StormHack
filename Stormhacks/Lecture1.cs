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
    public partial class Lecture1 : Form
    {
        Practices.Practice1 multiChoice1;
        Form1 frm;
        public Lecture1(Form1 fr)
        {
            InitializeComponent();
            frm = fr;
            multiChoice1 = new Practices.Practice1(this);
        }

        private void Lecture1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            multiChoice1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm.Show();
        }

    }
}
