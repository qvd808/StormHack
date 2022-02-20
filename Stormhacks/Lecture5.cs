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
    public partial class Lecture5 : Form
    {
        Form1 frm;
        Practices.Practice5 pr5;
        public Lecture5(Form1 fr)
        {
            InitializeComponent();
            frm = fr;
            pr5 = new Practices.Practice5(this);
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            pr5.Show();
        }
    }
}
