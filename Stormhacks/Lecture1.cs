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
        Practices1.MultipleChoice1 MP1 = new Practices1.MultipleChoice1();
        public Lecture1()
        {
            InitializeComponent();
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
            MP1.Show();
        }
    }
}
