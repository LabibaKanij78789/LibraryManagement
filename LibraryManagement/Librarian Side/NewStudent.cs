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
    public partial class NewStudent : Form
    {
        public NewStudent()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J2E5UDC\SQLEXPRESS;Initial Catalog=lms;Integrated Security=True");
        private void button2_Click(object sender, EventArgs e)
        {
            mainpage ob = new mainpage();
            this.Hide();
            ob.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           try
            {
                con.Open();
                String studentid1, name, course, year, semester, memid1, memtype, validity;
                int studentid, memid;
                studentid1 = txtstudentid.Text;
                studentid = Convert.ToInt32(studentid1);
                name = txtname.Text;
                course = combocourse.Text;
                year = comboyear.Text;
                semester = combosemester.Text;
                memid1 = txtmemberid.Text;
                memid = Convert.ToInt32(memid1);
                memtype = combomembertype.Text;
                validity = dateTimePickerv.Text;

                String query = "INSERT INTO NewStudent1(studentid,name,course,year,semester,memberid,membertype,validitytime)Values(" + studentid + ",'" + name + "','" + course + "','" + year + "','" + semester + "'," + memid + ",'" + memtype + "','" + validity + "');";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("New Student record is created");


            }
            catch (Exception ex) { }
        }
    }
}
