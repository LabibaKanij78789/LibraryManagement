using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Documents;
using System.Windows.Forms;
using static LibraryManagement.DBConnect;
namespace LibraryManagement
{
    public partial class MemberPage : Form
    {
        int i = 0, n;
        LinkLabel a = new LinkLabel();
        LinkLabel b = new LinkLabel();
        string selectedBook;
        string bl, userId;
        DBConnect instance = new DBConnect();
        List<List<string>> result = new List<List<string>>();
        public string name;
        public MemberPage(string uName)
        {
            InitializeComponent();
            title.BackColor = Color.Transparent;
            name = uName;
            userName.Text = userName.Text + uName;
            pictureBox1.BackColor = Color.Transparent;
            pbj.BackColor = Color.Transparent;
            groupBox1.BackColor = Color.Transparent;
            groupBox2.BackColor = Color.Transparent;
            pbl.BackColor = Color.Transparent;
            groupBox1.Show();
            groupBox2.Show();
            label2.BringToFront();
        }

        public void nameUser()
        {

        }

        private void logoff_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void profile_Click(object sender, EventArgs e)
        {
            //this.profile.Image = Image.FromFile("user.png");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            i++;
            if (i % 2 == 1)
            {

                a.Location = new Point(1150, 70);
                a.BackColor = Color.BlanchedAlmond;
                a.Font = new Font("Arial", 12);
                //a.Size = new Size(87, 30);
                a.Text = "Delete User";
                this.Controls.Add(a);
                a.Show();

                b.Location = new Point(1150, 110);
                b.BackColor = Color.BlanchedAlmond;
                b.Font = new Font("Arial", 12);
                //b.Size = new Size(87, 30);
                b.Text = "Log out";
                this.Controls.Add(b);
                b.Show();

            }
            else
            {
                a.Hide();
                b.Hide();



            }



        }


        private void b_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //LinkLabel b = sender as LinkLabel;

            if (b != null)
            {
                Form1 ob = new Form1();
                this.Hide();
                ob.Show();
            }
        }
        private void a_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //LinkLabel a = sender as LinkLabel;

            if (a != null)
            {
                instance.Delete("user", "u_Name", name);
                Form1 ob = new Form1();
                this.Hide();
                ob.Show();
            }
        }



        private void BJ_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //MessageBox.Show(userId);
            book_journal ob = new book_journal( name, userId);
            this.Hide();
            ob.Show();
        }

        private void GS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void MemberPage_Load(object sender, EventArgs e)
        {
            string q = "select u_id from user where u_Name = '" + name + "'";
            string[] columns1 = new[] { "u_id" };
            try
            {
                result = instance.selectSearch(q, columns1);
                userId = result[0][0];
                //string query = "Select reqpending from user where u_id = '" + userId + "';";
                //result.Clear();
                //result = instance.selectSearch(query, new[] { "reqpending" });
                //int.TryParse(result[0][0], out n);
                //if (n <= 0)
                //{
                //    pictureBox4.Enabled = false;
                //    Noti.Enabled = false;
                //}

                string query = "new = '1' or new = '2' and u_id = '" + userId + "'";
                n = instance.Count("grants", query);
                if (n <= 0)
                {
                    pictureBox4.Enabled = false;
                    Noti.Enabled = false;
                }
                else
                {
                    pictureBox4.Enabled = true;
                    Noti.Enabled = true;
                }

                label2.Text = n.ToString();
                //label1.Text = n.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
                //throw;
            }
        }

        private void pbj_Click(object sender, EventArgs e)
        {
            book_journal ob = new book_journal(name, userId);
            this.Hide();
            ob.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void pbl_Click(object sender, EventArgs e)
        {
            try
            {
                string q = "select bookLog from user where u_id = '"+userId+"'";
                string[] col = new[] { "bookLog" };

                result = instance.selectSearch(q, col);
                bl = result[0][0];


                Boolean bookLog = Convert.ToBoolean(bl);
                bookLog blg = new bookLog(name, userId, bookLog);
                this.Hide();
                blg.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void BL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            book_possession bp = new book_possession(name, userId);
            this.Hide();
            bp.Show();
        }

        private void BP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            update_profile up = new update_profile(name);
            this.Hide();
            up.Show();
        }

        private void UP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new noti_bb(null, n, name, "noti", userId).Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string search = searchText.Text.ToString();
            try
            {
                
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
                //throw;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }

        private void bookL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string q = "select bookLog from user where u_id = " +
                           userId;
                string[] col = new[] { "bookLog" };

                result = instance.selectSearch(q, col);
                bl = result[0][0];

                Boolean bookLog = Convert.ToBoolean(bl);
                bookLog blg = new bookLog(name,userId, bookLog);
                this.Hide();
                blg.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Noti_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new noti_bb(null, n, name, "noti", userId).Show();
        }

        private void gsPic_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Member_Side.get_suggestion(name, userId).Show();
        }

        private void gs_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Member_Side.get_suggestion(name, userId).Show();
        }

        private void bookP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                book_possession bp = new book_possession(name, userId);
                this.Hide();
                bp.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
                throw;
            }
        }

        private void upP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                update_profile up = new update_profile(name);
                this.Hide();
                up.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
                throw;
            }
        }
    }
}
