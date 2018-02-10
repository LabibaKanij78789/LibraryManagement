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
using static LibraryManagement.DBConnect;
namespace LibraryManagement
{
    public partial class NewStudent : Form
    {
        string name, memtype, contact;
        List<List<string>> result = new List<List<string>>();
        public NewStudent()
        {
            InitializeComponent();
        }
        DBConnect db = new DBConnect();
        //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-J2E5UDC\SQLEXPRESS;Initial Catalog=lms;Integrated Security=True");
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
                              
                name = txtname.Text;
                //memtype = combomembertype.Text;
                contact = txtmemberid.Text;
                db.Insert("user", new []{"u_name", "password", "contact", "m_id", "booklog", "reqpending"}, new []{name,"null", contact, memtype, "0", "0"});
                MessageBox.Show("User named " + name + "is added!");
                new mainpage().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void combocourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void combosemester_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerv_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtmemberid_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewStudent_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "select mem_type from membership";
                result = db.selectSearch(query, new[] { "mem_type"});
                string[] memData = new string[result.Count];
                //DataTable tableBuy = new DataTable();
                for (int i = 0; i < result.Count; i++)
                {
                    memData[i] = result[i][0];
                    //bookame[i] = result[i][0];

                }
                combomembertype.DataSource = memData;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            
        }

        private void combomembertype_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select mem_id from membership where mem_type = '" + combomembertype.SelectedItem.ToString() + "'";
            result.Clear();
            result = db.selectSearch(query, new[] { "mem_id" });
            memtype = result[0][0];
            //MessageBox.Show(memtype);
        }

        private void comboyear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
