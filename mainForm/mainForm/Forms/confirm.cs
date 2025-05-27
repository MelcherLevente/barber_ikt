using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace mainForm.Forms
{
    public partial class confirm : Form
    {
        private int timeLeft; // time left in seconds
        private const int countdownTime = 5*60; // 5 minutes in seconds
        public confirm()
        {
            InitializeComponent();
            timeLeft = countdownTime;
            timer1.Interval = 1000; // 1 second
            //timer1.Tick += timer1_Tick;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                UpdateLabel();
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Lejárt a rendelkezésre álló időd!");
                newAppointment newApp = new newAppointment();
                newApp.Dock = DockStyle.Fill;
                newApp.TopLevel = false;
                Form1.Mainpanel.Controls.Clear();
                Form1.Mainpanel.Controls.Add(newApp);
                newApp.Show();
            }
        }

        private void confirm_Load(object sender, EventArgs e)
        {
            UpdateLabel();
            timer1.Start();
        }

        private void UpdateLabel()
        {
            TimeSpan timeSpan = TimeSpan.FromSeconds(timeLeft);
            label1.Text = timeSpan.ToString(@"mm\:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connStr = "server=localhost;user=root;database=barbershop;password=''";
            MySqlConnection conn = new MySqlConnection(connStr);
            string name = textBox2.Text;
            string tel = textBox1.Text;
            string msg = textBox3.Text;
            if (name != "" && tel != "")
            {
                try
                {
                    MessageBox.Show("Connecting to MySQL...");
                    conn.Open();
                    //sql parancs – visszatérési érték nincs!!!
                    string guestInsert = $"INSERT INTO guests (name, tel) VALUES ('{name}', '{tel}')";
                    MySqlCommand cmdGInsert = new MySqlCommand(guestInsert, conn);
                    cmdGInsert.ExecuteNonQuery();

                    string guestSelect = $"SELECT MAX(id) FROM guests";
                    MySqlCommand cmdSelect = new MySqlCommand(guestSelect, conn);
                    MySqlDataReader rdr = cmdSelect.ExecuteReader();
                    while (rdr.Read())
                    {
                        MessageBox.Show($"{rdr[0]}");
                    }
                    string appInsert = $"UPDATE `appointments` SET `guestID`='{rdr[0]}', `uzenet`='{msg}' WHERE MAX(id)";
                    
                    MySqlCommand cmdAInsert = new MySqlCommand(appInsert, conn);
                    rdr.Close();
                    cmdAInsert.ExecuteNonQuery();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                
                conn.Close();
                MessageBox.Show("Done.");
            }
            else
            {
                MessageBox.Show("Hiba");
            }
        }
    }
}
