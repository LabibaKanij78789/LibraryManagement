using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class Issuebook : Form
    {
        public Issuebook()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainpage ob = new mainpage();
            this.Hide();
            ob.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Visible = true;
            label4.Visible = true;
            label3.Visible = true;
            label7.Visible = true;
            label6.Visible = true;
            label12.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;

            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;
            textBox10.Visible = true;
            textBox11.Visible = true;
            textBox12.Visible = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
