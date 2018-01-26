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
    public partial class enterAsMem : Form
    {
        string nameBox;
        string passBox;
        DBConnect db = new DBConnect();
        public enterAsMem()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nameBox = textBox4.Text;
            passBox = textBox2.Text;
            //List<List<string>> result = new List<List<string>>();
            string query = "select * from user where name = '" + nameBox + "' and password = '" + passBox + "'";
            MessageBox.Show(query);
            string conq = " where name = '" + nameBox + "' and '" + passBox + "'";
            try
            {
                if (db.SelectAll("user", conq))
                {
                    MemberPage mp = new MemberPage(nameBox);
                    this.Hide();
                    mp.Show();
                }
                else
                {
                    MessageBox.Show("invalid input!");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
