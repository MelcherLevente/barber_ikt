﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mainForm.Forms;

namespace mainForm
{
    public partial class Form1 : Form
    {
        public static Panel Mainpanel;
        public Form1()
        {
            InitializeComponent();
            Mainpanel = panel1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            homepage homepage = new homepage();
            homepage.Dock = DockStyle.Fill;
            homepage.TopLevel = false;
            panel1.Controls.Clear();
            panel1.Controls.Add(homepage);
            homepage.Show();
        }
    }
}
