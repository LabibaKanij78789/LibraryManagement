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
        string searchString;
        string query;
        private int avail;
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        string selectedBook;
        DBConnect db = new DBConnect();
        string p;
        private List<List<string>> resultString = new List<List<string>>();
        public book_journal()
        {
            InitializeComponent();
            //searchBox.CharacterCasing = CharacterCasing.Normal;
            //searchBox.BackColor = Color.Transparent;
            //searchInput.ForeColor = Color.LightSalmon;
            //searchInput.Style.Add(ControlStyles.back, "silver");
            //searchInput.Size = new Size(320, 40);
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
            searchString = searchInput.Text.ToString();
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

        private void bookData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bookData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bookData.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                selectedBook = bookData.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] columns = new[] { "available" };
            query = "Select available from books where name = '" + selectedBook + "'";

            resultString = db.selectSearch(query, columns);
            foreach (List<string> s in resultString)
            {
                foreach (string r in s)
                {
                    p = r;
                }
            }

            avail = Convert.ToInt16(p);
            if (avail == 0)
            {

                MessageBox.Show("sorry this book is not available!!!");
            }
            else
            {
                MessageBox.Show("This book has been booked for you. Thank you");
                avail--;
                db.Update("books", columns, new []{avail.ToString()}, "where name = '"+selectedBook+"'");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] columns1 = new[] { "available" };
            query = "Select available from books where name = '" + selectedBook + "'";

            resultString = db.selectSearch(query, columns1);
            foreach (List<string> s in resultString)
            {
                foreach (string r in s)
                {
                    p = r;
                }
            }

            avail = Convert.ToInt16(p);
            if (avail == 0)
            {

                MessageBox.Show("sorry this book is not available!!!");
            }
            else
            {
                string[] columns = new[] { "price" };
                query = "Select price from books where name = '" + selectedBook + "'";

                resultString = db.selectSearch(query, columns);
                foreach (List<string> s in resultString)
                {
                    foreach (string r in s)
                    {
                        p = r;
                    }
                }



                DialogResult dialogResult = MessageBox.Show("Are you sure you want to buy this book for " + p + " taka??",
                    selectedBook + "purchase", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //do something
                    DialogResult dr = MessageBox.Show(p + " taka is cut off from your mobile account.",
                        selectedBook + "purchase", MessageBoxButtons.OKCancel);
                    if (dr == DialogResult.OK)
                    {
                        MessageBox.Show("This book is booked for you. Hope to see you soon to get this! Thank you.");
                        avail--;
                        db.Update("books", columns1, new[] { avail.ToString() }, "where name = '" + selectedBook + "'");
                    }
                    else
                    {
                        MessageBox.Show("Hope you will have a nice book read!");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                    MessageBox.Show("Hope you will have a nice book read!");
                }
            }
            
        }

        private void book_journal_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MemberPage("labiba").Show();
        }

        //this.bindGrid();

        ////StreamWriter listFile = new StreamWriter("D:\\Studies\\3.2\\SD\\LibraryManagement4\\LibraryManagement\\LibraryManagement\\Text files\\bookData.txt");
        ////for (int i = 0; i < 1; i++)
        ////{
        ////    listFile.Write(resultString[i]);
        ////    listFile.WriteLine(",");
        ////}
        ////listFile.Close();
        //if (!resultString.Any())
        //{
        //    MessageBox.Show("There is no such entry in our list!");
        //}
        //bookData.ColumnCount = 7;
        //for (int i = 0; i < 7; i++)
        //{
        //    bookData.Columns[i].HeaderCell.Value = columns[i];
        //}

        //bookData.DataSource = resultString;
        ////else
        ////{
        ////    bookData.ColumnCount = 7;
        ////    for (int i = 0; i < 7; i++)
        ////    {
        ////        bookData.Columns[i].HeaderCell.Value = columns[i];
        ////    }
        ////    using (StreamReader sr = new StreamReader("D:\\Studies\\3.2\\SD\\LibraryManagement4\\LibraryManagement\\LibraryManagement\\Text files\\bookData.txt"))
        ////        while (sr.Peek() > -1)
        ////            bookData.Rows.Add(sr.ReadLine().Split(','));
        ////}
    }

    //private void book_journal_Load(object sender, EventArgs e)
    //    {
    //        //this.bindGrid();
    //    }
    //    //private void bindGrid()
    //    //{
    //    //    server = "localhost";
    //    //    database = "the_athenaeum";
    //    //    uid = "root";
    //    //    password = " ";
    //    //    string connectionString;
    //    //    connectionString = "SERVER=" + server + ";" + "DATABASE=" +
    //    //                       database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
    //    //    searchString = searchInput.Text.ToString();
    //    //    //db.OpenConnection();
    //    //    query = "Select books.name as Book_title, books.pub_date as publication_date, " +
    //    //            "author.name as Author, genre.type as Genre, section.type as Section, " +
    //    //            "publisher.name as Publication, books.price as price from books inner join author " +
    //    //            "on books.a_id = author.id inner join genre on books.g_id = genre.ID" +
    //    //            " inner join section on books.s_id = section.id inner join publisher " +
    //    //            "on books.p_id = publisher.id where books.name = " + searchString + " or " +
    //    //            "genre.type = " + searchString + " or author.name = " + searchString + " or " +
    //    //            "section.type = " + searchString + " or publisher.name = " + searchString;
            

    //    //    //    MySqlConnection connection = new MySqlConnection(connectionString);
    //    //    //connection.Open();

    //    //    //MySqlDataAdapter MyDA = new MySqlDataAdapter();

    //    //    //MyDA.SelectCommand = new MySqlCommand(query, connection);

    //    //    //DataTable table = new DataTable();
    //    //    //MyDA.Fill(table);

    //    //    //BindingSource bSource = new BindingSource();
    //    //    //bSource.DataSource = table;


    //    //    //bookData.DataSource = bSource;
    //    //    //bookData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    //    //    //db.OpenConnection();
    //    //    //using (MySqlConnection con = new MySqlConnection(connectionString))
    //    //    //{
    //    //    //    using (MySqlCommand cmd = new MySqlCommand(query, con))
    //    //    //    {
    //    //    //        cmd.CommandType = CommandType.Text;
    //    //    //        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
    //    //    //        {
    //    //    //            using (DataTable dt = new DataTable())
    //    //    //            {
    //    //    //                //sda.Fill(dt);
    //    //    //                bookData.DataSource = dt;
    //    //    //            }
    //    //    //        }
    //    //    //    }
    //    //    //}
    //    //}
    }

