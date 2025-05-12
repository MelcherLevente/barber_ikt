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
            dateTimePicker1.Format = DateTimePickerFormat.Short;

            
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
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string barber = "";
            listBox1.Items.Clear();
            if (radioButton1.Checked) 
            {
                barber = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                barber = radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                barber = radioButton3.Text;
            }
            else if (radioButton4.Checked)
            {
                barber = radioButton4.Text;
            }
            else
            {
                MessageBox.Show("Nem választottál borbélyt");
            }

            if (comboBox1.Text != "" && barber != "")
            {
                listBox1.Items.Add($"Borbély: " + barber);
                listBox1.Items.Add("Hajhossz: " + comboBox1.Text);
            }
            else
            {
                MessageBox.Show("Nem választottál hajhosszt");
            }
            if (listBox1.Items.Count == 2)
            {
                if (checkBox1.Checked) 
                {
                    listBox1.Items.Add("Szakáll: igen");
                }
                else
                {
                    listBox1.Items.Add("Szakáll: nem");
                }

                listBox1.Items.Add(dateTimePicker1.Value.ToShortDateString());
                listBox1.Items.Add(dateTimePicker2.Value.Hour + ":" + dateTimePicker2.Value.Minute);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 5)
            {
                confirm ok = new confirm();
                ok.Dock = DockStyle.Fill;
                ok.TopLevel = false;
                Form1.Mainpanel.Controls.Clear();
                Form1.Mainpanel.Controls.Add(ok);
                ok.Show();
            }
            else
            {
                MessageBox.Show("Hiba");
            }
        }
    }
}
