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
    public partial class ReturnBook : Form
    {
        public ReturnBook()
        {
            InitializeComponent();
            FillCombo();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J2E5UDC\SQLEXPRESS;Initial Catalog=lms;Integrated Security=True");

        bool flag = false;
        private void FillCombo()
        {
            con.Open();
            String query = "SELECT name FROM Newbook1;";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["name"].ToString());
            }
            con.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
          try
            {
                //label5.Visible = true;
                label4.Visible = true;
                label3.Visible = true;
                label7.Visible = true;
                label6.Visible = true;
                label12.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                label15.Visible = true;

                //txtmemberid.Visible = true;
                txtname.Visible = true;
                txtcourse.Visible = true;
                txtyear.Visible = true;
                txtsemester.Visible = true;
                txtbookid.Visible = true;
                txtedition.Visible = true;
                txtpublisher.Visible = true;
                txtauthor.Visible = true;
                txtgenre.Visible = true;
                txtissuedate.Visible = true;
                String s = null;
                int i;

                con.Open();
                String query = "SELECT bookid FROM Newbook1 WHERE name='" +   comboBox1.Text + "'; ";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    s = (dr["bookid"].ToString());

                }
            dr.Close();
                i = Convert.ToInt32(s);
                String query1 = "SELECT issuedate FROM Issuebook WHERE studentid=" + txtstudentid.Text + "AND memberid=" + txtmemberid.Text + "AND bookid=" +i + "; ";
                SqlCommand cmd1 = new SqlCommand(query1, con);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                if (dr1.Read())
                {
                    flag = true;
                    txtissuedate.Text = (dr1["issuedate"].ToString());

                }
            dr1.Close();


            String query2 = "SELECT name,course ,year,semester FROM NewStudent1 WHERE studentid=" + txtstudentid.Text + "AND memberid=" + txtmemberid.Text + "; ";
            SqlCommand cmd2 = new SqlCommand(query2, con);
            SqlDataReader dr2 = cmd2.ExecuteReader();
            if (dr2.Read())
            {

                txtname.Text = (dr2["name"].ToString());
                txtcourse.Text = (dr2["course"].ToString());
                txtyear.Text = (dr2["year"].ToString());
                txtsemester.Text = (dr2["semester"].ToString());   
            }
            dr2.Close();


            String query3 = "SELECT bookid,edition,publisher,author,genre FROM Newbook1 WHERE name='" + comboBox1.Text +  "'; ";
            SqlCommand cmd3 = new SqlCommand(query3, con);
            SqlDataReader dr3 = cmd3.ExecuteReader();
            if (dr3.Read())
            {
                txtbookid.Text = (dr3["bookid"].ToString());
                txtedition.Text = (dr3["edition"].ToString());
                txtpublisher.Text = (dr3["publisher"].ToString());
                txtauthor.Text = (dr3["author"].ToString());
                txtgenre.Text = (dr3["genre"].ToString());

            }
            dr3.Close();
            con.Close();
            }catch(Exception ex) { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainpage ob = new mainpage();
            this.Hide();
            ob.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // String s;
            con.Open();
            if (flag == true)
            {

                String  stuid1 = txtstudentid.Text;
                String memid1 = txtmemberid.Text;
                String  bookid1= txtbookid.Text;
                String date = returndate.Text;
                int stuid = Convert.ToInt32(stuid1);
                int memid = Convert.ToInt32(memid1);
                int bookid = Convert.ToInt32(bookid1);

                String q = "INSERT INTO ReturnBook(studentid,memberid,bookid,returndate) VALUES(" + stuid + "," + memid + "," + bookid + ",'" + date + "');";
                SqlCommand cmd = new SqlCommand(q, con);
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Close();



                String query3 = "SELECT amount FROM Newbook1 WHERE name='" + comboBox1.Text + "'; ";
                SqlCommand cmd3 = new SqlCommand(query3, con);
                SqlDataReader dr3 = cmd3.ExecuteReader();
                String amount = null;
                if (dr3.Read())
                {
                    amount= (dr3["amount"].ToString());
                    

                }
                dr3.Close();
                int n;
                n = Convert.ToInt32(amount);
                n++;
                String query1 = "UPDATE Newbook1 SET amount="+n+"WHERE name='"+comboBox1.Text+"';";

                SqlDataAdapter SDA1 = new SqlDataAdapter(query1, con);
                SDA1.SelectCommand.ExecuteNonQuery();

                MessageBox.Show("This Book is now available for Issue");
                
            }

            else
            {
                MessageBox.Show("You don't Issue this book \n so why do you want to return??");
            }
           
            //s = Convert.ToString(flag);
            //MessageBox.Show(s);
            con.Close();
        }
    }
}
