using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LibraryManagement.DBConnect;

namespace LibraryManagement
{

    public partial class Search_book : Form
    {
        string search;
        DBConnect db = new DBConnect();
        string[] col = new []{"name"};
        string conQ;
        private List<string>[] result = new List<string>[10];
        Label[] label = new Label[100];
        //Label[] labels ;
        //labels[0] = new Label();
        private int locX = 235, locY = 122;
        private int sizeX = 200, sizeY = 27;

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public Search_book()
        {
            InitializeComponent();
            //for (int i = 0; i < 100; i++)
            //{
            //    result[i].Add("infinity10000");
            //}
            pb.ImageLocation =
                @"D:\\Studies\\3.2\\SD\\LibraryManagement4\\LibraryManagement\\LibraryManagement\\bin\\Image\\arish.png";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            search = searchBox.Text.ToString();
            conQ = " where name = \"" + search + "\"";
            result = db.Select("books", col, true, conQ);
            int i = 1;
            try
            {
                while (!result.Equals(null))
                {
                    //label[i] = new Label();
                    //label[i].Text = result.ToString();
                    label[i].Location = new Point(locX, locY);
                    label[i].Size = new Size(sizeX, sizeY);

                    locY += (sizeY + 15);
                    if (i == 10)
                    {
                        break;
                    }
                    i++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
