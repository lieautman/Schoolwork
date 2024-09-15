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
    public partial class FormExtraOptiuni : Form
    {
        string clientPath = Directory.GetCurrentDirectory() + "/ClientiDB.dat";
        string abonamentPath = Directory.GetCurrentDirectory() + "/AbonamenteDB.dat";
        string extraOptiunePath = Directory.GetCurrentDirectory() + "/ExtraoptiuneDB.dat";
        string tipAbonamentPath = Directory.GetCurrentDirectory() + "/TipAbonamentDB.dat";
        string logFile = Directory.GetCurrentDirectory() + "/LogAngajati.dat";
        Angajat angajat_local;

        Control c;
        public FormExtraOptiuni(Angajat angajat)
        {
            InitializeComponent();

            angajat_local = (Angajat)angajat.Clone();

            //iau NrOrdineClient din fisier
            if (File.Exists(abonamentPath))
            {

                //citit din fisier si setat text
                using (StreamReader readtext = new StreamReader(abonamentPath))
                {
                    string linie;
                    linie = readtext.ReadLine();
                    int[] itemeBuffer = new int[Constants.NrMaxElemBd];
                    int i = 0;
                    while (linie != null)
                    {
                        itemeBuffer[i] = Int32.Parse(linie.Substring(0, 1));
                        linie = readtext.ReadLine();
                        i++;
                    }
                    int[] iteme = new int[i];
                    for (int j = 0; j < Constants.NrMaxElemBd; j++)
                        if (itemeBuffer[j] != 0)
                            iteme[j] = itemeBuffer[j];

                    cbNrOrdineAbonament.DataSource = iteme;
                }
            }
            else
            {
                cbNrOrdineAbonament.Text = "Nu avem clienti in baza de date!";
            }

            if (File.Exists(extraOptiunePath))
            {
                //citit din fisier si setat text
                using (StreamReader readtext = new StreamReader(extraOptiunePath))
                {
                    string linie;
                    linie = readtext.ReadLine();
                    while (linie != null)
                    {
                        tbNrOrdineExtraoptiune.Text = (Int32.Parse(linie.Substring(0, 1)) + 1).ToString();
                        linie = readtext.ReadLine();
                    }
                }
            }
            else
            {
                tbNrOrdineExtraoptiune.Text = 1.ToString();
            }

            //date data grid view
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
                        listClienti.Add(client);

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
                        abonament.AbonamentTip = Int32.Parse(linieSplit[2]);
                        listAbonament.Add(abonament);

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
                    dgvBdTipAbonament.DataSource = listAbonament;
                }
            }
            else
            {
                MessageBox.Show("Nu avem Bd tip abonamente!");
            }
        }

        private void cbTipExtraoptiune_SelectedIndexChanged(object sender, EventArgs e)
        {
            c = (ComboBox)sender;
            Object selectedItem = cbTipExtraoptiune.SelectedItem;
            labelExtraOptiune1.Text = "Numar " + selectedItem;
        }

        private void btnSalvareExtraOptiune_Click(object sender, EventArgs e)
        {
            if (tbNrOrdineExtraoptiune.Text == "" || cbNrOrdineAbonament.Text == "" || cbTipExtraoptiune.Text == "" || tbExtraOptiuneNumar.Text == "")
                epNecompletat.SetError(btnSalvareExtraOptiune, "Va rugam completati toate campurile!");
            else
            {
                try
                {
                    epNecompletat.Clear();
                    ExtraOptiune extraOptiune = new ExtraOptiune();
                    extraOptiune.NrOrdineExtraoptiune = Convert.ToInt32(tbNrOrdineExtraoptiune.Text);
                    extraOptiune.NrOrdineAbonament = Convert.ToInt32(cbNrOrdineAbonament.Text);
                    extraOptiune.Optiune = extraOptiune.stringtoenum(cbTipExtraoptiune.Text);
                    extraOptiune.Number = Convert.ToInt32(tbExtraOptiuneNumar.Text);

                    //de scris in fisier
                    using (StreamWriter writetext = new StreamWriter(extraOptiunePath, true))
                    {
                        writetext.WriteLine(extraOptiune.ToString());
                    }
                    //de scris in log
                    using (StreamWriter writetext = new StreamWriter(logFile, true))
                    {
                        writetext.WriteLine(angajat_local.ToString() + " 2 " + extraOptiune.NrOrdineExtraoptiune);//2 reprezinta modelul de formular ce a fost logat
                    }

                    MessageBox.Show("Clientul a fost salvat!");

                    //resetez nr de ordine #spagetti code
                    using (StreamReader readtext = new StreamReader(extraOptiunePath))
                    {
                        string linie;
                        linie = readtext.ReadLine();
                        while (linie != null)
                        {
                            tbNrOrdineExtraoptiune.Text = (Int32.Parse(linie.Substring(0, 1)) + 1).ToString();
                            linie = readtext.ReadLine();
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        

        }

        private void dgvBdAbonament_DoubleClick(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvBdAbonament.SelectedRows)
            {
                cbNrOrdineAbonament.Text = row.Cells[0].Value.ToString();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void backButton2_Load(object sender, EventArgs e)
        {
            ((Control)sender).Parent = this;
        }
    }
}
