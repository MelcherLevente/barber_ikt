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
    public partial class homepage : Form
    {
        
        public homepage()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            barbers barber = new barbers();
            barber.Dock = DockStyle.Fill;
            barber.TopLevel = false;
            Form1.Mainpanel.Controls.Clear();
            Form1.Mainpanel.Controls.Add(barber);
            barber.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            appointment appointment = new appointment();
            appointment.Dock = DockStyle.Fill;
            appointment.TopLevel = false;
            Form1.Mainpanel.Controls.Clear();
            Form1.Mainpanel.Controls.Add((appointment));
            appointment.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            barbers barber = new barbers();
            barber.Dock = DockStyle.Fill;
            barber.TopLevel = false;
            Form1.Mainpanel.Controls.Clear();
            Form1.Mainpanel.Controls.Add(barber);
            barber.Show();
        }

    }
}
