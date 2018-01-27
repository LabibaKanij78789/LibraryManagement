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
    public partial class Issuebook : Form
    {
        int click = 0;
        string studentid;
        string bookname, g_id;
        
        DBConnect db = new DBConnect();
        public Issuebook()
        {
            InitializeComponent();
            FillCombo();
            //button2.Hide();
            label6.Hide();
            label10.Hide();
            button1.Hide();
            groupBox2.Hide();
        }
        List<List<string>> result = new List<List<string>>();
        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J2E5UDC\SQLEXPRESS;Initial Catalog=lms;Integrated Security=True");
        
        private void button2_Click(object sender, EventArgs e)
        {
            mainpage ob = new mainpage();
            this.Hide();
            ob.Show();
        }
        private void FillCombo()
        {
            //con.Open();
            String query = "SELECT name FROM Newbook1;";
            //SqlCommand cmd = new SqlCommand(query, con);
            //SqlDataReader dr = cmd.ExecuteReader();
            
            //con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {



                //txtstudentname.Visible = true;
                string query =
                    " where inner join grants on borrows.g_id = grants.id inner join user on grants.u_id = user.id " +
                    "where user.name = '" + txtstudentname.Text + "' and borrows.returned = '0'";
                int borrowed = db.CountCon("borrows", query);
                if (borrowed > 5)
                {
                    label6.Show();
                    label6.Text = "Sorry! " + txtstudentname.Text + " has already borrowed " + borrowed.ToString() +
                                  " books!";
                }
                else
                {
                    query =
                        "select grants.id, user.id from grants inner join user on grants.u_id = user.id where user.name = '" +
                        txtstudentname.Text + "' and grants.new = '0' and type = 'w'";
                    result.Clear();
                    result = db.selectSearch(query, new[] {"grants.id", "user.id"});
                    g_id = result[0][0];
                    string u_id = result[0][1];
                    groupBox2.Show();
                    query = "select price, available from books where name = '" + book.Text + "'";
                    result.Clear();
                    result = db.selectSearch(query, new[] {"price", "available"});
                    label9.Text = result[0][0];
                    label7.Text = result[0][1];
                    if (result[0][1] == "0")
                    {
                        label10.Show();
                        label10.Text = "This book is not available!";
                        label15.Hide();
                        label16.Hide();
                        label2.Hide();
                        label8.Hide();
                        db.Update("grants", new[] {"new"}, new[] {"1"}, " where g_id = '" + g_id + "'");
                    }
                    else
                    {
                        label10.Hide();
                        button1.Show();
                        DateTime today = DateTime.UtcNow.Date;
                        string borrow_date = today.ToString("dd/MM/yyyy");
                        DateTime nextWeek = today.AddDays(7);
                        string return_date = nextWeek.ToString("dd/MM/yyyy");
                        string[] val2 = new[] {"1"};
                        string[] col2 = new[] {"avail"};
                        //string[] colId = { "ID" };
                        db.Update("borrows", col2, val2, " where g_id = '" + g_id + "'");
                        
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                db.Update("grants", new[] { "new" }, new[] { "2" }, " where g_id = '" + g_id + "'");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
