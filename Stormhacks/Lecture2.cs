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
    public partial class Lecture2 : Form
    {
        Practices.Practice2 practice = new Practices.Practice2();
        public Lecture2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            practice.Show();
        }
    }
}
