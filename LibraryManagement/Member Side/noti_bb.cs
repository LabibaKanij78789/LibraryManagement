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

namespace LibraryManagement
{
    public partial class noti_bb : Form
    {
        List<string> myList = new List<string>();
        int n, price = 0, i;
        string p, query, queryBuy, queryBorrow, user_id, total;
        string name;
        bool avail = false, flagBuy = false, flagBorrow = false;
        string[] colBuy = new[] { "Book Title", "Author", "Genre", "Price" };

        private void lineShape1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MemberPage("labiba").Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string[] id = new[] { "ID" };
                query = "select ID from grants where u_id = '" + user_id +
                        "' and taskDoneOrNot = '0'";
                resultString = db.selectSearch(query, id);
                int index = resultString.Count();
                //int[] totalPrice = new int[index];
                for (i = 0; i < index; i++)
                {
                    grantQuery += "grants.id = '" + resultString[i][0] + "'";
                    if (i < index - 1)
                    {
                        grantQuery += " or ";
                    }
                }
                string[] colG = new[] { "taskDoneOrNot", "new" };
                string[] vallG = new[] { "1", "4" };
                db.Update("grants", colG, vallG, " " + grantQuery);

                string[] avail = new[] { "available" };
                string[] getId = new[] { "getID" };
                string getQuery = "select DISTINCT(borrows.b_id + buys.b_id) as getID from borrows inner join " +
                                  "grants on borrows.g_id = grants.id inner join buys on grants.d = buys.g_id " +
                                  "where " + grantQuery;
                resultString = db.selectSearch(getQuery, getId);
                int c = resultString.Count;
                string[] aData = new string[c];
                for (i = 0; i < c; i++)
                {
                    bookQuery += "id = '" + resultString[i][0] + "'";
                    if (i < index - 1)
                    {
                        bookQuery += " or ";
                    }
                }

                int data;
                getQuery = "select available from books where " + bookQuery;
                resultString = db.selectSearch(getQuery, avail);
                for (i = 0; i < c; i++)
                {
                    aData[i] = resultString[i][0];
                    if (int.TryParse(aData[i], out data))
                    {
                        data += 1;
                        aData[i] = data.ToString();
                    }
                }
                db.Update("books", avail, aData, bookQuery);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string[] id = new[] { "ID" };
                query = "select ID from grants where u_id = '" + user_id +
                        "' and taskDoneOrNot = '0'";
                resultString = db.selectSearch(query, id);
                int index = resultString.Count();
                //int[] totalPrice = new int[index];
                for (i = 0; i < index; i++)
                {
                    grantQuery += "grants.id = '" + resultString[i][0] + "'";
                    if (i < index - 1)
                    {
                        grantQuery += " or ";
                    }
                }
                string[] colG = new[] { "taskDoneOrNot", "new" };
                string[] vallG = new[] { "1", "4" };
                db.Update("grants", colG, vallG, " " + grantQuery);

                string[] avail = new[] { "available" };
                string[] getId = new[] { "getID" };
                string getQuery = "select DISTINCT(borrows.b_id + buys.b_id) as getID from borrows inner join " +
                                  "grants on borrows.g_id = grants.id inner join buys on grants.d = buys.g_id " +
                                  "where " + grantQuery;
                resultString = db.selectSearch(getQuery, getId);
                int c = resultString.Count;
                string[] aData = new string[c];
                for (i = 0; i < c; i++)
                {
                    bookQuery += "id = '" + resultString[i][0] + "'";
                    if (i < index - 1)
                    {
                        bookQuery += " or ";
                    }
                }

                int data;
                getQuery = "select available from books where " + bookQuery;
                resultString = db.selectSearch(getQuery, avail);
                for (i = 0; i < c; i++)
                {
                    aData[i] = resultString[i][0];
                    if (int.TryParse(aData[i], out data))
                    {
                        data += 1;
                        aData[i] = data.ToString();
                    }
                }
                db.Update("books", avail, aData, bookQuery);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string[] id = new[] { "ID" };
                query = "select ID from grants where u_id = '" + user_id +
                        "' and taskDoneOrNot = '0'";
                resultString = db.selectSearch(query, id);
                int index = resultString.Count();
                //int[] totalPrice = new int[index];
                for (i = 0; i < index; i++)
                {
                    grantQuery += "grants.id = '" + resultString[i][0] + "'";
                    if (i < index - 1)
                    {
                        grantQuery += " or ";
                    }
                }
                string[] colG = new[] { "taskDoneOrNot", "new" };
                string[] vallG = new[] { "1", "4" };
                db.Update("grants", colG, vallG, " " + grantQuery);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string[] id = new[] { "ID" };
                query = "select ID from grants where u_id = '" + user_id +
                        "' and taskDoneOrNot = '0'";
                resultString = db.selectSearch(query, id);
                int index = resultString.Count();
                //int[] totalPrice = new int[index];
                for (i = 0; i < index; i++)
                {
                    grantQuery += "grants.id = '" + resultString[i][0] + "'";
                    if (i < index - 1)
                    {
                        grantQuery += " or ";
                    }
                }
                string[] colG = new[] {"taskDoneOrNot", "new"};
                string[] vallG = new[] { "1", "4" };
                db.Update("grants", colG, vallG, " "+grantQuery);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        string[] colBorrow = new[] { "Book Title", "Issue Date", "Return Date" };
        List<List<string>> resultString = new List<List<string>>();
        List<List<string>> resultBuy = new List<List<string>>();
        List<List<string>> resultBorrow = new List<List<string>>();
        string grantQuery = "", bookQuery = "";
        DBConnect db = new DBConnect();

        public noti_bb(List<string> books, int notiNo, string uName, string page, string userId)
        {
            InitializeComponent();
            myList = books;
            n = notiNo;
            name = uName;
            user_id = userId;
            groupBox1.BackColor = Color.Transparent;
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            dataGridView1.Hide();
            dataGridView2.Hide();
            p = page;
        }

        private void noti_bb_Load(object sender, EventArgs e)
        {
            try
            {
                if (p == "bj")
                {
                    label2.Text = "Request Pending";
                    label1.Text = "Please wait until librarian checks your request.";
                    groupBox2.Hide();

                }
                else if (p == "noti")
                {
                    label2.Text = n + " Notifications";
                    groupBox2.Show();
                    if (n > 0)
                    {
                        string[] id_type_total_new = new[] { "ID", "total", "Type", "new" };
                        query = "select ID, total, type, new from grants where u_id = '" + user_id +
                                "' and taskDoneOrNot = '0'";
                        resultString = db.selectSearch(query, id_type_total_new);
                        label1.Text = "Our librarian has checked your request,";

                        int index = resultString.Count();

                        int[] totalPrice = new int[index];
                        for (i = 0; i < index; i++)
                        {
                            if (!avail && resultString[i][3].Equals('2'))
                            {
                                avail = true;
                                //break;
                            }

                            if (!flagBorrow && resultString[i][2].Equals('w'))
                            {
                                flagBorrow = true;

                            }

                            if (!flagBuy && resultString[i][2].Equals('y'))
                            {
                                flagBuy = true;


                            }

                            totalPrice[i] = Convert.ToInt16(resultString[i][1]);
                            price += totalPrice[i];
                            grantQuery += "grants.id = '" + resultString[i][0] + "'";
                            if (i < index - 1)
                            {
                                grantQuery += " or ";
                            }
                        }

                        Label av = new Label();
                        if (!avail)
                        {
                            label1.Text += " but unfortunately there is no book available.";
                        }
                        else
                        {
                            label1.Text += " and the following books are available.";
                            //fetch buy data of (boook.name, book.author, book.genre, book.price of gid, avail, u_id
                            queryBuy = "select books.name, books.author, books.genre, books.price " +
                                       "from books inner join buys on books.id = buys.b_id inner join grants on " +
                                       "buys.g_id = grants.id where buys.avail = '1' and " + grantQuery;
                            string[] colY = new[] { "books.name", "books.author", "books.genre", "books.price" };

                            //fetch borrow data of (boook.name, borrows.borrow_date, borrows.returndate,  of gid, avail, u_id
                            queryBorrow = "select books.name, borrows.borrow_date, borrows.return_date " +
                                          "from books inner join borrows on books.id = borrows.b_id inner join grants on " +
                                          "borrows.g_id = grants.id where borrows.avail = '1' and " + grantQuery;
                            string[] colW = new[] { "books.name", "borrows.borrow_date", "borrows.return_date" };
                            if (flagBorrow && flagBuy)
                            {
                                //for buy table
                                label3.Show();
                                label3.Text = "Buy";
                                dataGridView1.Show();
                                resultBuy = db.selectSearch(queryBuy, colY);
                                DataTable tableBuy = new DataTable();
                                for (i = 0; i < colBuy.Length; i++)
                                {
                                    tableBuy.Columns.Add(colBuy[i]);
                                }

                                foreach (var array in resultBuy)
                                {
                                    tableBuy.Rows.Add(array.ToArray());
                                }

                                dataGridView1.DataSource = tableBuy;
                                label5.Show();
                                //label3.Text = "Buy";
                                label6.Show();
                                label6.Text = price.ToString();

                                button1.Show();
                                button2.Show();
                                button3.Show();
                                button4.Show();

                                //for borrow table
                                label4.Show();
                                label4.Text = "Borrow";
                                dataGridView2.Show();
                                resultBorrow = db.selectSearch(queryBorrow, colW);
                                DataTable tableBorrow = new DataTable();
                                for (i = 0; i < colBorrow.Length; i++)
                                {
                                    tableBorrow.Columns.Add(colBorrow[i]);
                                }

                                foreach (var array in resultBorrow)
                                {
                                    tableBorrow.Rows.Add(array.ToArray());
                                }

                                dataGridView2.DataSource = tableBorrow;
                            }
                            else if (!flagBorrow && flagBuy)
                            {
                                label3.Show();
                                label3.Text = "Buy";
                                dataGridView1.Show();
                                resultBuy = db.selectSearch(queryBuy, colY);
                                DataTable tableBuy = new DataTable();
                                for (int i = 0; i < colBuy.Length; i++)
                                {
                                    tableBuy.Columns.Add(colBuy[i]);
                                }

                                foreach (var array in resultBuy)
                                {
                                    tableBuy.Rows.Add(array.ToArray());
                                }

                                dataGridView1.DataSource = tableBuy;
                                label5.Show();
                                //label3.Text = "Buy";
                                label6.Show();
                                label6.Text = price.ToString();
                                button1.Show();
                                button2.Show();
                                //button3.Show();
                                //button4.Show();

                                dataGridView2.Hide();
                            }
                            else if (flagBorrow && !flagBuy)
                            {
                                dataGridView1.Show();
                                resultBorrow = db.selectSearch(queryBorrow, colW);
                                DataTable tableBorrow = new DataTable();
                                for (int i = 0; i < colBorrow.Length; i++)
                                {
                                    tableBorrow.Columns.Add(colBorrow[i]);
                                }

                                foreach (var array in resultBorrow)
                                {
                                    tableBorrow.Rows.Add(array.ToArray());
                                }

                                dataGridView1.DataSource = tableBorrow;
                                button1.Show();
                                button2.Show();
                                //button3.Show();
                                //button4.Show();

                                dataGridView2.Hide();
                            }

                        }
                    }

                    else
                    {
                        label1.Text = "Sorry! Your request hasn't been check yet.";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
