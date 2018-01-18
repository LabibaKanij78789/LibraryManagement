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
    public partial class mainpage : Form
    {
        public mainpage()
        {
            InitializeComponent();
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
            Issuebook ob = new Issuebook();
            this.Hide();
            ob.Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ReturnBook ob = new ReturnBook();
            this.Hide();
            ob.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
