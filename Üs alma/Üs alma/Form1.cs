﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Üs_alma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIsle_Click(object sender, EventArgs e)
        {
            double X, y, z;

            X = Convert.ToInt32(textBox1.Text);
            y = Convert.ToInt32(textBox2.Text);
            z = Math.Pow(X, y);
            lblSonuc.Text = z.ToString();
        }
    }
}
