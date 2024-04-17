using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Showroom_Management_System
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 frm9 = new Form9();
            this.Show();
            frm9.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 frm10 = new Form10();
            this.Show();
            frm10.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form11 frm11 = new Form11();
            this.Show();
            frm11.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form12 frm12 = new Form12();
            this.Show();
            frm12.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
