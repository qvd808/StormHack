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
    public partial class Form1 : Form
    {
        Lecture1 lec1 = new Lecture1();
        Lecture3 lec3 = new Lecture3();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            lec1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            lec3.Show();
        }
    }
}
