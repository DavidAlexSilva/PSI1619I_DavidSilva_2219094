﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H_Brains
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new Form3().Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            new Form4().Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            new Form5().Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Form12().Show();
        }
    }
}
