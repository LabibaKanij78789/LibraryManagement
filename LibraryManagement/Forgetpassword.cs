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
using System.Windows.Documents;
using static LibraryManagement.DBConnect;
namespace LibraryManagement
{
    public partial class Forgetpassword : Form
    {
        DBConnect db = new DBConnect();
        
        public Forgetpassword()
        {
            InitializeComponent();

        }
        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J2E5UDC\SQLEXPRESS;Initial Catalog=lms;Integrated Security=True");

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
                //name = txtlibname.Text;
                security = txtsecurity.Text;
                password = txtpassword.Text;
                answer = txtanswer.Text;
                //con.Open();
                List<List<string> > result = new List<List<string>>();
                String query1 = "SELECT id, name, security FROM Librarian WHERE name='" + username + "';";
                //SqlCommand cmd1 = new SqlCommand(query1, con);
                //SqlDataReader dr1 = cmd1.ExecuteReader();
                string[] colStrings = new[] {"id", "name", "security"};
                result = db.selectSearch(query1, colStrings );
                //if (dr1.Read())
                //{
                //    txtlibname.Text = (dr1["libname"].ToString());

                //    txtsecurity.Text = (dr1["securityquestion"].ToString());
                int i = 0;

                foreach (List<string> s in result)
                {
                    foreach (string r in s)
                    {
                        colStrings[i] = r;
                        i++;
                    }
                }

                //}

                //dr1.Close();
                //con.Close();
                

            } catch (Exception ex)
            { }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            try {
                String libid = null, libtimeid = null;

                //con.Open();
                String query1 = "SELECT id, time_id FROM Librarian WHERE name = '" + txtusername.Text + "';";
                //SqlCommand cmd = new SqlCommand(query1, con);
                //SqlDataReader dr1 = cmd.ExecuteReader();
                //if (dr1.Read())
                //{
                //    libid = (dr1["libid"].ToString());
                //    libtimeid = (dr1["libtimeid"].ToString());
                //}
                //dr1.Close();
                string[] col = new[] {"id", "time_id"};
                List<List<string> > result = new List<List<string>>();
                result = db.selectSearch(query1, col);
                int i = 0;

                foreach (List<string> s in result)
                {
                    foreach (string r in s)
                    {
                        col[i] = r;
                        i++;
                    }
                }
                String query2 = "SELECT password FROM Librarian WHERE answer ='" + txtanswer.Text + "' id= '" + col[0] + "' and time_id = '"+col[1]+"';";
                string[] col1 = new[] { "password"};
                List<List<string>> result1 = new List<List<string>>();
                result = db.selectSearch(query2, col1);
                foreach (List<string> s in result1)
                {
                    foreach (string r in s)
                    {
                        txtpassword.Text = r;
                        i++;
                    }
                }
                //SqlCommand cmd2 = new SqlCommand(query2, con);
                //SqlDataReader dr2 = cmd2.ExecuteReader();
                //if (dr2.Read())
                //{
                //    txtpassword.Text = (dr2["userpassword"].ToString());
                //}
                //dr2.Close();
                //con.Close();
            }
            catch (Exception ex) { }
        }
    }
}
