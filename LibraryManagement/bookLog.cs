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
        bool creatLog;
        DBConnect db = new DBConnect();
        string name;
        string status;
        string bk;
        string book_id;
        string bl_id;

        List<List<string>> result = new List<List<string>>();
        List<List<string>> result2 = new List<List<string>>();
        string page;
        public bookLog(string uName, string book, string getStatus, Boolean bl, string p)
        {
            InitializeComponent();
            this.dataGridView1.Hide();
            this.add.Hide();
            name = uName;
            status = getStatus;
            creatLog = bl;
            page = p;
            bk = book;
            

            try
            {
                if (creatLog)
                {
                    if (page == "p")
                    {
                        string[] colBook = new[] { "id" };
                        string qb = "select id from books where name = '" + bk + "'";
                        string[] colBooklog = new[] { "id" };
                        string qbl = "select book_log.id from book_log inner join user on book_log.u_id = user.id where user.name  = '" + name + "'";

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
                        string[] col = new[] { "b_id", "bl_id", "status" };
                        string[] val = new[] { book_id, bl_id, status };

                        MessageBox.Show(val[0]);
                        MessageBox.Show(val[1]);
                        MessageBox.Show(val[2]);

                        db.Insert("contains", col, val);
                    }

                    button1.Hide();
                    panel1.Hide();
                    label1.Hide();
                    add.Show();
                    dataGridView1.Show();


                }

                else
                {
                    this.dataGridView1.Hide();
                    this.add.Hide();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bookLog_Load(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            string q = "select id from user where Name = '" + name+"'";
            string[] columns1 = new[] { "id" };

            try
            {
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
                string[] booklog = new[] { user_id, ct.Text.ToString() };
                db.Insert("book_log", columns2, booklog);

                string[] upcol = { "bookLog" };
                string[] upval = { "1" };
                string conQ = " where id = '" + user_id + "'";
                db.OpenConnection();
                db.Update("user", upcol, upval, conQ);
                db.CloseConnection();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MemberPage("labiba").Show();
        }
    }
}