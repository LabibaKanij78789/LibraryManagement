using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagement
{
    public partial class CustomTextBox : TextBox
    {
        public CustomTextBox()
        {
            InitializeComponent();
            //InitializeComponent();
            SetStyle(ControlStyles.SupportsTransparentBackColor |
                     ControlStyles.OptimizedDoubleBuffer |
                     ControlStyles.AllPaintingInWmPaint |
                     ControlStyles.ResizeRedraw |
                     ControlStyles.UserPaint, true);
            this.BackColor = Color.Transparent;
           
            this.FontHeight = 16;
            //this.ForeColor = Color.LightSalmon;
            //this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);

        }

        public void CustomTextBox_Load(object sender, EventArgs e)
        {
            
                BackColor = Color.LightSalmon;
                BackColor = Color.Transparent;
            

        }
    }
}
