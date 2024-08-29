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
        public FormAbonament()
        {
            InitializeComponent();


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

        }


        private void btnDisplayCategorii_Click(object sender, EventArgs e)
        {
            BdTipAbonamentInForm frm = new BdTipAbonamentInForm();
            this.Hide();
            frm.ShowDialog();
            cbTipAbonament.Text = frm.tbIdTipAbonament.Text;
            this.Show();
        }

        private void btnSalvareClient_Click(object sender, EventArgs e)
        {
            if (cbNrOrdineClient.Text == "" || cbTipAbonament.Text == "")
                epNecompletat.SetError(btnSalvareClient, "Va rugam completati toate campurile!");
            else
            {
                try
                {
                    Abonament tipAbonament = new Abonament();
                    tipAbonament.NrOrdineAbonament = Convert.ToInt32(tbNrOrdineAbonament.Text);
                    tipAbonament.NrOrdineClient = Convert.ToInt32(cbNrOrdineClient.Text);
                    tipAbonament.Abonamenttip = tipAbonament.stringtoenum(cbTipAbonament.Text);




                    //de scris in fisier
                    using (StreamWriter writetext = new StreamWriter(abonamentPath, true))
                    {
                        writetext.WriteLine(tipAbonament.ToString());
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
    }
}
