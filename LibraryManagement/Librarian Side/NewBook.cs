using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Windows.Documents;
using  static  LibraryManagement.DBConnect;
namespace LibraryManagement
{
    public partial class NewBook : Form
    {
        List<Panel> Panel = new List<Panel>();
        int item = 0;
        string name, edition1, price1, author, genre, publisher, section, amount1;
        List<List<string>> resultp = new List<List<string>>();
        List<List<string>> resulta = new List<List<string>>();
        List<List<string>> resultg = new List<List<string>>();
        List<List<string>> results = new List<List<string>>();
        DBConnect db = new DBConnect();

        private void sec_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string query = "selct id from section where type = '" + sec.SelectedItem.ToString() + "'";
                results.Clear();
                results = db.selectSearch(query, new[] {"id"});
                section = results[0][0];
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
                throw;
            }
            
        }

        private void pub_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string query = "selct id from publisher where name = '" + pub.SelectedItem.ToString() + "'";
                resultp.Clear();
                resultp = db.selectSearch(query, new[] { "id" });
                publisher = resultp[0][0];
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
                throw;
            }
            //publisher = pub.SelectedItem.ToString();
        }

        private void gen_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string query = "selct id from genre where type = '" + gen.SelectedItem.ToString() + "'";
                resultg.Clear();
                resultg = db.selectSearch(query, new[] { "id" });
                genre = resultg[0][0];
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
                throw;
            }
        }

        private void auth_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string query = "selct id from author where name = '" + auth.SelectedItem.ToString() + "'";
                resulta.Clear();
                resulta = db.selectSearch(query, new[] { "id" });
                publisher = resulta[0][0];
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
                throw;
            }
        }

        private void NewBook_Load(object sender, EventArgs e)
        {
            //publisher

            string query = "select name, id from publisher";
            resultp = db.selectSearch(query, new[] { "name", "id" });
            string[] pubData = new string[resultp.Count];
            //DataTable tableBuy = new DataTable();
            for (int i = 0; i < resultp.Count; i++)
            {
                pubData[i] = resultp[i][0];
                //bookame[i] = result[i][0];

            }
            pub.DataSource = pubData;

            // author
            //resulta.Clear();
            query = "select name, id from author";
            resulta = db.selectSearch(query, new[] { "name", "id" });
            string[] authData = new string[resulta.Count];
            //DataTable tableBuy = new DataTable();
            for (int i = 0; i < resulta.Count; i++)
            {
                authData[i] = resulta[i][0];
                //bookame[i] = result[i][0];

            }
            auth.DataSource = authData;

            //genre
            query = "select type, id from genre";
            results = db.selectSearch(query, new[] { "type", "id" });
            string[] genData = new string[resultg.Count];
            //DataTable tableBuy = new DataTable();
            for (int i = 0; i < resultg.Count; i++)
            {
                genData[i] = resultg[i][0];
                //bookame[i] = result[i][0];

            }
            gen.DataSource = genData;

            //section

            query = "select type, id from genre";
            results = db.selectSearch(query, new[] { "type", "id" });
            string[] secData = new string[results.Count];
            //DataTable tableBuy = new DataTable();
            for (int i = 0; i < results.Count; i++)
            {
                secData[i] = results[i][0];
                //bookame[i] = result[i][0];

            }
            sec.DataSource = secData;
        }

        public NewBook()
        {
            InitializeComponent();
            Panel.Add(panel1);
            Panel.Add(panel2);
            Panel[item].BringToFront();
        }
        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J2E5UDC\SQLEXPRESS;Initial Catalog=lms;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (item < Panel.Count - 1)
                {
                    Panel[++item].BringToFront();
                }
                else
                {
                    MessageBox.Show("No available pages ");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No available page");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (item > 0)
                {
                    Panel[--item].BringToFront();
                }
                else
                {
                    MessageBox.Show("No available pages ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No available pages ");
            }

        
    }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                mainpage ob = new mainpage();
                this.Hide();
                ob.Show();
            }
            catch (Exception ex)
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                
                
                //bookid1 = txtbookid.Text;
                name = txtname.Text;
                edition1 = dateTimePicker1.Value.ToString("yyyy-MM-dd");
               // status = txtstatus.Text;
                price1 = txtprice.Text;
                //author = txtauthor.Text;
                //genre = txtgenre.Text;
                //publisher = txtpublisher.Text;
                //section = txtsection.Text;
                amount1 = txtamount.Text;
                string[] col = new[] {"name", "pub_date", "g_id", "a_id", "p_id", "s_id", "price", "available"};
                string[] val = new[] {name, edition1, genre, author, publisher, section, price1, amount1};
                db.Insert("books", col, val);
                
                //MessageBox.Show("New Book record is created ");



            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
