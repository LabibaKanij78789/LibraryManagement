using System;
using System.Collections.Generic;
using System.IO;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static  LibraryManagement.DBConnect;
using MySql.Data.MySqlClient;
//using MySqlX.XDevAPI.Relational;

namespace LibraryManagement
{
    public partial class book_journal : Form
    {
        bool flag = false;
        string user_id;
        string searchString;
        
        string query;
        List<string> myCollection = new List<string>();
        private int avail;
        Label[] lb = new Label[10];
        int l = 0;
        int sx = 200, sy = 200;
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        string selectedBook;
        int bx, by;
        string l_id, u_id, type, total, taskDoneOrNor, g_id, b_id;
        DBConnect db = new DBConnect();
        string p;
        string name;
        private List<List<string>> resultString = new List<List<string>>();
        public book_journal(string uName, string userId)
        {
            
            InitializeComponent();
            bookPanel.BackColor = Color.Transparent;
            bx = bookPanel.Location.X;
            by = bookPanel.Location.Y;
            name = uName;
            u_id = userId;
            title.BackColor = Color.Transparent;
        }

        private void searchInput_TextChanged(object sender, EventArgs e)
        {
            
               
                
            
        }

        private void searchInput_Click(object sender, EventArgs e)
        {
            searchInput.BackColor = Color.White;
            searchInput.ForeColor = Color.LightSalmon;
            
            //searchInput.Text = searchString;
            flag = true;
        }

        private void searchInput_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void bookData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bookPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ret_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            db.Insert("notifications", new[] { "u_id", "n_type", "completed" }, new[] { u_id, "r", "0" });
            query = "select gr_id from grants where u_id = '" + u_id + "'";
            resultString.Clear();
            resultString = db.selectSearch(query, new[] { "gr_id" });
            string gid = resultString[0][0];
            db.Update("borrows", new[] { "returned" }, new[] { "1" }, " where g_id = '" + gid + "'");
        }

        private void bookData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (bookData.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    selectedBook = bookData.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                }
                //MessageBox.Show(selectedBook);
                lb[l] = new Label();
                lb[l].Text = selectedBook;
                lb[l].Font = new Font("Minion pro", 12, FontStyle.Regular);
                lb[l].Size = new Size(sx, sy);
                myCollection.Add(selectedBook);
                //lb[l].Location = new Point(bx, by);
                if (l % 2 == 0)
                {
                    lb[l].BackColor = Color.WhiteSmoke;
                    lb[l].ForeColor = Color.LightCoral;
                }
                else
                {
                    lb[l].BackColor = Color.DarkGray;
                    lb[l].ForeColor = Color.LightSalmon;
                }
                bookPanel.Controls.Add(lb[l]);
                bx += sx;
                by += sy;
                l++;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void book_journal_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MemberPage("labiba").Show();
        }

        private void search_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                searchString = searchInput.Text;
                //db.OpenConnection();

                string[] columns = new[] { "Book_title", "publication_date", "Author", "Genre", "Section", "Publication", "price" };
                query = "Select b_name as Book_title, pub_date as publication_date, " +
                        "a_name as Author, g_type as Genre, s_type as Section, " +
                        "p_name as Publication, price from books inner join author " +
                        "on books.a_id = author.a_id inner join genre on books.g_id = genre.g_ID" +
                        " inner join section on books.s_id = section.s_id inner join publisher " +
                        "on books.p_id = publisher.p_id where b_name = '" + searchString + "' or " +
                        "g_type = '" + searchString + "' or a_name = '" + searchString + "' or " +
                        "s_type = '" + searchString + "' or p_name = '" + searchString + "'";

                resultString = db.selectSearch(query, columns);

                DataTable table = new DataTable();
                for (int i = 0; i < 7; i++)
                {
                    table.Columns.Add(columns[i]);
                }
                foreach (var array in resultString)
                {
                    table.Rows.Add(array.ToArray());
                }
                bookData.DataSource = table;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
        string today;
        private void buy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string conQ = "U_id = '" + u_id + "'";
                db.Insert("notifications", new[] { "u_id", "n_type", "completed" }, new[] { u_id, "y", "0" });
                int countGrant = db.Count("grants", conQ);
                countGrant += 1;
                //MessageBox.Show(countGrant.ToString());
                string gNo = Convert.ToString(countGrant);
                Random rnd = new Random();
                l_id = Convert.ToString(rnd.Next(1, 6));
                g_id = l_id + u_id + countGrant;
                l_id = "1";
                string[] col = new[] {"gr_ID","l_id", "u_id", "taskDoneOrNot", "total", "gr_Type", "new"};
                string[] val = new[] {g_id, l_id, u_id, "0", "0", "y", "0"};
                db.Insert("grants", col, val);
                string c;

                today = DateTime.UtcNow.ToLocalTime().ToString("yyyy-MM-dd HH:mm:ss tt");
                if (today[19] == 'P')
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
                string[] val2 = new[] {"", g_id, "0", today};
                string[] col2 = new[] {"b_id", "g_id", "buy_avail", "sell_date"};
                string[] colId = {"b_ID"};

                foreach (string book in myCollection)
                {
                    query = "Select b_ID from books where b_name = '" + book + "'";

                    resultString = db.selectSearch(query, colId);
                    val2[0] = resultString[0][0];
                    db.Insert("buys", col2, val2);
                }
                this.Hide();
                new noti_bb(myCollection, 0, name, "bj", user_id).Show();
            }

            
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }           
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                db.Insert("notifications", new[] { "u_id", "n_type", "completed" }, new[] { u_id, "w", "0" });
                string conQ = "u_id = '" + u_id + "'";
                int countGrant = db.Count("grants", conQ);
                countGrant += 1;

                string gNo = Convert.ToString(countGrant);
                //MessageBox.Show(gNo);
                Random rnd = new Random();
                l_id = Convert.ToString(rnd.Next(1, 6));
                g_id = l_id + u_id + countGrant;
                //MessageBox.Show(g_id);
                l_id = "1";
                string[] col = new[] { "gr_ID", "l_id", "u_id", "taskDoneOrNot", "total", "gr_Type", "new" };
                string[] val = new[] { g_id, l_id, u_id, "0", "0", "w", "0" };
                db.Insert("grants", col, val);
                string c;

                today = DateTime.UtcNow.ToLocalTime().ToString("yyyy-MM-dd HH:mm:ss tt");
                if (today[19] == 'P')
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
                string borrow_date = today.Remove(19, 3);

                string date7 = DateTime.UtcNow.AddDays(7).ToLocalTime().ToString("yyyy-MM-dd HH:mm:ss tt");
                if (date7[19] == 'P')
                {
                    c = date7[11].ToString();
                    int.TryParse(c, out int h0);
                    c = date7[12].ToString();
                    int.TryParse(c, out int h1);
                    int h = (h0 * 10 + 2) + 12;
                    h0 = h / 10;
                    h1 = h % 10;
                    StringBuilder sb = new StringBuilder(date7);
                    sb[11] = Convert.ToChar(h0);
                    sb[12] = Convert.ToChar(h1);
                    date7 = sb.ToString();
                }
                string return_date = date7.Remove(19, 3);
                string[] val2 = new[] {"", g_id, borrow_date, return_date, "0", "0" };
                string[] col2 = new[] {"b_id", "g_id", "borrow_date", "return_date", "returned", "bor_avail" };
                string[] colId = { "b_ID" };
                
                foreach (string book in myCollection)
                {
                    query = "Select b_id from books where b_name = '" + book + "'";

                    resultString = db.selectSearch(query, colId);
                    val2[0] = resultString[0][0];
                    db.Insert("borrows", col2, val2);
                }
                this.Hide();
                new noti_bb(myCollection, 0, name, "bj", user_id).Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
    }
}

