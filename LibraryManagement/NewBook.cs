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

namespace LibraryManagement
{
    public partial class NewBook : Form
    {
        List<Panel> Panel = new List<Panel>();
        int item = 0;
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
                //con.Open();
                String bookid1, name, edition1, status, price1, author, genre, publisher, section, amount1;
                bookid1 = txtbookid.Text;
                name = txtname.Text;
                edition1 = txtedition.Text;
                status = txtstatus.Text;
                price1 = txtprice.Text;
                author = txtauthor.Text;
                genre = txtgenre.Text;
                publisher = txtpublisher.Text;
                section = txtsection.Text;
                amount1 = txtamount.Text;

                int bookid, edition, amount, price;
                bookid = Convert.ToInt32(bookid1);
                price = Convert.ToInt32(price1);
                edition = Convert.ToInt32(edition1);
                amount = Convert.ToInt32(amount1);


                String query = "INSERT INTO Newbook1(bookid,name,edition,bookstatus,price,author,genre,publisher,section,amount)Values(" + bookid + ",'" + name + "'," + edition + ",'" + status + "'," + price + ",'" + author + "','" + genre + "','" + publisher + "','" + section + "'," + amount + ");";
               // SqlDataAdapter SDA = new SqlDataAdapter(query, con);
               // SDA.SelectCommand.ExecuteNonQuery();
                //con.Close();
                MessageBox.Show("New Book record is created ");



            }
            catch ( Exception ex)
            {

            }
        }
    }
}
