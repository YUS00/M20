﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace timer
{
    public partial class Form1 : Form
    {
        public Form1()

        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
            }else
            {
                timer1.Stop();
                SEGON fm2 = new SEGON();
                fm2.Show();
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void progressBar1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
