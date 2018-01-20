using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using static LibraryManagement.DBConnect;
namespace LibraryManagement
{
    public partial class MemberPage : Form
    {
        int i = 0;
        LinkLabel a = new LinkLabel();
        LinkLabel b = new LinkLabel();
        string selectedBook;
        string bl;
        DBConnect instance = new DBConnect();
        List<List<string>> result = new List<List<string>>();
        public string name;
        public MemberPage(string uName)
        {
            InitializeComponent();
           title.BackColor = Color.Transparent;
            name = uName;
            userName.Text = userName.Text + uName;
            pictureBox1.BackColor = Color.Transparent;
            pbj.BackColor = Color.Transparent;
            pgs.BackColor = Color.Transparent;
            groupBox1.BackColor = Color.Transparent;
            groupBox2.BackColor = Color.Transparent;
            pbl.BackColor = Color.Transparent;
            groupBox1.Show();
            groupBox2.Show();
            dataGridView1.Hide();
            button2.Hide();
            //profile.Size = new Size(profile.Width, profile.Height);
        }

        public void nameUser()
        {
            
        }

        private void logoff_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void profile_Click(object sender, EventArgs e)
        {
            //this.profile.Image = Image.FromFile("user.png");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            i++;
            if (i % 2 == 1)
            {
                
                a.Location = new Point(1150, 70);
                a.Size = new Size(87, 30);
                a.Text = "Delete User";
                this.Controls.Add(a);
                a.Show();

                b.Location = new Point(1150, 110);
                b.Size = new Size(87, 30);
                b.Text = "Log out";
                this.Controls.Add(b);
                b.Show();

            }
            else
            {
                a.Hide();
                b.Hide();
                
                

            }
            
            
            
        }
        
        
        void b_clicked(object sender, LinkLabelLinkClickedEventArgs c)
        {
            LinkLabel b = sender as LinkLabel;

            if (b != null)
            {
                Form1 ob = new Form1();
                this.Hide();
                ob.Show();
            }
        }
        void a_clicked(object sender, LinkLabelLinkClickedEventArgs c)
        {
            LinkLabel a = sender as LinkLabel;
            
            if (a != null)
            {
                instance.Delete("user","Name", name );
                Form1 ob = new Form1();
                this.Hide();
                ob.Show();
            }
        }

        private void BJ_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            book_journal ob = new book_journal();
            this.Hide();
            ob.Show();
        }

        private void GS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void MemberPage_Load(object sender, EventArgs e)
        {

        }

        private void pbj_Click(object sender, EventArgs e)
        {
           book_journal ob = new book_journal();
           this.Hide();
            ob.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pbl_Click(object sender, EventArgs e)
        {
            string q = "select bookLog from book_log inner join user where book_log.u_id = user.id";
            string[] col = new[] {"bookLog"};
            
            result = instance.selectSearch(q, col);
            foreach (List<string> s in result)
            {
                foreach (string r in s)
                {
                   bl  = r;
                }
            }

            
            Boolean bookLog = Convert.ToBoolean(bl);
            bookLog blg = new bookLog(name, null, null, bookLog);
            this.Hide();
            blg.Show();
        }

        private void BL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string q = "select bookLog from book_log inner join user where book_log.u_id = user.id";
            string[] col = new[] { "bookLog" };

            result = instance.selectSearch(q, col);
            foreach (List<string> s in result)
            {
                foreach (string r in s)
                {
                    bl = r;
                }
            }

            Boolean bookLog = Convert.ToBoolean(bl);
            bookLog blg = new bookLog(name, null, null, bookLog);
            this.Hide();
            blg.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            book_possession bp = new book_possession();
            this.Hide();
            bp.Show();
        }

        private void BP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            book_possession bp = new book_possession();
            this.Hide();
            bp.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            update_profile up = new update_profile(name);
            this.Hide();
            up.Show();
        }

        private void UP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            update_profile up = new update_profile(name);
            this.Hide();
            up.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string search = searchText.Text.ToString();
            groupBox1.Hide();
            groupBox2.Hide();
            dataGridView1.Show();
            button2.Show();
            string searchString = searchText.Text.ToString();
            //db.OpenConnection();

            string[] columns = new[] { "Book_title", "publication_date", "Author", "Genre", "Section", "Publication", "price" };
            string query = "Select books.name as Book_title, books.pub_date as publication_date, " +
                    "author.name as Author, genre.type as Genre, section.type as Section, " +
                    "publisher.name as Publication, books.price as price from books inner join author " +
                    "on books.a_id = author.id inner join genre on books.g_id = genre.ID" +
                    " inner join section on books.s_id = section.id inner join publisher " +
                    "on books.p_id = publisher.id where books.name = '" + searchString + "' or " +
                    "genre.type = '" + searchString + "' or author.name = '" + searchString + "' or " +
                    "section.type = '" + searchString + "' or publisher.name = '" + searchString + "'";
            List<List<string>> resultString = new List<List<string>>();
                resultString = instance.selectSearch(query, columns);
            dataGridView1.ColumnCount = 7;
            for (int i = 0; i < 7; i++)
            {
                dataGridView1.Columns[i].HeaderCell.Value = columns[i];
            }
            DataTable table = new DataTable();
            for (int i = 0; i < 7; i++)
            {
                table.Columns.Add(columns[i]);
            }
            foreach (var array in resultString)
            {
                table.Rows.Add(array.ToArray());
            }
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                selectedBook = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            }
        }
    }
}
