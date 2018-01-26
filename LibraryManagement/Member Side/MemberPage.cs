using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Documents;
using System.Windows.Forms;
using static LibraryManagement.DBConnect;
namespace LibraryManagement
{
    public partial class MemberPage : Form
    {
        int i = 0, n;
        LinkLabel a = new LinkLabel();
        LinkLabel b = new LinkLabel();
        string selectedBook;
        string bl, userId;
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
            book_journal ob = new book_journal("labiba", userId);
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
            string q = "select id from user where Name = '" + name + "'";
            string[] columns1 = new[] { "id" };
            try
            {
                result = instance.selectSearch(q, columns1);

                foreach (List<string> s in result)
                {
                    foreach (string r in s)
                    {
                        userId = r;
                    }
                }
                
                    string query = "select reqPending from user where id = '" + userId + "'";
                    result = instance.selectSearch(query, new[] { "reqPending" });
                    int.TryParse(result[0][0], out n);
                    if (n <= 0)
                    {
                        pictureBox4.Enabled = false;
                        Noti.Enabled = false;
                    }
                    

                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
                throw;
            }
        }

        private void pbj_Click(object sender, EventArgs e)
        {
           book_journal ob = new book_journal("labiba", userId);
           this.Hide();
            ob.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pbl_Click(object sender, EventArgs e)
        {
            try
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
                bookLog blg = new bookLog(name, null, null, bookLog, "m");
                this.Hide();
                blg.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void BL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            book_possession bp = new book_possession();
            this.Hide();
            bp.Show();
        }

        private void BP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            update_profile up = new update_profile(name);
            this.Hide();
            up.Show();
        }

        private void UP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new noti_bb(null, n, name, "noti", userId);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string search = searchText.Text.ToString();
            try
            {
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
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
                //throw;
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //viewBookDetails vb = new viewBookDetails(selectedBook, name);
            //viewBookDetails vb = new viewBookDetails(selectedBook, name);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    selectedBook = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void bookL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string q = "select bookLog from book_log inner join user where book_log.u_id = user.id where id = " +
                           userId;
                string[] col = new[] {"bookLog"};

                result = instance.selectSearch(q, col);
                foreach (List<string> s in result)
                {
                    foreach (string r in s)
                    {
                        bl = r;
                    }
                }

                Boolean bookLog = Convert.ToBoolean(bl);
                bookLog blg = new bookLog(name, null, null, bookLog, "m");
                this.Hide();
                blg.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
    }

        private void Noti_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new noti_bb(null, n, name, "noti", userId);
        }

        private void bookP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                book_possession bp = new book_possession();
                this.Hide();
                bp.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
                throw;
            }
            
        }

        private void upP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                update_profile up = new update_profile(name);
                this.Hide();
                up.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
                throw;
            }
            
        }
    }
}
