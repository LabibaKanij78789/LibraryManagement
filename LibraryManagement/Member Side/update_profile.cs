using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LibraryManagement
{
    public partial class update_profile : Form
    
    {
        string name;
        private DBConnect db;
        private string server;
        private string database;
        private string uid;
        private string pass;
        private string tmpName;

        public update_profile(string uName)
        {
            InitializeComponent();
            //label1.BackColor = Color.Transparent;
            pictureBox1.BackColor = Color.Transparent;
            button1.BackColor = Color.Transparent;
            name = uName;
            tmpName = uName;
            server = "localhost";
            database = "the_athenaeum";
            uid = "root";
            pass = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                               database + ";" + "UID=" + uid + ";" + "PASSWORD=" + pass + ";";

            //connection = new MySqlConnection(connectionString);
            db = new DBConnect(); 
            
        }

        private void update_profile_Load(object sender, EventArgs e)
        {
            userName.Text += name;
            string q1 = "SELECT Contact,password, mem_Type from user as usr " +
                        "inner join membership as mem on mem.mem_ID = usr.M_id " +
                        "where usr.u_Name = '" + tmpName + "'";
            nameBox.Text = tmpName;

            try
            {
                if (linkLabel1.Text != "Save")
                {
                    db.OpenConnection();
                    MySqlCommand c1 = new MySqlCommand(q1, db.getConnection());
                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader1 = c1.ExecuteReader();

                    //Read the data and store them in the list
                    while (dataReader1.Read())
                    {
                        contactBox.Text = dataReader1["Contact"].ToString();
                        passBox.Text = dataReader1["password"].ToString();
                        memBox.Text = dataReader1["mem_Type"].ToString();
                    }

                    db.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            String name,contact_no,pass,member,query;
            name = nameBox.Text;
            contact_no = contactBox.Text;
            pass = passBox.Text;
            member = memBox.Text;
            String[] colStrings = {"u_Name","password","Contact" };
            String[] values = {name, pass, contact_no };

            query = " WHERE u_name = '" + tmpName + "'";

            try
            {
                if (linkLabel1.Text == "Save")
                {
                    db.OpenConnection();
                    db.Update("user", colStrings, values, query);
                    db.CloseConnection();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            if (linkLabel1.Text != "Save")
            {
                nameBox.Clear();
                contactBox.Clear();
                passBox.Clear();
                memBox.Clear();

                linkLabel1.Text = "Save";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Name_Click(object sender, EventArgs e)
        {

        }

        private void contactBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void memBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MemberPage(name).Show();
        }
    }
}
