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
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
            
        }
        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J2E5UDC\SQLEXPRESS;Initial Catalog=lms;Integrated Security=True");

        bool flag = false;
        private void FillCombo()
        {
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
          try
            {
                //label5.Visible = true;
                
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label15.Visible = true;

                //txtmemberid.Visible = true;
                

            
            }
            catch (Exception ex) { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Librarian_Side.l_noti ob = new Librarian_Side.l_noti();
            this.Hide();
            ob.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select b_id, available from books where b_name = '" + comboBox1.SelectedItem.ToString() + "'";
            result.Clear();
            result = db.selectSearch(query, new[] { "b_id", "available" });
            int n;
            int.TryParse(result[0][1], out n);
            db.Update("borrows", new[] { "return_date " }, new[] { today }, " where b_id = '"+result[0][0]+"'");
            query = "select u_id from user where u_name = '" + comboBox2.SelectedItem.ToString() + "'";
            result.Clear();
            result = db.selectSearch(query, new[] { "u_id" });
            db.Update("notifications", new[] { "completed" }, new[] { "1" }, " where u_id = '"+result[0][0]+"'");
            
            n = n + 1;
            db.Update("books", new[] { "available" }, new[] { n.ToString() }, " where b_id = '" + result[0][0] + "'");
            result.Clear();
            label5.Hide();
            label10.Hide();
            label11.Hide();
            //int[] numbers = { 1, 3, 4, 9, 2 };

            if (comboBox1.SelectedIndex >= 0)
                comboBox1.DataSource = null;
                comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
            if (comboBox1.Items.Count == 0)
            {
                if (comboBox2.SelectedIndex >= 0)
                    comboBox2.DataSource = null;
                    comboBox2.Items.RemoveAt(comboBox2.SelectedIndex);
                if (comboBox2.Items.Count == 0)
                {
                    MessageBox.Show("No books to return anymore!");
                }
            }

        }
        
        DBConnect db = new DBConnect();
        List<List<string>> result = new List<List<string>>();
        private void ReturnBook_Load(object sender, EventArgs e)
        {
            label5.Hide();
            label10.Hide();
            label11.Hide();
            string query = "select u_name from user inner join notifications on user.u_id = notifications.u_id " +
                "where n_type = 'r' and completed = '0'";
            result.Clear();
            result = db.selectSearch(query, new[] { "u_name" });
            string[] Ulist = new string[result.Count];
            for (int i = 0; i < result.Count; i++)
            {
                Ulist[i] = result[i][0];
            }
            comboBox2.DataSource = Ulist;
        }
        
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "Select b_name from books inner join borrows on books.b_id = borrows.b_id inner join " +
                "grants on borrows.g_id = grants.gr_id inner join notifications on notifications.u_id = grants.u_id " +
                "inner join user on notifications.u_id = user.u_id where u_name = '" + comboBox2.SelectedItem.ToString() +
                "' and returned = '1' and n_type = 'r' and completed = '0'";

            result.Clear();
            result = db.selectSearch(query, new[] { "b_name" });
            string[] booklist = new string[result.Count];
            for(int i = 0; i< result.Count; i++)
            {
                booklist[i] = result[i][0];
            }
            comboBox1.DataSource = booklist;
        }
        string today;
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select pub_date, borrow_date from books inner join borrows on books.b_id = " +
                "borrows.b_id where b_name = '" + comboBox1.SelectedItem.ToString() + "'";
            result.Clear();
            result = db.selectSearch(query, new[] { "pub_date", "borrow_date" });
            if(result.Any())
            {
                label5.Text = result[0][0];
                label10.Text = result[0][1];
                string c;

                today = DateTime.UtcNow.ToLocalTime().ToString("yyyy-MM-dd HH:mm:ss tt");
                if(today[19] == 'P')
                {
                    c = today[11].ToString();
                    int.TryParse(c, out int h0);
                    c = today[12].ToString();
                    int.TryParse(c, out int h1);
                    int h = (h0 * 10 + 2) + 12;
                    h0 = h / 10;
                    h1 = h % 10;
                    StringBuilder sb = new StringBuilder(today);
                    sb[11] = Convert.ToChar(h0);
                    sb[12] = Convert.ToChar(h1);
                    today = sb.ToString();
                }
                today = today.Remove(19, 3);
                
                //MessageBox.Show(today);
                label11.Text = today;
                label8.Text = "Edition";
                label9.Text = "Return Date";
                label15.Text = "Issue Date";
                label9.Show();
                label5.Show();
                label10.Show();
                label11.Show();
                label8.Show();
                label15.Show();
            }
            
        }
    }
}
