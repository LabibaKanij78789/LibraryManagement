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
            searchString = searchInput.Text;
            //db.OpenConnection();

            string[] columns = new[] { "Book_title", "publication_date", "Author", "Genre", "Section", "Publication", "price" };
            query = "Select books.name as Book_title, books.pub_date as publication_date, " +
                    "author.name as Author, genre.type as Genre, section.type as Section, " +
                    "publisher.name as Publication, books.price as price from books inner join author " +
                    "on books.a_id = author.id inner join genre on books.g_id = genre.ID" +
                    " inner join section on books.s_id = section.id inner join publisher " +
                    "on books.p_id = publisher.id where books.name = '" + searchString + "' or " +
                    "genre.type = '" + searchString + "' or author.name = '" + searchString + "' or " +
                    "section.type = '" + searchString + "' or publisher.name = '" + searchString + "'";

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
        }

        private void buy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string conQ = "U_id = '" + u_id + "'";
                
                int countGrant = db.Count("grants", conQ);
                countGrant += 1;
                //MessageBox.Show(countGrant.ToString());
                string gNo = Convert.ToString(countGrant);
                Random rnd = new Random();
                l_id = Convert.ToString(rnd.Next(1, 6));
                g_id = l_id + u_id + countGrant;
                l_id = "1";
                string[] col = new[] {"ID","l_id", "u_id", "taskDoneOrNot", "total", "Type", "new"};
                string[] val = new[] {g_id, l_id, u_id, "0", "0", "y", "1"};
                db.Insert("grants", col, val);
                string[] val2 = new[] {"", g_id, "0"};
                string[] col2 = new[] {"b_id", "g_id", "avail"};
                string[] colId = {"ID"};

                foreach (string book in myCollection)
                {
                    query = "Select ID from books where name = '" + book + "'";

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
            //string[] columns1 = new[] { "available" };
            //query = "Select available from books where name = '" + selectedBook + "'";

            //resultString = db.selectSearch(query, columns1);
            //foreach (List<string> s in resultString)
            //{
            //    foreach (string r in s)
            //    {
            //        p = r;
            //    }
            //}

            //avail = Convert.ToInt16(p);
            //if (avail == 0)
            //{

            //    MessageBox.Show("sorry this book is not available!!!");
            //}
            //else
            //{
            //    string[] columns = new[] { "price" };
            //    query = "Select price from books where name = '" + selectedBook + "'";

            //    resultString = db.selectSearch(query, columns);
            //    foreach (List<string> s in resultString)
            //    {
            //        foreach (string r in s)
            //        {
            //            p = r;
            //        }
            //    }



            //    DialogResult dialogResult = MessageBox.Show("Are you sure you want to buy this book for " + p + " taka??",
            //        selectedBook + "purchase", MessageBoxButtons.YesNo);
            //    if (dialogResult == DialogResult.Yes)
            //    {
            //        //do something
            //        DialogResult dr = MessageBox.Show(p + " taka is cut off from your mobile account.",
            //            selectedBook + "purchase", MessageBoxButtons.OKCancel);
            //        if (dr == DialogResult.OK)
            //        {
            //            MessageBox.Show("This book is booked for you. Hope to see you soon to get this! Thank you.");
            //            avail--;
            //            db.Update("books", columns1, new[] { avail.ToString() }, "where name = '" + selectedBook + "'");
            //        }
            //        else
            //        {
            //            MessageBox.Show("Hope you will have a nice book read!");
            //        }
            //    }
            //    else if (dialogResult == DialogResult.No)
            //    {
            //        //do something else
            //        MessageBox.Show("Hope you will have a nice book read!");
            //    }
            //}
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
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
                string[] col = new[] { "ID", "l_id", "u_id", "taskDoneOrNot", "total", "Type", "new" };
                string[] val = new[] { g_id, l_id, u_id, "0", "0", "w", "1" };
                db.Insert("grants", col, val);
                DateTime today = DateTime.UtcNow.Date;
                string borrow_date = today.ToString("dd/MM/yyyy");
                DateTime nextWeek = today.AddDays(7);
                string return_date = nextWeek.ToString("dd/MM/yyyy");
                string[] val2 = new[] {"", g_id, borrow_date, return_date, "0", "0" };
                string[] col2 = new[] {"b_id", "g_id", "borrow_date", "return_date", "returned", "avail" };
                string[] colId = { "ID" };
                
                foreach (string book in myCollection)
                {
                    query = "Select ID from books where name = '" + book + "'";

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
            //string[] columns = new[] { "available" };
            //query = "Select available from books where name = '" + selectedBook + "'";

            //resultString = db.selectSearch(query, columns);
            //foreach (List<string> s in resultString)
            //{
            //    foreach (string r in s)
            //    {
            //        p = r;
            //    }
            //}

            //avail = Convert.ToInt16(p);
            //if (avail == 0)
            //{

            //    MessageBox.Show("sorry this book is not available!!!");
            //}
            //else
            //{
            //    MessageBox.Show("This book has been booked for you. Thank you");
            //    avail--;
            //    db.Update("books", columns, new[] { avail.ToString() }, "where name = '" + selectedBook + "'");
            //}
        }
    }
}

