using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LibraryManagement.DBConnect;
namespace LibraryManagement
{
    public partial class mainpage : Form
    {
        Graphics g;
        Image dot, bell, noti;
        DBConnect db = new DBConnect();
        public mainpage()
        {
            InitializeComponent();
            pictureBox8.BackColor = Color.Transparent;
            
            //label4.Parent = pictureBox8;
            
            //label4.BackColor = Color.Transparent;
            label4.Show();
            label4.BringToFront();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                cb1.Visible = true;
              
                
            }catch (Exception ex) { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                String s;
                s = cb1.Items[cb1.SelectedIndex].ToString();
                if(s=="LOG OUT")
                {
                    Form1 ob = new Form1();this.Hide();ob.Show();
                }
                if (s == "EXIT")
                {
                    // LibrarianLogin ob = new LibrarianLogin(); this.Hide(); ob.Show();
                   Application.Exit();
                }

            }
            catch (Exception ex) { }
        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Visible = true;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewBook ob = new NewBook();
            this.Hide();
            ob.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewStudent ob = new NewStudent();
            this.Hide();
            ob.Show();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //NotifyIcon notify = new NotifyIcon();
            
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Librarian_Side.l_noti().Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void mainpage_Load(object sender, EventArgs e)
        {
            string query = " where completed = '0'";
            int noti_val = db.CountCon("notifications", query);
            label4.Text = " " + noti_val.ToString() + " ";
            if(noti_val == 0)
            {
                linkLabel6.Enabled = false;
                pictureBox5.Enabled = false;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Survey().Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox9_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
