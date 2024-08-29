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
//for file-binary formatter
using System.Runtime.Serialization.Formatters.Binary;

namespace AbonatiTelefonici
{
    public partial class FormClient : Form
    {
        string clientPath = Directory.GetCurrentDirectory() + "/ClientiDB.dat";
        string logFile = Directory.GetCurrentDirectory() + "/LogAngajati.dat";
        Angajat angajat_local;
        public FormClient(Angajat angajat)
        {
            InitializeComponent();

            angajat_local = (Angajat)angajat.Clone();

            if (File.Exists(clientPath))
            {
                //citit din fisier si setat text
                using (StreamReader readtext = new StreamReader(clientPath))
                {
                    string linie;
                    linie = readtext.ReadLine();
                    while (linie != null)
                    {
                        tbNrOrdine.Text = (Int32.Parse(linie.Substring(0, 1))+1).ToString();
                        linie = readtext.ReadLine();
                    }
                }
            }
            else
            {
                tbNrOrdine.Text = 1.ToString();
            }
        }

        private void btnSalvareClient_Click(object sender, EventArgs e)
        {
            if (tbCNP.Text == "" || tbNume.Text == "" || tbPrenume.Text == "" || cbNationalitate.Text == "")
                epNecompletat.SetError(btnSalvareClient, "Va rugam completati toate campurile!");
            else if (tbCNP.Text.Length != 13)
                epNecompletat.SetError(tbCNP, "Va rugam introduceti in CNP de 13 caractere (valid)!");
            else
            {
                try
                {
                    epNecompletat.Clear();
                    Client client = new Client();
                    client.NrOrdine = Convert.ToInt32(tbNrOrdine.Text);
                    client.CNP = tbCNP.Text;
                    client.nume = tbNume.Text;
                    client.prenume = tbPrenume.Text;
                    client.email = tbEmail.Text;
                    client.nationalitate = cbNationalitate.Text;
                    client.plata = cbPlata.Text;


                    //de scris in fisier
                    using (StreamWriter writetext = new StreamWriter(clientPath, true))
                    {
                        writetext.WriteLine(client.ToString());
                    }
                    //de scris in log
                    using (StreamWriter writetext = new StreamWriter(logFile, true))
                    {
                        writetext.WriteLine(angajat_local.ToString() + " 0 " + client.NrOrdine);//0 reprezinta modelul de formular ce a fost logat
                    }

                    MessageBox.Show("Clientul a fost salvat!");

                    //resetez nr de ordine #spagetti code
                    using (StreamReader readtext = new StreamReader(clientPath))
                    {
                        string linie;
                        linie = readtext.ReadLine();
                        while (linie != null)
                        {
                            tbNrOrdine.Text = (Int32.Parse(linie.Substring(0, 1)) + 1).ToString();
                            linie = readtext.ReadLine();
                        }
                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void backButton2_Load(object sender, EventArgs e)
        {
            ((Control)sender).Parent = this;
        }
    }
}
