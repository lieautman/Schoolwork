using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Library
{
    public partial class BackButton: UserControl
    {
        public Form frm;
        public BackButton()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm.Close();
        }
        Color clr = Color.FromArgb(252, 97, 101);
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = clr;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = SystemColors.ControlLight;
        }

        private void BackButton_Load(object sender, EventArgs e)
        {
            frm = (Form)(((Control)sender).Parent);
        }
    }
}
