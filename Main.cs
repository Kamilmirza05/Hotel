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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void CEObtn_Click(object sender, EventArgs e)
        {
            Reservation rs = new Reservation();
            rs.Show();
        }

       
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reservation2 bn = new Reservation2();
            bn.Show();
        }
    }
}