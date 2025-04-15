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

        public void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
