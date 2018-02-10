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
        string query;
        string u_name, u_id;
        int req;
        string bookname, g_id, page;
        
        DBConnect db = new DBConnect();
        public Issuebook(string p)
        {
            InitializeComponent();
            page = p;
            //FillCombo();
            label8.Hide();
            //button2.Hide();
            //label6.Hide();
            label10.Hide();
            label15.Hide();
            label16.Hide();
            issuedate.Hide();
            label2.Hide();
            returnDate.Hide();
            button1.Hide();
            groupBox2.Hide();
            //txtstudentname.Show();
            dataGridView1.Hide();
            label6.Hide();
            //book.Show();
            label4.Show();
        }
        List<List<string>> result = new List<List<string>>();
        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J2E5UDC\SQLEXPRESS;Initial Catalog=lms;Integrated Security=True");
        
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Librarian_Side.l_noti().Show();
           
        }
        private void FillCombo()
        {
            //con.Open();
            //String query = "SELECT name FROM Newbook1;";
            //SqlCommand cmd = new SqlCommand(query, con);
            //SqlDataReader dr = cmd.ExecuteReader();
            
            //con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

           

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                query = "select reqpending from user where u_name = '" + u_name + "'";
                result.Clear();
                result = db.selectSearch(query, new[] { "reqpending" });
                //req = result[0][0];
                int.TryParse(result[0][0], out req);
                req += 1;
                string up = req.ToString();
                
                db.Update("user", new[] { "reqpending"},new[] { up}, " where u_name = '"+u_name+"'");
                if(page == "buy")
                {
                    query = "select available, books.b_id as b_id from books inner join buys on books.b_id = buys.b_id inner join grants on" +
                    " buys.g_id = grants.gr_id where u_id = '" + u_id + "' and gr_type = 'y'";
                    result.Clear();
                    result = db.selectSearch(query, new[] { "available", "b_id" });
                    int c = result.Count;
                    string[] bid = new string[c];
                    string[] aData = new string[c];
                    int n;
                    for (int i = 0; i < c; i++)
                    {
                        bid[i] = result[i][1];
                        aData[i] = result[i][0];
                        int.TryParse(aData[i], out n);
                        n -= 1;
                        aData[i] = Convert.ToString(n);
                        db.Update("books", new[] { "available"}, new[] { aData[i]}, " where b_id = '"+bid[i]+"'");
                        //bookQuery += "b_id = '" + resultString[i][0] + "'";
                        //if (i < c - 1)
                        //{
                        //    bookQuery += " or ";
                        //}
                    }
                    db.Update("grants", new[] { "new" }, new[] { "2" }, " where u_id = '" + u_id + "' and new = '0' and gr_type = 'y'");
                    db.DeleteCon("notifications", new[] { "u_id", "n_type" }, new[] { u_id, "y" });
                }
                                 
                else
                {
                    query = "select available, b_id from books inner join borrows on books.b_id = borrows.b_id inner join grants on" +
                    " borrows.g_id = grants.gr_id where u_id = '" + u_id + "' and gr_type = 'w'";
                    result.Clear();
                    result = db.selectSearch(query, new[] { "available", "b_id" });
                    int c = result.Count;
                    string[] bid = new string[c];
                    string[] aData = new string[c];
                    int n;
                    for (int i = 0; i < c; i++)
                    {
                        bid[i] = result[i][1];
                        aData[i] = result[i][0];
                        int.TryParse(aData[i], out n);
                        n -= 1;
                        aData[i] = Convert.ToString(n);
                        db.Update("books", new[] { "available" }, new[] { aData[i] }, " where b_id = '" + bid[i] + "'");
                        //bookQuery += "b_id = '" + resultString[i][0] + "'";
                        //if (i < c - 1)
                        //{
                        //    bookQuery += " or ";
                        //}
                    }
                    db.Update("grants", new[] { "new" }, new[] { "2" }, " where u_id = '" + u_id + "' and new = '0' and gr_type = 'w'");

                    db.DeleteCon("notifications", new[] { "u_id", "n_type" }, new[] { u_id, "w" });
                }
                    
                mainpage ob = new mainpage();
                this.Hide();
                ob.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Issuebook_Load(object sender, EventArgs e)
        {
            
            if (page == "borrow")
            {
                MessageBox.Show("fdsf");
                query = "select distinct(u_name) as u_name from user inner join grants on grants.u_id = user.u_id" +
                    " where new = '0' and gr_type = 'w'";
                label1.Text = "Issue Book";
            }
            else if (page == "buy")
            {
                MessageBox.Show("fdsf");
                query = "select distinct(u_name) as u_name from user inner join grants on grants.u_id = user.u_id" +
                    " where new = '0' and gr_type = 'y'";
                label1.Text = "Sell Book";
            }
            
            result.Clear();
            result = db.selectSearch(query, new[] { "u_name" });
            string[] userData = new string[result.Count];
            //DataTable tableBuy = new DataTable();
            for (int i = 0; i < result.Count; i++)
            {
                userData[i] = result[i][0];
            }
            userName.DataSource = userData;

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void userName_SelectedIndexChanged(object sender, EventArgs e)
        {
            u_name = userName.SelectedItem.ToString();
            result = db.selectSearch("select u_id from user where u_name = '" + u_name + "'", new[] { "u_id" });
            u_id = result[0][0];
            MessageBox.Show(u_id);
            try
            {
                if (page == "borrow")
                {
                    //txtstudentname.Visible = true;
                    MessageBox.Show("fdsf");
                    query =
                        " inner join grants on borrows.g_id = grants.gr_id inner join user on grants.u_id = user.u_id " +
                        "where user.u_name = '" + u_name + "' and borrows.returned = '0'";
                    int borrowed = db.CountCon("borrows", query);
                    if (borrowed > 5)
                    {
                        dataGridView1.Hide();
                        label6.Show();
                        label6.Text = "Sorry but you already borrowed more than 5 books!";
                    }
                    else
                    {
                        MessageBox.Show("fdsf");
                        dataGridView1.Show();
                        string q = "select b_name as Title, available from books inner join borrows on books.b_id = borrows.b_id " +
                    "inner join grants on borrows.g_id = grants.gr_id inner join user on grants.u_id = user.u_id where " +
                    "user.u_name = '" + u_name + "' and new = '0' and gr_type = 'w'";
                        result.Clear();
                        result = db.selectSearch(q, new[] { "Title", "available" });


                        
                            this.fillTable(new[] { "Title", "available" }, dataGridView1, result);

                        

                    }
                }
                else if (page == "buy")
                {
                    dataGridView1.Show();
                    MessageBox.Show("fdsf");
                    string q = "select b_name as Title, available, price from books inner join buys on books.b_id = buys.b_id " +
                   "inner join grants on buys.g_id = grants.gr_id inner join user on grants.u_id = user.u_id where " +
                   "user.u_name = '" + u_name + "' and new = '0' and gr_type = 'y'";
                    result.Clear();
                    result = db.selectSearch(q, new[] { "Title", "available", "price" });
                                     
                    this.fillTable(new[] { "Title", "Available", "price" }, dataGridView1, result);
                    
                } 
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
                       

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
             
            try
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    label9.Text = row.Cells[0].Value.ToString();
                    
                    label7.Text = row.Cells[1].Value.ToString();
                    if(row.Cells[1].Value.ToString() == "0")
                    {
                        label10.Show();
                        label15.Hide();
                        label16.Hide();
                        issuedate.Hide();
                        returnDate.Hide();
                        db.Update("grants", new[] { "new" }, new[] { "1" }, " where gr_id = '" + g_id + "'");
                        label10.Text = "Sorry! This book is not available.";
                    }
                    else
                    {
                        groupBox2.Show();
                        
                        
                        //label10.Hide();
                        button1.Show();
                        if(page == "borrow")
                        {
                            label8.Hide();
                            button1.Text = "Grant Issue";
                            label15.Show();
                            label16.Show();
                            issuedate.Show();
                            returnDate.Show();
                            DateTime today = DateTime.UtcNow.Date;
                            string borrow_date = today.ToString("dd/MM/yyyy");
                            issuedate.Text = borrow_date;
                            DateTime nextWeek = today.AddDays(7);
                            string return_date = nextWeek.ToString("dd/MM/yyyy");
                            returnDate.Text = return_date;
                            string[] val2 = new[] { "1" };
                            string[] col2 = new[] { "bor_avail" };
                            db.Update("borrows", col2, val2, " where g_id = '" + g_id + "'");
                        }
                        else if ( page== "buy")
                        {
                            MessageBox.Show("fdsf");
                            //label8.Show();
                            //label8.Show();
                            string q = "select sum(price) as total from books inner join buys on books.b_id = buys.b_id " +
                  "inner join grants on buys.g_id = grants.gr_id inner join user on grants.u_id = user.u_id where " +
                  "user.u_name = '" + u_name + "' and new = '0' and gr_type = 'y'";
                            result.Clear();
                            result = db.selectSearch(q, new[] { "total" });

                            label10.Show();
                            label5.Show();
                            label9.Show();
                            label3.Show();
                            label10.Text = "How Many";
                            label2.Show();
                            label2.Text = "yes";
                            label8.Text = result[0][0];
                            label8.Show();
                            label11.Show();
                            label11.Text = "Total Price";
                            label2.Show();
                            label16.Hide();
                            //MessageBox.Show(result[0][0] + " " + label8.Text);
                            button1.Text = "Grant Purchase";
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void fillTable(string[] columns, DataGridView data, List<List<string>> res)
        {

            DataTable table = new DataTable();
            for (int i = 0; i < columns.Length; i++)
            {
                table.Columns.Add(columns[i]);
            }
            foreach (var array in res)
            {
                table.Rows.Add(array.ToArray());
            }
            data.DataSource = table;
        }
    }
}
