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
    public partial class BdAbonament : Form
    {
        string abonamentPath = Directory.GetCurrentDirectory() + "/AbonamenteDB.dat";
        public BdAbonament()
        {
            InitializeComponent();



            if (File.Exists(abonamentPath))
            {
                List<Abonament> listAbonament = new List<Abonament>();
                //citit din fisier si punem in lista
                using (StreamReader readtext = new StreamReader(abonamentPath))
                {
                    string linie;
                    linie = readtext.ReadLine();
                    while (linie != null)
                    {
                        Abonament abonament = new Abonament();
                        string[] linieSplit = linie.Split(' ');
                        abonament.NrOrdineAbonament = Int32.Parse(linieSplit[0]);
                        abonament.NrOrdineClient = Int32.Parse(linieSplit[1]);
                        abonament.AbonamentTip = abonament.stringtoint(linieSplit[2]);
                        listAbonament+=abonament;

                        linie = readtext.ReadLine();

                    }

                    //afisam datele in tabel
                    dgvBdAbonament.DataSource = listAbonament;
                }
            }
            else
            {
                MessageBox.Show("Nu avem Bd abonamente!");
            }
        }
    }
}
