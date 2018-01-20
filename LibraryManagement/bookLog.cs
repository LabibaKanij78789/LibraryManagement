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

namespace LibraryManagement
{
    public partial class bookLog : Form
    {
        private string blName;
        
        public bookLog()
        {
            InitializeComponent();
            this.dataGridView1.Hide();
        }

        private void bookLog_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            blName = label1.Text.ToString();
            button1.Hide();
            panel1.Hide();
            label1.Hide();
            this.dataGridView1.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {

        }
    }
}
