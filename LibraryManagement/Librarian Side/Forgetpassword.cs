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
using System.Data.SqlClient;
namespace LibraryManagement
{
    public partial class Forgetpassword : Form
    {
        string username, name, security, password, answer, time_id, id;
        public Forgetpassword()
        {
            InitializeComponent();
        }
        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J2E5UDC\SQLEXPRESS;Initial Catalog=lms;Integrated Security=True");
        DBConnect db = new DBConnect();
        //string id, security, name, time_id, pass;
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

                

                username = txtusername.Text;
                //name = txtlibname.Text;
                //security = txtsecurity.Text;
                //password = txtpassword.Text;
                //answer = txtanswer.Text;
                //con.Open();
                string[] col = new[] { "id", "name", "security", "time_id" };
                String query1 = "SELECT id, name,security, time_id FROM Librarian WHERE username='" + username + "';";
                //SqlCommand cmd1 = new SqlCommand(query1, con);
                List<List<string>> result = new List<List<string>>();
                int i;
                result = db.selectSearch(query1, col);
                
                //foreach(List<string> s in result)
                //{
                //    i = 0;
                //    foreach(string r in s)
                //    {
                //        col[i] = r;
                //    }
                //}
                id = result[0][0];
                name = result[0][1];
                security = result[0][2];
                time_id = result[0][3];
                txtlibname.Text = name;
                txtsecurity.Text = security;
                //SqlDataReader dr1 = cmd1.ExecuteReader();
                //if (dr1.Read())
                //{
                //    txtlibname.Text = (dr1["libname"].ToString());

                //    txtsecurity.Text = (dr1["securityquestion"].ToString());




                //}

                //dr1.Close();
                //con.Close();


            } catch (Exception ex)
            { }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            try {
                //String libid = null, libtimeid = null;

                //con.Open();
                //String query1 = "SELECT timeid FROM Librarian WHERE libname='" + txtlibname.Text + "'AND username='" + txtusername.Text + "'; ";
                //SqlCommand cmd = new SqlCommand(query1, con);
                //SqlDataReader dr1 = cmd.ExecuteReader();
                //if (dr1.Read())
                //{
                //    libid = (dr1["libid"].ToString());
                //    libtimeid = (dr1["libtimeid"].ToString());
                //}
                //dr1.Close();

                String query2 = "SELECT password FROM Librarian WHERE answer = '" + txtanswer.Text + "' AND id='" + id + "' AND time_id='" + time_id + "';";
                //SqlCommand cmd2 = new SqlCommand(query2, con);
                //SqlDataReader dr2 = cmd2.ExecuteReader();
                //if (dr2.Read())
                //{
                //    txtpassword.Text = (dr2["userpassword"].ToString());
                //}
                //dr2.Close();
                //con.Close();
                string[] col = new[] { "password" };
                List<List<string>> result = new List<List<string>>();
                result = db.selectSearch(query2, col);
                //int i;
                //foreach (List<string> s in result)
                //{
                //    i = 0;
                //    foreach (string r in s)
                //    {
                //        col[i] = r;
                //    }
                //}
                password =result[0][0];
                txtpassword.Text = password;
            }
            catch (Exception ex)
            {
            }
        }
    }
}
