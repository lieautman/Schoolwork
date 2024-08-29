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
        string abonamentPath = Directory.GetCurrentDirectory() + "/AbonamenteDB.dat";
        string extraOptiunePath = Directory.GetCurrentDirectory() + "/ExtraoptiuneDB.dat";

        Control c;
        public FormExtraOptiuni()
        {
            InitializeComponent();

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
                using (StreamReader readtext = new StreamReader(abonamentPath))
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
        }

        private void cbTipExtraoptiune_SelectedIndexChanged(object sender, EventArgs e)
        {
            c = (ComboBox)sender;
            Object selectedItem = cbTipExtraoptiune.SelectedItem;
            labelExtraOptiune1.Text = "Numar " + selectedItem;
        }

        private void btnSalvareClient_Click(object sender, EventArgs e)
        {
            if (tbNrOrdineExtraoptiune.Text == "" || cbNrOrdineAbonament.Text == "" || cbTipExtraoptiune.Text == "" || tbExtraOptiuneNumar.Text == "")
                epNecompletat.SetError(btnSalvareClient, "Va rugam completati toate campurile!");
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
    }
}
