using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;


namespace mainForm.Forms
{
    public partial class newAppointment : Form
    {
        public static string connStr = "server=localhost;user=root;database=barbershop;port=3306;password=''";
        public static MySqlConnection conn = new MySqlConnection(connStr);
        public newAppointment()
        {
            InitializeComponent();
            comboBox1.Items.Add("Hosszú");
            comboBox1.Items.Add("Rövid");
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
                listBox1.Items.Add(dateTimePicker2.Value);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 4)
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
