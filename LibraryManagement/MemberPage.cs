using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LibraryManagement.DBConnect;
namespace LibraryManagement
{
    public partial class MemberPage : Form
    {
        int i = 0;
        LinkLabel a = new LinkLabel();
        LinkLabel b = new LinkLabel();
        DBConnect instance = new DBConnect();

        public string name;
        public MemberPage(string uName)
        {
            InitializeComponent();
           title.BackColor = Color.Transparent;
            name = uName;
            userName.Text = userName.Text + uName;
            pictureBox1.BackColor = Color.Transparent;
            pbj.BackColor = Color.Transparent;
            pgs.BackColor = Color.Transparent;
            groupBox1.BackColor = Color.Transparent;
            groupBox2.BackColor = Color.Transparent;
            pbl.BackColor = Color.Transparent;
            //profile.Size = new Size(profile.Width, profile.Height);
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
                a.Size = new Size(87, 30);
                a.Text = "Delete User";
                this.Controls.Add(a);
                a.Show();

                b.Location = new Point(1150, 110);
                b.Size = new Size(87, 30);
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
        
        
        void b_clicked(object sender, LinkLabelLinkClickedEventArgs c)
        {
            LinkLabel b = sender as LinkLabel;

            if (b != null)
            {
                Form1 ob = new Form1();
                this.Hide();
                ob.Show();
            }
        }
        void a_clicked(object sender, LinkLabelLinkClickedEventArgs c)
        {
            LinkLabel a = sender as LinkLabel;
            
            if (a != null)
            {
                instance.Delete("user","Name", name );
                Form1 ob = new Form1();
                this.Hide();
                ob.Show();
            }
        }

        private void BJ_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            book_journal ob = new book_journal();
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

        }

        private void pbj_Click(object sender, EventArgs e)
        {
           book_journal ob = new book_journal();
           this.Hide();
            ob.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
