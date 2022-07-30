using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class GuestCheckin : Form
    {
        public GuestCheckin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reservation2 Rn2 = new Reservation2();
            Rn2.Show();
        }

        private void GuestCheckin_Load(object sender, EventArgs e)
        {

        }
    }
}
