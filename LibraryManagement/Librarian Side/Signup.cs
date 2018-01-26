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
    public partial class Signup : Form
    {
        List<Panel> Panel = new List<Panel>();
        int item = 0;
        public Signup()
        {
            InitializeComponent();
            Panel.Add(panel1);
            Panel.Add(panel2);
            Panel[item].BringToFront();
        }
        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J2E5UDC\SQLEXPRESS;Initial Catalog=lms;Integrated Security=True");
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(item<Panel.Count-1)
                {
                    Panel[++item].BringToFront();
                }
                else
                {
                    MessageBox.Show("No available pages ");
                }

            }catch(Exception ex)
            {
                MessageBox.Show("No available page");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if(item>0)
                {
                    Panel[--item].BringToFront();
                }
                else
                {
                    MessageBox.Show("No available pages ");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("No available pages ");
            }

        }
        DBConnect db = new DBConnect();
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                LibrarianLogin ob = new LibrarianLogin();
                this.Hide();
                ob.Show();
            }
            catch(Exception ex)
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                String id1, name, contract, timeid1, username, password, security, answer;
                id1 = txtlibid.Text;
                name = txtlibname.Text;
                contract = txtlibcontact.Text;
                timeid1 = txtlibtimeid.Text;
                username = txtusername.Text;
                password = txtuserpassword.Text;
                security = comboboxsecurity.Text;
                answer = txtanswer.Text;
                int id, timeid;
                string[] col = new[] { "name", "contract", "time_id", "username", "password", "security", "answer" };
                string[] val = new[] { name, contract, timeid1, username, password, security, answer };
                id = Convert.ToInt32(id1);
                timeid = Convert.ToInt32(timeid1);
                if (id1.Length != 0 && name.Length != 0 && contract.Length != 0 && timeid1.Length != 0 && username.Length != 0 && password.Length != 0 && security.Length != 0 && answer.Length != 0)
                {
                    //con.Open();
                    String query = "INSERT INTO Librarian (name, contract, time_id,username, password,security,answer) Values('" + name + "','" + contract + "', '" + timeid + "','" + username + "','" + password + "','" + security + "','" + answer + "');";
                    //SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                    db.Insert("librarian", col, val);
                    //SDA.SelectCommand.ExecuteNonQuery();
                    MessageBox.Show("Welcome Librarian");
                    //con.Close();
                }
                else
                {
                    MessageBox.Show("Enter Information properly");
                }
            }catch(Exception ex) { }
        }
    }
}
