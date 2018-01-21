using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LibraryManagement.DBConnect;

namespace LibraryManagement
{
    public partial class bookLog : Form
    {
        private string blName;
        string user_id;
        bool creatLog = false;
        DBConnect db = new DBConnect();
         string name;
         string status;
        //string[] colBook;
        //string[] colbookLog;
        string book_id;
        string bl_id;

        List<List<string>> result = new List<List<string>>();
        List<List<string>> result2 = new List<List<string>>();

        public bookLog(string uName, string book, string getStatus)
        {
            InitializeComponent();
            this.dataGridView1.Hide();
            this.add.Hide();
            name = uName;
            status = getStatus;
            
        }

        private void bookLog_Load(object sender, EventArgs e)
        {
            
            if (creatLog)
            {
                string[] colBook = new[] { "id" };
                string qb = "select id from books where name = '" + name + "'";
                string[] colBooklog = new[] { "id" };
                string qbl = "select id from books where name = '" + ct.Text.ToString() + "'";
                result = db.selectSearch(qb, colBook);
                result2 = db.selectSearch(qbl, colBooklog);

                foreach (List<string> s in result)
                {
                    foreach (string r in s)
                    {
                        book_id = r;
                    }
                }
                foreach (List<string> s in result2)
                {
                    foreach (string r in s)
                    {
                        bl_id = r;
                    }
                }

                string[] col = new[] {"b_id", "bl_id", "status"};
                string[] val = new[] {book_id, bl_id, status};
                db.Insert("contains", col, val);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string q = "select id from user where name = " + name;
            string[] columns1 = new[] { "Name" };
            
            
            result = db.selectSearch(q, columns1);
            foreach (List<string> s in result)
            {
                foreach (string r in s)
                {
                    user_id = r;
                }
            }
            //blName = label1.Text.ToString();
            string[] columns2 = new[] { "u_id", "Name" };
            string[] booklog = new []{ user_id, ct.Text.ToString() };
            db.Insert("book_log", columns2, booklog);
            button1.Hide();
            panel1.Hide();
            label1.Hide();
            //dataGridView1.Show();
            add.Show();
            dataGridView1.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            creatLog = true;
            Search_book sb = new Search_book(name);
            this.Hide();
            sb.Show();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
