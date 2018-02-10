using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LibraryManagement.DBConnect;
namespace LibraryManagement.Member_Side
{
    public partial class get_suggestion : Form
    {
        string start, end, author, genre;
        public get_suggestion(string uName, string userID)
        {
            InitializeComponent();
            dataGridView1.Hide();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy";
            dateTimePicker1.ShowUpDown = true;

            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "yyyy";
            dateTimePicker2.ShowUpDown = true;
            AuthorLab.BackColor = Color.Transparent;
            genreLab.BackColor = Color.Transparent;
            era.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            start = null;
            end = null;
            author = null;
            genre = null;
        }
        List<List<string>> result = new List<List<string>>();
        List<List<string>> resulta = new List<List<string>>();
        string query;
        List<List<string>> resultg = new List<List<string>>();
        DBConnect db = new DBConnect();
        string[] columns = new[] { "Title", "Author", "Genre", "Publication Date" };
        private void auth_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void get_suggestion_Load(object sender, EventArgs e)
        {
            // author
            //resulta.Clear();
            title.BackColor = Color.Transparent;
            query = "select a_name, a_id from author";
            resulta = db.selectSearch(query, new[] { "a_name", "a_id" });
            string[] authData = new string[resulta.Count];
            //DataTable tableBuy = new DataTable();
            //authData[0] = null;
            for (int i = 0; i < resulta.Count; i++)
            {
                authData[i] = resulta[i][0];
                //bookame[i] = result[i][0];

            }
            auth.DataSource = authData;

            //genre
            query = "select g_type, g_id from genre";
            resultg = db.selectSearch(query, new[] { "g_type", "g_id" });
            string[] genData = new string[resultg.Count];
            //genData[0]
            //DataTable tableBuy = new DataTable();
            for (int i = 0; i < resultg.Count; i++)
            {
                genData[i] = resultg[i][0];
                //bookame[i] = result[i][0];

            }
            gen.DataSource = genData;
        }
        private void fillTable(string[] columns, DataGridView data, List<List<string>> res)
        {

            DataTable table = new DataTable();
            for (int i = 0; i < columns.Length; i++)
            {
                table.Columns.Add(columns[i]);
            }
            foreach (var array in res)
            {
                table.Rows.Add(array.ToArray());
            }
            data.DataSource = table;
        }

        private void gen_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            start = DateTime.Parse(dateTimePicker1.Value.ToString()).Year.ToString();
            fetchData(author, genre, start, end);
        }

        private void auth_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            author = auth.SelectedItem.ToString();
            fetchData(author, genre, start, end);
        }

        private void gen_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            genre = gen.SelectedItem.ToString();
            fetchData(author, genre, start, end);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MemberPage("labiba").Show();
        }

        private void fetchData(string author, string genre, string start, string end)
        {

            try
            {
                dataGridView1.Show();
                //1111
                if (genre != null && start != null && end != null && author != null)
                {
                    query = "select b_name, a_name, g_type, pub_date from books inner join author on books.a_id = " +
                        "author.a_id inner join genre on books.g_id = genre.g_id where a_name = '"
                        + author + "' and g_type = '" + genre + "' and year(pub_date) between '" +
                        start + "' and '" + end + "'";

                }
                //1110
                else if (genre != null && start != null && end == null && author != null)
                {
                    query = "select b_name, a_name, g_type, pub_date from books inner join author on books.a_id = " +
                        "author.a_id inner join genre on books.g_id = genre.g_id where a_name = '"
                        + auth.SelectedItem.ToString() + "' and g_type = '" + genre + "' and year(pub_date) = '" + start + "'";
                }

                //1101
                else if (genre != null && start == null && end != null && author != null)
                {
                    query = "select b_name, a_name, g_type, pub_date from books inner join author on books.a_id = " +
                        "author.a_id inner join genre on books.g_id = genre.g_id where a_name = '"
                        + auth.SelectedItem.ToString() + "' and g_type = '" + genre + "' and year(pub_date) = '" + end + "'";
                }

                //1100
                else if (genre != null && start == null && end == null && author != null)
                {
                    query = "select b_name, a_name, g_type, pub_date from books inner join author on books.a_id = " +
                        "author.a_id inner join genre on books.g_id = genre.g_id where a_name = '"
                        + auth.SelectedItem.ToString() + "' and g_type = '" + genre + "'";
                }
                //1011
                else if (genre == null && start != null && end != null && author != null)
                {
                    query = "select b_name, a_name, g_type, pub_date from books inner join author on books.a_id = " +
                       "author.a_id inner join genre on books.g_id = genre.g_id where a_name = '"
                       + auth.SelectedItem.ToString() + "' and year(pub_date) between '" +
                       start + "' and '" + end + "'";
                }

                //1010
                else if (genre == null && start != null && end == null && author != null)
                {
                    query = "select b_name, a_name, g_type, pub_date from books inner join author on books.a_id = " +
                       "author.a_id inner join genre on books.g_id = genre.g_id where a_name = '"
                       + auth.SelectedItem.ToString() + "' and year(pub_date) = '" + start + "'";
                }

                //1001
                else if (genre == null && start == null && end != null && author != null)
                {
                    query = "select b_name, a_name, g_type, pub_date from books inner join author on books.a_id = " +
                       "author.a_id inner join genre on books.g_id = genre.g_id where a_name = '"
                       + auth.SelectedItem.ToString() + "' and year(pub_date) = '" + end + "'";
                }

                //1000
                else if (genre == null && start == null && end == null && author != null)
                {
                    query = "select b_name, a_name, g_type, pub_date from books inner join author on books.a_id = " +
                       "author.a_id inner join genre on books.g_id = genre.g_id where a_name = '"
                       + auth.SelectedItem.ToString() + "'";
                }

                //0111
                else if (genre != null && start != null && end != null && author == null)
                {
                    query = "select b_name, a_name, g_type, pub_date from books inner join author on books.a_id = " +
                        "author.a_id inner join genre on books.g_id = genre.g_id where g_type = '" + genre + "' and year(pub_date) between '" +
                        start + "' and '" + end + "'";

                }

                //0110
                else if (genre != null && start != null && end == null && author == null)
                {
                    query = "select b_name, a_name, g_type, pub_date from books inner join author on books.a_id = " +
                        "author.a_id inner join genre on books.g_id = genre.g_id where g_type = '" + genre + "' and year(pub_date) = '" + start + "'";
                }

                //0101
                else if (genre != null && start == null && end != null && author == null)
                {
                    query = "select b_name, a_name, g_type, pub_date from books inner join author on books.a_id = " +
                        "author.a_id inner join genre on books.g_id = genre.g_id where g_type = '" + genre + "' and year(pub_date) = '" + end + "'";
                }

                //0100
                else if (genre != null && start == null && end == null && author == null)
                {
                    query = "select b_name, a_name, g_type, pub_date from books inner join author on books.a_id = " +
                        "author.a_id inner join genre on books.g_id = genre.g_id where g_type = '" + genre + "'";
                }

                //0011
                else if (genre == null && start != null && end != null && author == null)
                {
                    query = "select b_name, a_name, g_type, pub_date from books inner join author on books.a_id = " +
                       "author.a_id inner join genre on books.g_id = genre.g_id where year(pub_date) between '" +
                       start + "' and '" + end + "'";
                }

                //0010
                else if (genre == null && start != null && end == null && author == null)
                {
                    query = "select b_name, a_name, g_type, pub_date from books inner join author on books.a_id = " +
                       "author.a_id inner join genre on books.g_id = genre.g_id where year(pub_date) = '" + start + "'";
                }

                //0001
                else if (genre == null && start == null && end != null && author == null)
                {
                    query = "select b_name, a_name, g_type, pub_date from books inner join author on books.a_id = " +
                       "author.a_id inner join genre on books.g_id = genre.g_id where year(pub_date) = '" + end + "'";
                }

                //000

                else
                {
                    dataGridView1.Hide();
                }
                result.Clear();
                result = db.selectSearch(query, new[] { "b_name", "a_name", "g_type", "pub_date" });

                fillTable(columns, dataGridView1, result);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
                throw;
            }
        }
        private void lineShape1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            end = DateTime.Parse(dateTimePicker2.Value.ToString()).Year.ToString();
            fetchData(author, genre, start, end);
        }
    }
}
