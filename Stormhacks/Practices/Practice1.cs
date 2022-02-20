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
        public Practice1()
        {
            InitializeComponent();
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
                Answer.Text = "Correct";
            }
            else
            {
                Answer.Text = "Wrong! Try Again";
            }
        }

        private void D_btn_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
