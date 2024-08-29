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
    public partial class BdTipAbonamentInForm : Form
    {
        string tipAbonamentPath = Directory.GetCurrentDirectory() + "/TipAbonamentDB.dat";
        public BdTipAbonamentInForm()
        {
            InitializeComponent();

            if (File.Exists(tipAbonamentPath))
            {
                List<TipAbonament> listAbonament = new List<TipAbonament>();
                //citit din fisier si punem in lista
                using (StreamReader readtext = new StreamReader(tipAbonamentPath))
                {
                    string linie;
                    linie = readtext.ReadLine();
                    while (linie != null)
                    {
                        TipAbonament tipAbonament = new TipAbonament();
                        string[] linieSplit = linie.Split(' ');
                        tipAbonament.NrOrdineTipAbonament = Int32.Parse(linieSplit[0]);
                        tipAbonament.NrMinute = Int32.Parse(linieSplit[1]);
                        tipAbonament.NrMesaje = Int32.Parse(linieSplit[2]);
                        tipAbonament.NrGbInternet = Int32.Parse(linieSplit[3]);
                        tipAbonament.Pret = float.Parse(linieSplit[4]);
                        listAbonament.Add(tipAbonament);

                        linie = readtext.ReadLine();

                    }

                    //afisam datele in tabel
                    dgvBdAbonament.DataSource = listAbonament;
                }
            }
            else
            {
                MessageBox.Show("Nu avem Bd tip abonamente!");
            }
        }

        public void dgvBdAbonament_DoubleClick(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvBdAbonament.SelectedRows)
            {
                this.AcceptButton = btnOK;
                tbIdTipAbonament.Text = row.Cells[0].Value.ToString();
                tbNrMesaje.Text = row.Cells[1].Value.ToString();
                tbNrMinute.Text = row.Cells[2].Value.ToString();
                tbNrGbInternet.Text = row.Cells[3].Value.ToString();
                tbPretLunar.Text = row.Cells[4].Value.ToString();
                this.Close();
            }
        }
    }
}
