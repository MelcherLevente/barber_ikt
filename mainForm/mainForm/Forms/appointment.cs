using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mainForm.Forms
{
    public partial class appointment : Form
    {
        public appointment()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            newAppointment newApp = new newAppointment();
            newApp.Dock = DockStyle.Fill;
            newApp.TopLevel = false;
            Form1.Mainpanel.Controls.Clear();
            Form1.Mainpanel.Controls.Add(newApp);
            newApp.Show();
        }

        private void homebutton_Click(object sender, EventArgs e)
        {
            homepage homepage = new homepage();
            homepage.Dock = DockStyle.Fill;
            homepage.TopLevel = false;
            Form1.Mainpanel.Controls.Clear();
            Form1.Mainpanel.Controls.Add(homepage);
            homepage.Show();
        }
    }
}
