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
    public partial class BdExtraOptiune : Form
    {
        string extraoptiunePath = Directory.GetCurrentDirectory() + "/ExtraoptiuneDB.dat";
        public BdExtraOptiune()
        {
            InitializeComponent();

            if (File.Exists(extraoptiunePath))
            {
                List<ExtraOptiune> listExtraOptiune = new List<ExtraOptiune>();
                //citit din fisier si punem in lista
                using (StreamReader readtext = new StreamReader(extraoptiunePath))
                {
                    string linie;
                    linie = readtext.ReadLine();
                    while (linie != null)
                    {
                        ExtraOptiune extraOptiune = new ExtraOptiune();
                        string[] linieSplit = linie.Split(' ');
                        extraOptiune.NrOrdineExtraoptiune = Int32.Parse(linieSplit[0]);
                        extraOptiune.NrOrdineAbonament = Int32.Parse(linieSplit[1]);
                        extraOptiune.Optiune = extraOptiune.stringtoenum(linieSplit[2]);
                        extraOptiune.Number = Int32.Parse(linieSplit[3]);
                        listExtraOptiune+=extraOptiune;

                        linie = readtext.ReadLine();

                    }

                    //afisam datele in tabel
                    dgvBdExtraOptiune.DataSource = listExtraOptiune;
                }
            }
            else
            {
                MessageBox.Show("Nu avem Bd extra optiune!");
            }
        }
    }
}
