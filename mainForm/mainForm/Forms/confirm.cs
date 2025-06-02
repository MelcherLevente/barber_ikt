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
                    conn.Open();
                    //sql parancs – visszatérési érték nincs!!!
                    string guestCount = $"SELECT count(*) FROM `guests` WHERE name='{name}' and tel={tel}";
                    MySqlCommand Count = new MySqlCommand(guestCount, conn);
                    int result = Convert.ToInt32(Count.ExecuteScalar());
                    
                    if (result == 0)
                    {
                        string newGuestInsert = $"INSERT INTO guests (name, tel) VALUES ('{name}', {tel})";
                        MySqlCommand cmdNGInsert = new MySqlCommand(newGuestInsert, conn);
                        cmdNGInsert.ExecuteNonQuery();

                        string newGuest = $"SELECT MAX(id) FROM guests";
                        MySqlCommand newGuestSelect = new MySqlCommand(newGuest, conn);
                        MySqlDataReader rdr1 = newGuestSelect.ExecuteReader();
                        while (rdr1.Read())
                        {
                            //MessageBox.Show($"{rdr1[0]}");
                        }
                        string newAppInsert = $"UPDATE `appointments` SET `guestID`={rdr1[0]}, `uzenet`='{msg}' WHERE id=(SELECT MAX(id) FROM appointments);"; //TALAN JO
                        rdr1.Close();
                        MySqlCommand cmdNGUpdate = new MySqlCommand(newAppInsert, conn);
                        cmdNGUpdate.ExecuteNonQuery();
                        MessageBox.Show("Sikeres foglalás");

                        homepage homepage = new homepage();
                        homepage.Dock = DockStyle.Fill;
                        homepage.TopLevel = false;
                        Form1.Mainpanel.Controls.Clear();
                        Form1.Mainpanel.Controls.Add(homepage);
                        homepage.Show();
                    }
                    else if (result == 1)
                    {
                        string oldGuest = $"SELECT id FROM guests WHERE name='{name}' and tel={tel}";
                        MySqlCommand oldGuestSelect = new MySqlCommand(oldGuest, conn);
                        MySqlDataReader rdr2 = oldGuestSelect.ExecuteReader();
                        while (rdr2.Read())
                        {
                            //MessageBox.Show($"{rdr2[0]}");
                        }
                        string oldAppInsert = $"UPDATE `appointments` SET `guestID`={rdr2[0]}, `uzenet`='{msg}' WHERE id=(SELECT MAX(id) FROM appointments);"; //COMMIT
                        rdr2.Close();
                        MySqlCommand cmdOGUpdate = new MySqlCommand(oldAppInsert, conn);
                        cmdOGUpdate.ExecuteNonQuery();
                        MessageBox.Show("Sikeres foglalás");

                        homepage homepage = new homepage();
                        homepage.Dock = DockStyle.Fill;
                        homepage.TopLevel = false;
                        Form1.Mainpanel.Controls.Clear();
                        Form1.Mainpanel.Controls.Add(homepage);
                        homepage.Show();
                    }
                    else
                    {
                        MessageBox.Show("Hiba");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                conn.Close();
            }
            else
            {
                MessageBox.Show("Hiba");
            }
        }
    }
}
