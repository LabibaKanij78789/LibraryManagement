using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class Progressbar : Form
    {
        public Progressbar()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Progressbar_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            String s = Convert.ToString(progressBar1.Value);
            label4.Text = s+"%";
            if(progressBar1.Value>=100)
            {
                timer1.Stop();
                mainpage ob = new mainpage();
                this.Hide();
                ob.Show();
            }
        }
    }
}
