using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbonatiTelefonici
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            FormClient frm = new FormClient();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnAbonament_Click(object sender, EventArgs e)
        {
            FormAbonament frm = new FormAbonament();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnExtraOptiuni_Click(object sender, EventArgs e)
        {
            FormExtraOptiuni frm = new FormExtraOptiuni();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnTipAbonament_Click(object sender, EventArgs e)
        {
            FormTipAbonament frm = new FormTipAbonament();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BdClienti frm = new BdClienti();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void abonamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BdAbonament frm = new BdAbonament();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void extraOptiuniToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BdExtraOptiune frm = new BdExtraOptiune();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void tipAbonamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BdTipAbonament frm = new BdTipAbonament();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
