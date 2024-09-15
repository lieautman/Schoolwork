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
    public partial class FormTipAbonament : Form
    {
        string tipAbonamentPath = Directory.GetCurrentDirectory() + "/TipAbonamentDB.dat";
        public FormTipAbonament()
        {
            InitializeComponent();


            if (File.Exists(tipAbonamentPath))
            {
                //citit din fisier si setat text
                using (StreamReader readtext = new StreamReader(tipAbonamentPath))
                {
                    string linie;
                    linie = readtext.ReadLine();
                    while (linie != null)
                    {
                        tbNrTipAbonament.Text = (Int32.Parse(linie.Substring(0, 1)) + 1).ToString();
                        linie = readtext.ReadLine();
                    }
                }
            }
            else
            {
                tbNrTipAbonament.Text = 1.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbNrMesaje.Text == "" || tbNrMinute.Text == "" || tbNrGbInternet.Text == "" || tbPretLunar.Text == "")
                epNecompletat.SetError(btnSalvareTipAbonament, "Va rugam completati toate campurile!");
            else
            {
                try
                {
                    epNecompletat.Clear();
                    TipAbonament tipAbonament = new TipAbonament();
                    tipAbonament.NrOrdineTipAbonament = Convert.ToInt32(tbNrTipAbonament.Text);
                    tipAbonament.NrMesaje = Convert.ToInt32(tbNrMesaje.Text);
                    tipAbonament.NrMinute = Convert.ToInt32(tbNrMinute.Text);
                    tipAbonament.NrGbInternet = Convert.ToInt32(tbNrGbInternet.Text);
                    tipAbonament.Pret = (float)Convert.ToDouble(tbPretLunar.Text);


                    //de scris in fisier
                    using (StreamWriter writetext = new StreamWriter(tipAbonamentPath, true))
                    {
                        writetext.WriteLine(tipAbonament.ToString());
                    }

                    MessageBox.Show("Tipul de abonamnet a fost salvat!");

                    //resetez nr de ordine #spagetti code
                    using (StreamReader readtext = new StreamReader(tipAbonamentPath))
                    {
                        string linie;
                        linie = readtext.ReadLine();
                        while (linie != null)
                        {
                            tbNrTipAbonament.Text = (Int32.Parse(linie.Substring(0, 1)) + 1).ToString();
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
