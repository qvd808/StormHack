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
    public partial class Homepage : Form
    {
        Form1 f1 = new Form1();
        public Homepage()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Start_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            f1.Show();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
