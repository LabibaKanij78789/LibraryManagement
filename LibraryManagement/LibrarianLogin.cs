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
    public partial class LibrarianLogin : Form
    {
        string[] s = new string[2];
        string[] col = new string[2];
        List<string>[] result = new List<string>[1];
        DBConnect instance = new DBConnect();
        public LibrarianLogin()
        {
            InitializeComponent();
            

        }

        private void LibrarianLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            s[0] = textBox1.Text.ToString();
            s[1] = textBox2.Text.ToString();
            
            col[0] = "Name";
            col[1] = "password";
            int c1 = s[0].Length;
            int c2 = s[1].Length;
            try
            {
                if (c1 == 0 || c2 == 0)
                {
                    MessageBox.Show("Please input first!!");
                }
                else
                {
                    string no = "";
                    instance.OpenConnection();

                    //instance.Insert("user", col, s);
                    result = instance.Select("user", col, false, no);
                    if (result.Any())
                    {
                        MemberPage ob = new MemberPage(s[0]);
                        this.Hide();
                        ob.Show();
                    }

                    else
                    {
                        
                        MessageBox.Show("Wrong input!");
                        
                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
            
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Signup ob = new Signup();
            this.Hide();
            ob.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgetpassword ob = new Forgetpassword();
            this.Hide();
            ob.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
