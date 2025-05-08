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
    public partial class newAppointment : Form
    {
        public newAppointment()
        {
            InitializeComponent();
            barbersStyles barber1 = new barbersStyles("barber1", true, 10, true, 5);
            barbersStyles barber2 = new barbersStyles("barber2", true, 7);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Hosszúhaj");
            comboBox1.Items.Add("Rövidhaj");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Rövidhaj");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Rövidhaj");
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Hosszúhaj");
            comboBox1.Items.Add("Rövidhaj");
        }

        private void newAppointment_Load(object sender, EventArgs e)
        {
            if (comboBox1.SelectedText == "Hosszúhaj")
            {
                label1.Text = "Ár : 5000Ft";
            }
            else if (comboBox1.SelectedText == "Rövidhaj")
            {
                label1.Text = "Ár : 3500Ft";
            }
        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            if (comboBox1.SelectedText == "Hosszúhaj")
            {
                label1.Text = "Ár : 5000Ft";
            }
            else if (comboBox1.SelectedText == "Rövidhaj")
            {
                label1.Text = "Ár : 3500Ft";
            }
        }
    }
}
