using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace LibraryManagement
{
    public partial class LibrarianLogin : Form
    {
        public LibrarianLogin()
        {
            InitializeComponent();
            



        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J2E5UDC\SQLEXPRESS;Initial Catalog=lms;Integrated Security=True");


        private void LibrarianLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String username;
                String password, counter = null;
                username = txtusername.Text;
                password = txtpassword.Text;



                con.Open();
                String query = "SELECT count(*) FROM Librarian WHERE username='" + username + "' AND userpassword='" + password + "';";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                SDA.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    Progressbar ob = new Progressbar();
                    this.Hide();
                    ob.Show();
                }
                else
                {
                    MessageBox.Show("Invalid input");
                }


                con.Close();
            }catch(Exception ex)
            {

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
    }
}
