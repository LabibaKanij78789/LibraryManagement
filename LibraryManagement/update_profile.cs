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
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string pass;
        public update_profile(string uName)
        {
            InitializeComponent();
            //label1.BackColor = Color.Transparent;
            pictureBox1.BackColor = Color.Transparent;
            button1.BackColor = Color.Transparent;
            name = uName;
            server = "localhost";
            database = "the_athenaeum";
            uid = "root";
            pass = " ";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                               database + ";" + "UID=" + uid + ";" + "PASSWORD=" + pass + ";";

            connection = new MySqlConnection(connectionString);
            
            
        }

        private void update_profile_Load(object sender, EventArgs e)
        {
            string q1 = "select contact from user where name = \"" + name + "\"";
            string q2 = "select password from user where name = \"" + name + "\"";
            string q3 = "select membership.type from user inner join user on " +
                        "user.id = membership.u_id where user.name = \"" + name + "\"";
            nameBox.Text = name;
            try
            {
                connection.Open();
                MySqlCommand c1 = new MySqlCommand(q1, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader1 = c1.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader1.Read())
                {
                    contactBox.Text = dataReader1["contact"].ToString();
                }


                MySqlCommand c2 = new MySqlCommand(q2, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader2 = c2.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader2.Read())
                {
                    passBox.Text = dataReader2["password"].ToString();
                }


                MySqlCommand c3 = new MySqlCommand(q3, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader3 = c3.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader3.Read())
                {
                    memBox.Text = dataReader3["membership.type"].ToString();
                }
            }
            catch (Exception ex)
            {
                
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
            nameBox.Clear();
            contactBox.Clear();
            passBox.Clear();
            memBox.Clear();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
