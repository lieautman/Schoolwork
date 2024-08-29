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
    public partial class BdClienti : Form
    {
        string clientPath = Directory.GetCurrentDirectory() + "/ClientiDB.dat";
        public BdClienti()
        {
            InitializeComponent();


            if (File.Exists(clientPath))
            {
                List<Client> listClienti = new List<Client>();
                //citit din fisier si punem in lista
                using (StreamReader readtext = new StreamReader(clientPath))
                {
                    string linie;
                    linie = readtext.ReadLine();
                    while (linie != null)
                    {
                        Client client = new Client();
                        string[] linieSplit = linie.Split(' ');
                        client.NrOrdine = Int32.Parse(linieSplit[0]);
                        client.CNP = linieSplit[1];
                        client.nume = linieSplit[2];
                        client.prenume = linieSplit[3];
                        client.email = linieSplit[4];
                        client.nationalitate = linieSplit[5];
                        client.plata = linieSplit[6];
                        listClienti += client;

                        linie = readtext.ReadLine();

                    }

                    //afisam datele in tabel
                    dgvBdClienti.DataSource = listClienti;
                }
            }
            else
            {
                MessageBox.Show("Nu avem Bd clienti!");
            }
        }

    }
}
