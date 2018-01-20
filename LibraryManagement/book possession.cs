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
        string query1 = "select books.name, borrows.borrow_date, borrows.return_date " +
                        "from books inner join borrows where books.id = borrows.b_id";
        //string query2 = "select books.name, buys.borrow_date, borrows.return_date " +
          //              "from books inner join borrows where books.id = borrows.b_id";
        string[] columns1 = new []{"books.name", "borrows.borrow_date", "borrows.return_date"};
        List<string> [] result1 = new List<string>[100];
        DateTime today = DateTime.Today;
        DBConnect db = new DBConnect();
        
        public book_possession()
        {
            InitializeComponent();
            pictureBox1.BackColor = Color.Transparent;
        }

        private void book_possession_Load(object sender, EventArgs e)
        {
            result1 = db.selectSearch(query1, columns1);
            
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
    }
}
