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
    public partial class Issuebook : Form
    {
        public Issuebook()
        {
            InitializeComponent();
            FillCombo();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J2E5UDC\SQLEXPRESS;Initial Catalog=lms;Integrated Security=True");
        
        private void button2_Click(object sender, EventArgs e)
        {
            mainpage ob = new mainpage();
            this.Hide();
            ob.Show();
        }
        private void FillCombo()
        {
            con.Open();
            String query = "SELECT name FROM Newbook1;";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                comboBox1.Items.Add(dr["name"].ToString());
            }
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();


               // label5.Visible = true;
                label4.Visible = true;
                label3.Visible = true;
                label7.Visible = true;
                label6.Visible = true;
                label12.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;

                txtstudentname.Visible = true;
              //  txtmemid.Visible = true;
                txtcourse.Visible = true;
                txtyear.Visible = true;
                txtsemester.Visible = true;

                txtbookid.Visible = true;
                txtedition.Visible = true;
                txtpublisher.Visible = true;
                txtauthor.Visible = true;
                txtgenre.Visible = true;
                
                String studentid1,memberid1;
                String bookname;
                studentid1 = txtstudentid.Text;
                memberid1=txtmemid.Text;
                bookname = comboBox1.Text;
                int studentid;
                int memberid;
               
               
                studentid = Convert.ToInt32(studentid1);
                memberid = Convert.ToInt32(memberid1);
            
            
            String query2 = "SELECT name ,course,year,semester FROM NewStudent1 WHERE studentid=" + studentid + "and memberid="+memberid+";";
            
            SqlCommand cmd2 = new SqlCommand(query2, con);
            SqlDataReader dr2 = cmd2.ExecuteReader();
                if (dr2.Read())
                {
                txtstudentname.Text = (dr2["name"].ToString());
                //txtmemid.Text = (dr2["memberid"].ToString());
                txtcourse.Text = (dr2["course"].ToString());
                txtyear.Text = (dr2["year"].ToString());
                txtsemester.Text = (dr2["semester"].ToString());

               
            }

            dr2.Close();

            String query = "SELECT bookid,edition,publisher,author,genre FROM Newbook1 WHERE name='"+bookname+"';";
            SqlCommand cmd1 = new SqlCommand(query, con);
            SqlDataReader dr = cmd1.ExecuteReader();
            if (dr.Read())
            {
                txtbookid.Text = (dr["bookid"].ToString());
                txtedition.Text = (dr["edition"].ToString());
                txtpublisher.Text = (dr["publisher"].ToString());
                txtauthor.Text = (dr["author"].ToString());
                txtgenre.Text = (dr["genre"].ToString());
            }
            dr.Close();

            con.Close();
            
           }
            catch(Exception ex) { }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // try
            //{
                con.Open();
                String bookid1;
                String s = null;
                int amount;
                bookid1 = txtbookid.Text;
                 int bookid = Convert.ToInt32(bookid1);
                String query = "SELECT amount FROM Newbook1 WHERE bookid=" + bookid + ";";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {

                s = (dr["amount"].ToString());
                    

                }
            dr.Close();
            MessageBox.Show(s);
            amount = Convert.ToInt32(s);
            if(amount>0)
            {
              //  con.Open();
                int stuid, memid, bid;
                String stuid1, memid1, bookid2, issuedate, returndate;
                stuid1 = txtstudentid.Text;stuid = Convert.ToInt32(stuid1);
                memid1 = txtmemid.Text;memid = Convert.ToInt32(memid1);
                bookid2 = txtbookid.Text;bid = Convert.ToInt32(bookid2);
                issuedate = dateTimePicker1.Text;
                returndate = dateTimePicker2.Text;
                String query4 = "Insert INTO Issuebook(studentid,memberid,bookid,issuedate,returndate) Values(" + stuid + "," + memid + "," + bid + ",'" + issuedate + "','" + returndate + "');";

                SqlDataAdapter SDA5 = new SqlDataAdapter(query4, con);
                SDA5.SelectCommand.ExecuteNonQuery();
               // con.Close();
            }
            else
            {
                MessageBox.Show("Book is not available");
            }
            
            con.Close();
            //  }catch(Exception ex) { }

        }
    }
}
