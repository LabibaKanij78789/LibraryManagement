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
    public partial class Survey : Form
    {
        List<List<string>> result = new List<List<string>>();
        public Survey()
        {
            InitializeComponent();
            FillCombo();
            dataGridView1.Hide();
            dateTimePicker1.Visible = true;
            dateTimePicker2.Visible = true;
        }
        DBConnect db = new DBConnect();
        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J2E5UDC\SQLEXPRESS;Initial Catalog=lms;Integrated Security=True");
        private void FillCombo()
        {
           
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //con.Open();
                //String s = comboBox1.Text;
                //String query = "SELECT * FROM  " + s + ";";
                //SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                //DataTable dt = new DataTable();
                //SDA.Fill(dt);
                //dataGridView1.DataSource = dt;
                //con.Close();
            }
            catch (Exception ex)
            {
                mainpage ob = new mainpage();
                this.Hide();
                ob.Show();
            }
        }

        private void Survey_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Show();
                dataGridView1.DataSource = null;
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm:ss";
                dateTimePicker2.CustomFormat = "yyyy-MM-dd HH:mm:ss";
                //MessageBox.Show(dateTimePicker2.Value.ToString("yyyy-mm-dd"));
                string query = "select b_name, price, sell_date from books inner join buys on books.b_id " +
                    "= buys.b_id where sell_date between '" + dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss") + "' and '" + dateTimePicker2.Value.ToString("yyyy-MM-dd HH:mm:ss") + "'" +
                    "group by b_name, sell_date, price order by count(*) desc";
                result.Clear();
                result = db.selectSearch(query, new[] { "b_name", "price", "sell_date" });
                string[] columns = new[] { "Title", "Price", "Sell Date" };
                dataGridView1.Show();
                fillTable(columns, dataGridView1, result);
            }
            catch (Exception ex) { }
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
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Show();
                dataGridView1.DataSource = null;
                string query = "select b_name, return_date from books inner join borrows on books.b_id " +
                    "= borrows.b_id where returned = '0' and return_date <= '" + DateTime.Today.ToString("yyyy-mm-dd") + "'";
                result.Clear();
                result = db.selectSearch(query, new[] { "b_name", "return_date"});
                string[] columns = new[] { "Title", "Return Date" };
                dataGridView1.Show();
                fillTable(columns, dataGridView1, result);
            }
            catch (Exception ex) { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Show();
                dataGridView1.DataSource = null;
                string query = "select u_name from user inner join grants on user.u_id = grants.u_id" +
                    " inner join borrows on borrows.g_id = grants.gr_id " +
                 "where returned = '0' group by u_name having count(*)>=5";
                result.Clear();
                result = db.selectSearch(query, new[] { "u_name" });
                string[] columns = new[] { "User" };
                fillTable(columns, dataGridView1, result);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            mainpage ob = new mainpage();
            this.Hide();
            ob.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.Show();
            dataGridView1.DataSource = null;
            string according = comboBox1.SelectedItem.ToString();
            if(according == "Sell")
            {
                string query = "select b_name, count(*) from books inner join buys on books.b_id =" +
                    "buys.b_id group by b_name order by count(*) desc limit 3";
                result.Clear();
                result = db.selectSearch(query, new[] { "b_name", "count(*)" });
                fillTable(new[] { "Title", "Books Sold" }, dataGridView1, result);
            }
            if (according == "Borrow")
            {
                string query = "select b_name, count(*) from books inner join borrows on books.b_id =" +
                    "borrows.b_id group by b_name, count(*) order by count(*) desc limit 3";
                result.Clear();
                result = db.selectSearch(query, new[] { "b_name", "count(*)" });
                fillTable(new[] { "Title", "Books Sold" }, dataGridView1, result);
            }
            if (according == "Both")
            {
                string query = "select b_name, count(*) from books inner join buys on books.b_id =" +
                    "buys.b_id inner join borrows on books.b_id = borrows.b_id group by b_name," +
                    " count(*) order by count(*) desc limit 3";
                result.Clear();
                result = db.selectSearch(query, new[] { "b_name", "count(*)" });
                fillTable(new[] { "Title", "Books Sold" }, dataGridView1, result);
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new mainpage().Show();
        }
    }
}
