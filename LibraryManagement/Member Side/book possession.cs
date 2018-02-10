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
namespace LibraryManagement
{
    public partial class book_possession : Form
    {
        string u_id, name;
        
        //string query2 = "select books.name, buys.borrow_date, borrows.return_date " +
          //              "from books inner join borrows where books.id = borrows.b_id";
        string[] columns1 = new []{"b_name", "borrow_date", "return_date"};
        List<List<string>> result1 = new List<List<string>>();

        
        string[] columns2 = new[] { "b_name", "price" };
        List<List<string>> result2 = new List<List<string>>();
        //DateTime today = DateTime.Today;
        DBConnect db = new DBConnect();
        
        public book_possession(string uName, string userID)
        {
            InitializeComponent();
            pictureBox1.BackColor = Color.Transparent;
            u_id = userID;
            name = uName;
        }

        private void book_possession_Load(object sender, EventArgs e)
        {
            //result1 = db.selectSearch(query1, columns1);
            string query1 = "select b_name, borrow_date, return_date " +
                        "from books inner join borrows on books.b_id = borrows.b_id inner join grants" +
            " on grants.gr_id = borrows.g_id where u_id = '" + u_id + "'";
            result1.Clear();
            result1 = db.selectSearch(query1, columns1);

            DataTable table1 = new DataTable();
            for (int i = 0; i < columns1.Length; i++)
            {
                table1.Columns.Add(columns1[i]);
            }
            foreach (var array in result1)
            {
                table1.Rows.Add(array.ToArray());
            }
            booksBorrowed.DataSource = table1;
            string query2 = "select b_name, price " +
                        "from books inner join buys on books.b_id = buys.b_id" +
                        " inner join grants on grants.gr_id = buys.g_id where u_id = '" + u_id + "'" +
                        " and buy_avail = '1'";
            //string query2 = "select books.name, buys.borrow_date, borrows.return_date " +
            //              "from books inner join borrows where books.id = borrows.b_id";
            result2.Clear();
            result2 = db.selectSearch(query2, columns2);

            DataTable tabl2 = new DataTable();
            for (int i = 0; i < columns2.Length; i++)
            {
                tabl2.Columns.Add(columns2[i]);
            }
            foreach (var array in result2)
            {
                tabl2.Rows.Add(array.ToArray());
            }
            booksBought.DataSource = tabl2;

        }

        private void booksBorrowed_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MemberPage mp = new MemberPage("labiba");
            this.Hide();
            mp.Show();
        }

        private void booksBought_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
