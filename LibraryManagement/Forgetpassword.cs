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
    public partial class Forgetpassword : Form
    {
        public Forgetpassword()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J2E5UDC\SQLEXPRESS;Initial Catalog=lms;Integrated Security=True");

        private void button3_Click(object sender, EventArgs e)
        {
            LibrarianLogin ob = new LibrarianLogin();
            this.Hide();
            ob.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                String username, name, security, password, answer;

                username = txtusername.Text;
                name = txtlibname.Text;
                security = txtsecurity.Text;
                password = txtpassword.Text;
                answer = txtanswer.Text;
                con.Open();
                String query1 = "SELECT libid,libname,securityquestion FROM Librarian WHERE username='" + username + "';";
                SqlCommand cmd1 = new SqlCommand(query1, con);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                if (dr1.Read())
                {
                    txtlibname.Text = (dr1["libname"].ToString());

                    txtsecurity.Text = (dr1["securityquestion"].ToString());




                }

                dr1.Close();
                con.Close();


            } catch (Exception ex)
            { }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            try {
                String libid = null, libtimeid = null;

                con.Open();
                String query1 = "SELECT libid,libtimeid FROM Librarian WHERE libname='" + txtlibname.Text + "'AND username='" + txtusername.Text + "'; ";
                SqlCommand cmd = new SqlCommand(query1, con);
                SqlDataReader dr1 = cmd.ExecuteReader();
                if (dr1.Read())
                {
                    libid = (dr1["libid"].ToString());
                    libtimeid = (dr1["libtimeid"].ToString());
                }
                dr1.Close();

                String query2 = "SELECT userpassword FROM Librarian WHERE answer='" + txtanswer.Text + "' AND libid='" + libid + "' AND libtimeid='" + libtimeid + "';";
                SqlCommand cmd2 = new SqlCommand(query2, con);
                SqlDataReader dr2 = cmd2.ExecuteReader();
                if (dr2.Read())
                {
                    txtpassword.Text = (dr2["userpassword"].ToString());
                }
                dr2.Close();
                con.Close();
            }
            catch (Exception ex) { }
        }
    }
}
