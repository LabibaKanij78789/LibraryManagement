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
using static LibraryManagement.DBConnect;
namespace LibraryManagement
{
    public partial class LibrarianLogin : Form
    {
        string query;
        DBConnect db = new DBConnect();
        public LibrarianLogin()
        {
            InitializeComponent();
            



        }
        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J2E5UDC\SQLEXPRESS;Initial Catalog=lms;Integrated Security=True");


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



                //con.Open();
                query = " WHERE username='" + username + "' AND password='" + password + "';";
                //SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                //List<List<string>> result = new List<List<string>>();
                //result = db.selectSearch
                //DataTable dt = new DataTable();
                //SDA.Fill(dt);
                if (db.SelectAll("librarian", query))
                {
                    Progressbar ob = new Progressbar();
                    this.Hide();
                    ob.Show();
                }
                else
                {
                    MessageBox.Show("Invalid input");
                }


               // con.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
