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

namespace LibraryManagement.Librarian_Side
{
    public partial class l_noti : Form
    {
        DBConnect db = new DBConnect();
        public l_noti()
        {
            InitializeComponent();
        }
        string query;
        int noti_val;
        private void button2_Click(object sender, EventArgs e)
        {
            mainpage ob = new mainpage();
            this.Hide();
            ob.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Issuebook ob = new Issuebook("borrow");
            this.Hide();
            ob.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Issuebook ob = new Issuebook("borrow");
            this.Hide();
            ob.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Issuebook ob = new Issuebook("buy");
            this.Hide();
            ob.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Issuebook ob = new Issuebook("buy");
            this.Hide();
            ob.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ReturnBook ob = new ReturnBook();
            this.Hide();
            ob.Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ReturnBook ob = new ReturnBook();
            this.Hide();
            ob.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void l_noti_Load(object sender, EventArgs e)
        {
            try
            {
                //issue book
                query = " where completed = '0' and n_type = 'w'";
                noti_val = db.CountCon("notifications", query);
                //MessageBox.Show(noti_val.ToString());
                if(noti_val == 0)
                {
                    label4.Enabled = false;
                    pictureBox2.Enabled = false;
                }
                label4.Text = noti_val.ToString() + " Notifications";
                label4.Show();
                //sell book
                query = " where completed = '0' and n_type = 'y'";
                noti_val = db.CountCon("notifications", query);
                //MessageBox.Show(noti_val.ToString());
                if (noti_val == 0)
                {
                    label1.Enabled = false;
                    pictureBox1.Enabled = false;
                }
                label1.Text = noti_val.ToString() + "  Notifications";
                label1.Show();
                //return book

                query = " where completed = '0' and n_type = 'r'";
                noti_val = db.CountCon("notifications", query);
                //MessageBox.Show(noti_val.ToString());
                if (noti_val == 0)
                {
                    label2.Enabled = false;
                    pictureBox6.Enabled = false;
                }
                label2.Text = noti_val.ToString() + " Notifications";
                label2.Show();
                //booklist

                query = " where completed = '0' and n_type = 'd'";
                noti_val = db.CountCon("notifications", query);
                //MessageBox.Show(noti_val.ToString());
                if (noti_val == 0)
                {
                    label3.Enabled = false;
                    pictureBox3.Enabled = false;
                }
                label3.Text = noti_val.ToString() + " Notifications";
                label3.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
