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
        string bl_id;
        DBConnect db = new DBConnect();
        string name;
        //string status;
        string bk;
        string book_id;
        int b;
        List<string> bookame = new List<string>();
        List<List<string>> result = new List<List<string>>();
        List<List<string>> result2 = new List<List<string>>();
        string page;
        string getBook, getStatus;
        public bookLog(string uName, string userId, Boolean bl)
        {
            InitializeComponent();
            this.dataGridView1.Hide();
            this.search.Hide();
            name = uName;
            //status = getStatus;
            creatLog = bl;
            //page = p;
            user_id = userId;
            //bk = book;
            label2.Hide();
            
            panel1.Hide();
            comboBox1.Hide();
            
            comboBox2.Hide();
            panel1.BackColor = Color.Transparent;
            
            
                if (creatLog)
                {
                    button1.Hide();
                    panel1.Hide();
                    label1.Hide();
                    search.Show();
                    dataGridView1.Show();
                }
                else
                {
                    button1.Show();
                    panel1.Show();
                    label1.Show();
                    search.Hide();
                    dataGridView1.Hide();
                }
            
            

        }

        private void bookLog_Load(object sender, EventArgs e)
        {
            userName.Text += name;
            string query = "select name from books";
            
            result = db.selectSearch(query, new[] {"name"});
            string[] dataBook = new string[result.Count];
            //DataTable tableBuy = new DataTable();
            for (int i = 0; i < result.Count; i++)
            {
                dataBook[i] = result[i][0];
                bookame[i] = result[i][0];

            }
            comboBox1.DataSource = dataBook;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            try
            {
                
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
            search.Show();
            //dataGridView1.Show();
            //add.Show();
            dataGridView1.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MemberPage("labiba").Show();
        }

        private void search_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            creatLog = true;
            panel1.Show();
            label2.Show();
            comboBox1.Show();
            comboBox2.Show();
            //Search_book sb = new Search_book(name);
            //this.Hide();
            //sb.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            getBook = comboBox1.SelectedItem.ToString();
            //MessageBox.Show(getBook);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            getStatus = comboBox1.SelectedItem.ToString();
            //MessageBox.Show(getBook);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (creatLog)
                {
                    string[] colBook = new[] { "id" };
                    string qb = "select id from books where name = '" +getBook + "'";
                    string[] colBooklog = new[] { "book_log.id" };
                    string qbl = "select book_log.id from book_log inner join user on book_log.u_id = user.id where user.name  = '" +
                        name + "' and book_log.name = '" + ct.Text.ToString() + "'";
                    result = db.selectSearch(qb, colBook);
                    result2 = db.selectSearch(qbl, colBooklog);
                    book_id = result[0][0];
                    bl_id = result2[0][0];
                    string[] col = new[] { "b_id", "bl_id", "status" };
                    string[] val = new[] {book_id, bl_id, getStatus };
                    db.Insert("contains", col, val);
                    

                    


                }

                else
                {
                    this.dataGridView1.Hide();
                    this.search.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            string item = comboBox1.Text;
            item = item.ToLower();
            comboBox1.Items.Clear();
            string[] bookName = new string[bookame.Count];
            for (int i = 0; i < bookame.Count; i++)
            {
                bookName[i] = bookame[i];
            }
            List<string> list = new List<string>();
            for (int i = 0; i < bookName.Length; i++)
            {
                if (bookName[i].ToLower().Contains(item))
                    list.Add(bookName[i]);
            }
            if (item != String.Empty)
                foreach (string str in list)
                    comboBox1.Items.Add(str);
            else
                comboBox1.Items.AddRange(bookName.ToArray());
            comboBox1.SelectionStart = item.Length;
            comboBox1.DroppedDown = true;
        }
    }
    
}