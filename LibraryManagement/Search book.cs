using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Forms;
using static LibraryManagement.DBConnect;

namespace LibraryManagement
{

    public partial class Search_book : Form
    {
        string search;
        DBConnect db = new DBConnect();
        string q;
        string[] col = new []{"book_title"};
        List<List<string>> result = new List<List<string>>();

        string getStatus;
        //string conQ;
        //private List<string>[] result = new List<string>[10];
        //Label[] label = new Label[100];
        //Label[] labels ;
        //labels[0] = new Label();
        //private int locX = 235, locY = 122;
        //private int sizeX = 200, sizeY = 27;
        string selectedBook;
       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    selectedBook = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                }
            
        }

        private string name;
        public Search_book(string uName)
        {
            InitializeComponent();
            name = uName;
            //for (int i = 0; i < 100; i++)
            //{
            //    result[i].Add("infinity10000");
            //}
            //pb.ImageLocation =
            //   @"D:\\Studies\\3.2\\SD\\LibraryManagement4\\LibraryManagement\\LibraryManagement\\bin\\Image\\arish.png";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            search = searchBox.Text.ToString();
            q = "Select books.name as book_title from books inner join author " +
                "on books.a_id = author.id inner join genre on books.g_id = genre.ID" +
                " inner join section on books.s_id = section.id inner join publisher " +
                "on books.p_id = publisher.id where books.name = '" + search + "' or " +
                "genre.type = '" + search + "' or author.name = '" + search + "' or " +
                "section.type = '" + search + "' or publisher.name = '" + search + "'";


            try
            {
                result = db.selectSearch(q, col);
                DataTable table = new DataTable();
                for (int i = 0; i < 1; i++)
                {
                    table.Columns.Add(col[i]);
                }
                foreach (var array in result)
                {
                    table.Rows.Add(array.ToArray());
                }
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            bookLog bl = new bookLog(name, selectedBook, getStatus, true, "p");
            this.Hide();
            bl.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ComboBoxItem select = (ComboBoxItem)comboBox1.SelectedItem;
            
            //getStatus = select.ToString();
            getStatus = comboBox1.SelectedItem.ToString();
            MessageBox.Show(getStatus);
        }

        private void Search_book_Load(object sender, EventArgs e)
        {

        }
    }
}
