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
        bool creatLog, addBook;
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
        Boolean bookl;
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
            bookl = bl;
            panel1.Hide();
            comboBox1.Hide();
            
            comboBox2.Hide();
            panel1.BackColor = Color.Transparent;
            
            
                if (bookl||creatLog)
                {
                    button1.Hide();
                    panel1.Hide();
                    label1.Hide();
                    search.Show();
                    dataGridView1.Show();
                panel2.Hide();
                panel2.Visible = false;
            }
                else
                {
                    button1.Show();
                    panel2.Show();
                    label1.Show();
                    search.Hide();

                    dataGridView1.Hide();
                }
            
            

        }

        private void bookLog_Load(object sender, EventArgs e)
        {

            userName.Text += name;
            string query = "select b_name from books";
            result.Clear();
            result = db.selectSearch(query, new[] {"b_name"});
            string[] dataBook = new string[result.Count];
            //DataTable tableBuy = new DataTable();
            
            //MessageBox.Show(result.Count.ToString());
            for (int i = 0; i < result.Count; i++)
            {
                dataBook[i] = result[i][0];
                if(addBook)
                    bookame[i] = result[i][0];

            }
            comboBox1.DataSource = dataBook;
            comboBox1.Hide();
            if(creatLog||bookl)
            {
                dataGridView1.DataSource = null;
                string q = "select b_name, status from contains inner join books on contains.b_id = books.b_id inner " +
                        "join book_log on contains.bl_id = book_log.bl_id inner join user on book_log.u_id = user.u_id" +
                        " where u_name = '" + name +"' and user.u_id = '" +user_id+"'";
                result.Clear();
                //List<List<string>> res = new List<List<string>>();
                result = db.selectSearch(q, new[] { "b_name", "status" });
                string[] columns = new[] { "Title", "Status" };
                DataTable table = new DataTable();
                for (int i = 0; i < 2; i++)
                {
                    table.Columns.Add(columns[i]);
                }
                for (int i = 0; i < 2; i++)

                    foreach (var array in result)
                    {
                        table.Rows.Add(array.ToArray());
                    }
                dataGridView1.DataSource = table;
                panel2.Hide();
                panel2.Visible = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            try
            {
                
                //blName = label1.Text.ToString();
                string[] columns2 = new[] { "bl_Name" };
                string[] booklog = new[] {  ct.Text.ToString() };
                db.Insert("book_log", columns2, booklog);

                string[] upcol = { "bookLog" };
                string[] upval = { "1" };
                string conQ = " where id = '" + user_id + "'";
                db.OpenConnection();
                db.Update("user", upcol, upval, conQ);
                db.CloseConnection();
                creatLog = true;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            button1.Hide();
            panel1.Hide();
            panel2.Hide();
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
            //creatLog = true;
            panel2.Show();
            label2.Show();
            comboBox1.Show();
            addBook = true;
            comboBox2.Show();
            ct.Hide();
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
            getStatus = comboBox2.SelectedItem.ToString();
            //MessageBox.Show(getBook);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (creatLog||bookl)
                {
                    panel2.Hide();
                    dataGridView1.DataSource = null;
                    string[] colBook = new[] { "b_id" };
                    string qb = "select b_id from books where b_name = '" +getBook + "'";
                    //MessageBox.Show(getBook);
                    //MessageBox.Show(qb);
                    string[] colBooklog = new[] { "bl_id" };
                    string qbl = "select bl_id from book_log inner join user on book_log.u_id = user.u_id where user.u_name  = '" +
                        name + "' and user.u_id = '" + user_id + "'";
                    //MessageBox.Show(qbl.ToString());
                    result = db.selectSearch(qb, colBook);
                    //MessageBox.Show("done");
                    result2 = db.selectSearch(qbl, colBooklog);
                    //MessageBox.Show("done");
                    //MessageBox.Show(result[0][0]);
                    //MessageBox.Show(result2[0][0]);
                    book_id = result[0][0];
                    bl_id = result2[0][0];
                    //MessageBox.Show("bl_id = " + bl_id);
                    string[] col = new[] { "b_id", "bl_id", "status" };
                    string[] val = new[] {book_id, bl_id, getStatus };
                    db.Insert("contains", col, val);
                    string q = "select b_name, status from contains inner join books on contains.b_id = books.b_id inner " +
                        "join book_log on contains.bl_id = book_log.bl_id " +
                        " where u_id = '" + bl_id + "'";
                    result.Clear();
                    //List<List<string>> res = new List<List<string>>();
                    result = db.selectSearch(q, new[] { "b_name", "status" });
                    string[] columns = new[] { "Title", "status" };
                    DataTable table = new DataTable();
                    for (int i = 0; i < 2; i++)
                    {
                        table.Columns.Add(columns[i]);
                    }
                    for (int i = 0; i < 2; i++)

                        foreach (var array in result)
                        {
                            table.Rows.Add(array.ToArray());
                        }
                    dataGridView1.DataSource = table;
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
            //try
            //{
            //    string item = comboBox1.Text;
            //    item = item.ToLower();
            //    //comboBox1.Items.Clear();
            //    string[] bookName = new string[bookame.Count];
            //    for (int i = 0; i < bookame.Count; i++)
            //    {
            //        bookName[i] = bookame[i];
            //    }
            //    List<string> list = new List<string>();
            //    for (int i = 0; i < bookName.Length; i++)
            //    {
            //        if (bookName[i].ToLower().Contains(item))
            //            list.Add(bookName[i]);
            //    }
            //    if (item != String.Empty)
            //        foreach (string str in list)
            //            comboBox1.Items.Add(str);
            //    else
            //    {
            //        comboBox1.DataSource = null;
            //        comboBox1.Items.AddRange(bookName.ToArray());
            //    }
                    
            //    comboBox1.SelectionStart = item.Length;
            //    comboBox1.DroppedDown = true;
            //}catch(Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
            
        }
    }
    
}