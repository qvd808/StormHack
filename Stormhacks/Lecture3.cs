﻿using System;
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
    public partial class Lecture3 : Form
    {
        Form1 frm;
        public Lecture3(Form1 fr)
        {
            InitializeComponent();
            frm = fr;
        }

        private void Lecture3_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm.Show();
        }
    }
}
