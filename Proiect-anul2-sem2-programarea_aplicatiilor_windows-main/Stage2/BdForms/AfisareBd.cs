using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbonatiTelefonici
{
    public partial class AfisareBd : Form
    {
        string clientPath = Directory.GetCurrentDirectory() + "/ClientiDB.dat";
        string abonamentPath = Directory.GetCurrentDirectory() + "/AbonamenteDB.dat";
        string extraOptiunePath = Directory.GetCurrentDirectory() + "/ExtraoptiuneDB.dat";
        string tipAbonamentPath = Directory.GetCurrentDirectory() + "/TipAbonamentDB.dat";
        public AfisareBd()
        {
            InitializeComponent();
        }

        private void btnDisplayBDClient_Click(object sender, EventArgs e)
        {
            if (File.Exists(clientPath))
            {
                BdClienti frm = new BdClienti();
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Nu avem Bd clienti!");
            }
        }

        private void btnDisplayBDAbonament_Click(object sender, EventArgs e)
        {
            if (File.Exists(abonamentPath))
            {
                BdAbonament frm = new BdAbonament();
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Nu avem Bd abonament!");
            }
        }

        private void btnDisplayBDExtraOptiune_Click(object sender, EventArgs e)
        {
            if (File.Exists(extraOptiunePath))
            {
                BdExtraOptiune frm = new BdExtraOptiune();
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Nu avem Bd extra optiune!");
            }
        }

        private void btnDisplayBDTipAbonament_Click(object sender, EventArgs e)
        {
            if (File.Exists(tipAbonamentPath))
            {
                BdTipAbonament frm = new BdTipAbonament();
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Nu avem Bd tip abonament!");
            }
        }
    }
}
