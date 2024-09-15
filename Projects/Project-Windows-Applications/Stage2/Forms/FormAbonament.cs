using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace AbonatiTelefonici
{

    public partial class FormAbonament : Form
    {
        string clientPath = Directory.GetCurrentDirectory() + "/ClientiDB.dat";
        string abonamentPath = Directory.GetCurrentDirectory() + "/AbonamenteDB.dat";
        string tipAbonamentPath = Directory.GetCurrentDirectory() + "/TipAbonamentDB.dat";
        string logFile = Directory.GetCurrentDirectory() + "/LogAngajati.dat";
        Angajat angajat_local;
        public FormAbonament(Angajat angajat)
        {
            InitializeComponent();

            angajat_local = (Angajat)angajat.Clone();

            if (File.Exists(clientPath))
            {

                //citit din fisier si setat text
                //pt id client adus in combo box
                using (StreamReader readtext = new StreamReader(clientPath))
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

                    cbNrOrdineClient.DataSource = iteme;
                }
            }
            else
            {
                cbNrOrdineClient.Text = "Nu avem clienti in baza de date!";
            }

            if (File.Exists(abonamentPath))
            {
                //citit din fisier si setat text
                //pt id abonament incrementat automat
                using (StreamReader readtext = new StreamReader(abonamentPath))
                {
                    string linie;
                    linie = readtext.ReadLine();
                    while (linie != null)
                    {
                        tbNrOrdineAbonament.Text = (Int32.Parse(linie.Substring(0, 1)) + 1).ToString();
                        linie = readtext.ReadLine();
                    }
                }
            }
            else
            {
                tbNrOrdineAbonament.Text = 1.ToString();
            }

            if (File.Exists(tipAbonamentPath))
            {

                //citit din fisier si setat text
                //pt tip abonament adus in combo box
                using (StreamReader readtext = new StreamReader(tipAbonamentPath))
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

                    cbTipAbonament.DataSource = iteme;
                }
            }
            else
            {
                cbTipAbonament.Text = "Nu avem tip abonament in baza de date!";
            }

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

        private void btnSalvareClient_Click(object sender, EventArgs e)
        {
            if (cbNrOrdineClient.Text == "" || cbTipAbonament.Text == "")
                epNecompletat.SetError(btnSalvareClient, "Va rugam completati toate campurile!");
            else
            {
                try
                {
                    Abonament abonament = new Abonament();
                    abonament.NrOrdineAbonament = Convert.ToInt32(tbNrOrdineAbonament.Text);
                    abonament.NrOrdineClient = Convert.ToInt32(cbNrOrdineClient.Text);
                    abonament.AbonamentTip = abonament.stringtoint(cbTipAbonament.Text);




                    //de scris in fisier
                    using (StreamWriter writetext = new StreamWriter(abonamentPath, true))
                    {
                        writetext.WriteLine(abonament.ToString());
                    }
                    //de scris in log
                    using (StreamWriter writetext = new StreamWriter(logFile, true))
                    {
                        writetext.WriteLine(angajat_local.ToString() + " 2 " + abonament.NrOrdineAbonament);//1 reprezinta modelul de formular ce a fost logat
                    }

                    MessageBox.Show("Abonamentul clientului cu id-ul " + cbNrOrdineClient.Text + " a fost salvat!");

                    using (StreamReader readtext = new StreamReader(abonamentPath))
                    {
                        string linie;
                        linie = readtext.ReadLine();
                        while (linie != null)
                        {
                            tbNrOrdineAbonament.Text = (Int32.Parse(linie.Substring(0, 1)) + 1).ToString();
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
            foreach (DataGridViewRow row in dgvBdTipAbonament.SelectedRows)
            {
                cbTipAbonament.Text = row.Cells[0].Value.ToString();
            }
        }
        private void dgvBdClienti_DoubleClick(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvBdClienti.SelectedRows)
            {
                cbNrOrdineClient.Text = row.Cells[0].Value.ToString();
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
