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
namespace LibraryManagement
{
    public partial class book_journal : Form
    {
        bool flag = false;
        string searchString;
        string query;
        DBConnect db = new DBConnect();
        private List<string>[] resultString = new List<string>[100000];
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
            query = "Select books.name as Book_title, books.pub_date as publication_date, " +
                    "author.name as Author, genre.type as Genre, section.type as Section, " +
                    "publisher.name as Publication, books.price as price from books inner join author " +
                    "on books.a_id = author.id inner join genre on books.g_id = genre.ID" +
                    " inner join section on books.s_id = section.id inner join publisher " +
                    "on books.p_id = publisher.id where books.name = " + searchString + " or " +
                    "genre.type = " + searchString + " or author.name = " + searchString + " or " +
                    "section.type = " + searchString + " or publisher.name = " + searchString;
            string [] columns = new[] {"Book Title", "Publication Date", "Author", "Genre", "Section", "Publication", "Price"};
            resultString = db.selectSearch(query, columns);
            StreamWriter listFile = new StreamWriter("D:\\Studies\\3.2\\SD\\LibraryManagement4\\LibraryManagement\\LibraryManagement\\Text files\\bookData.txt");
            for (int i = 0; i < resultString.Length; i++)
            {
                listFile.Write(resultString[i]);
                listFile.WriteLine(",");
            }
            
            if (!resultString.Any())
            {
                MessageBox.Show("There is no such entry in our list!");
            }
            else
            {
                bookData.ColumnCount = 4;
                bookData.Columns[0].HeaderCell.Value = "ID";
                bookData.Columns[1].HeaderCell.Value = "Author";
                bookData.Columns[2].HeaderCell.Value = "Caption";
                bookData.Columns[3].HeaderCell.Value = "Categories";
                using (StreamReader sr = new StreamReader("D:\\Studies\\3.2\\SD\\LibraryManagement4\\LibraryManagement\\LibraryManagement\\Text files\\bookData.txt"))
                    while (sr.Peek() > -1)
                        bookData.Rows.Add(sr.ReadLine().Split(','));
            }
        }
    }
}
