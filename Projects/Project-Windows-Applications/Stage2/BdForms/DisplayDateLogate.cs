using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbonatiTelefonici
{
    public partial class DisplayDateLogate : Form
    {
        string logFile = Directory.GetCurrentDirectory() + "/LogAngajati.dat";
        string abonamentPath = Directory.GetCurrentDirectory() + "/AbonamenteDB.dat";
        string tipAbonamentPath = Directory.GetCurrentDirectory() + "/TipAbonamentDB.dat";
        Angajat angajat_local;
        //in aceasta lista voi citi datele
        List<TipFormularLog> listTipFormularLog = new List<TipFormularLog>();
        public DisplayDateLogate(Angajat angajat1)
        {
            InitializeComponent();

            angajat_local = (Angajat)angajat1.Clone();

            if (File.Exists(logFile))
            {

                //citit din fisier si punem in lista
                using (StreamReader readtext = new StreamReader(logFile))
                {
                    string linie;
                    linie = readtext.ReadLine();
                    int tipFormular=0;
                    int idTranzactie=0;
                    while (linie != null)
                    {
                        string[] linieSplit = linie.Split(' ');

                        Angajat angajat = new Angajat();
                        angajat.username = linieSplit[0];
                        angajat.stringToEnum(linieSplit[1]);
                        angajat.nume = linieSplit[2];
                        angajat.prenume = linieSplit[3];
                        angajat.email = linieSplit[4];

                        if ((angajat1.username == angajat.username) && (angajat1.tipUser == angajat.tipUser) && (angajat1.nume == angajat.nume) && (angajat1.prenume == angajat.prenume) && (angajat1.email == angajat.email))
                        {
                            TipFormularLog tipFormularLog = new TipFormularLog();

                            tipFormular = Convert.ToInt32(linieSplit[5]);
                            idTranzactie = Convert.ToInt32(linieSplit[6]);

                            tipFormularLog.tipFormular = tipFormular;
                            tipFormularLog.idTranzactie = idTranzactie;

                            listTipFormularLog.Add(tipFormularLog);
                        }

                        linie = readtext.ReadLine();

                    }

                    //afisam datele in tabel
                     dataGridView1.DataSource = listTipFormularLog;
                }
            }
            else
            {
                MessageBox.Show("Nu avem log Files!");
            }
        }



        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.KeyState & (byte)DragDropEffects.Copy) /*sau 8*/ == (byte)DragDropEffects.Copy /*sau 8*///vede daca bitul de la poz 4 este deschis (in documentatie se gaseste ce key reprezinta fiecare bit)
                 && (e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
            {
                e.Effect = DragDropEffects.Copy;
            }
            else e.Effect = DragDropEffects.Move;
        }

        //prin aceasta lista voi desena
        List<TipFormularLog> listTipFormularLog1 = new List<TipFormularLog>();
        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            //formatam ce primim
            string sir = e.Data.GetData(DataFormats.Text).ToString();
            string[] linieSplit = sir.Split('\n');
            foreach(string linie in linieSplit)
            {
                TipFormularLog tipFormularLog = new TipFormularLog();
                string[] numberSplit = linie.Split(' ');
                tipFormularLog.tipFormular = Convert.ToInt32(numberSplit[0]);
                tipFormularLog.idTranzactie = Convert.ToInt32(numberSplit[1]);

                listTipFormularLog1.Add(tipFormularLog);
            }
            panel1.Invalidate();
        }

        //prin aceasta lista voi printa
        List<TipFormularLog> listTipFormularLogForPrint = new List<TipFormularLog>();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //desenam ce primim in functia DragDrop
            Pen p1 = new Pen(Color.Red, 3); Brush b1 = new SolidBrush(Color.Aquamarine);
            Graphics g = e.Graphics;
            int vl = e.ClipRectangle.X + 10, vr = e.ClipRectangle.Width - 20;
            int vt = e.ClipRectangle.Y + 10, vb = e.ClipRectangle.Height - 20;
            g.DrawRectangle(p1, vl, vt, vr - vl, vb - vt);

            Brush[] vectBrush = new SolidBrush[]
            {
                new SolidBrush(Color.Red),
                new SolidBrush(Color.Green),
                new SolidBrush(Color.Yellow),
                new SolidBrush(Color.Blue)
            };


            int nrFormulare = 0;
            int nrClienti = 0;
            float profit = -1;
            int nrExtraoptiuni = 0;
            int nrTipAbonamente = 0;
            foreach (TipFormularLog tipFormularLog in listTipFormularLog1)
            {
                listTipFormularLogForPrint.Add(tipFormularLog);
                nrFormulare++;
                switch (tipFormularLog.tipFormular)
                {
                    case 0:
                        nrClienti++;
                        break;
                    case 1:
                        //fac un fel de join
                        int idTipAbonament = -1;
                        if (File.Exists(abonamentPath))
                        {
                            //citit din fisier
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

                                    if (abonament.NrOrdineAbonament == tipFormularLog.idTranzactie)
                                        idTipAbonament = abonament.AbonamentTip;

                                    linie = readtext.ReadLine();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nu avem Bd abonamente!");
                        }

                        if (idTipAbonament != -1)
                        {
                            if (File.Exists(tipAbonamentPath))
                            {
                                //citit din fisier
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

                                        if (idTipAbonament == tipAbonament.NrOrdineTipAbonament)
                                            profit += tipAbonament.Pret;


                                        linie = readtext.ReadLine();

                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Nu avem Bd tip abonamente!");
                            }
                        }

                        break;
                    case 2:
                        nrExtraoptiuni++;
                        break;
                    case 3:
                        nrTipAbonamente++;
                        break;
                    default:
                        MessageBox.Show("Date gresite!");
                        break;
                }
            }
            //afisez graficele
            if (nrFormulare != 0)
            {
                int nrTipuriFormulare = 0;
                if (nrClienti != 0)
                    nrTipuriFormulare++;
                if (profit != -1)
                    nrTipuriFormulare++;
                if (nrExtraoptiuni != 0)
                    nrTipuriFormulare++;
                if (nrTipAbonamente != 0)
                    nrTipuriFormulare++;
                int latimeBaraGrafic = (vr - vl) / nrTipuriFormulare;

                int scala = 1000;//pot modif scala pt a incapea in grafic

                while (scala * nrClienti + 50 > vb || scala * (profit+1) + 50 > vb ||
                      scala * nrExtraoptiuni + 50 > vb || scala * nrTipAbonamente + 50 > vb)
                    scala--;

                if (nrClienti != 0)
                {   
                    g.FillRectangle(vectBrush[0], vl, vb - nrClienti* scala, latimeBaraGrafic, nrClienti* scala);
                    g.DrawString("Nr clienti:" + nrClienti, Font, new SolidBrush(Color.Black), vl, vb - nrClienti * scala - Font.Height);
                }
                if (profit != -1)
                {
                    int muta = 0;
                    if (nrClienti != 0)
                        muta += latimeBaraGrafic;
                    g.FillRectangle(vectBrush[1], vl+ muta, vb - (profit+1) * scala, latimeBaraGrafic, (profit+1) * scala);
                    g.DrawString("Profitul lunar este:" + (profit + 1), Font, new SolidBrush(Color.Black), vl + muta, vb - (profit + 1) * scala - Font.Height);
                }
                if (nrExtraoptiuni != 0)
                {
                    int muta = 0;
                    if (nrClienti != 0)
                        muta += latimeBaraGrafic;
                    if (profit != -1)
                        muta += latimeBaraGrafic;
                    g.FillRectangle(vectBrush[2], vl+ muta, vb - nrExtraoptiuni * scala, latimeBaraGrafic, nrExtraoptiuni * scala);
                    g.DrawString("Nr extraoptiuni:" + nrExtraoptiuni, Font, new SolidBrush(Color.Black), vl + muta, vb - nrExtraoptiuni * scala - Font.Height);
                }
                if (nrTipAbonamente != 0)
                {
                    int muta = 0;
                    if (nrClienti != 0)
                        muta += latimeBaraGrafic;
                    if (profit != -1)
                        muta += latimeBaraGrafic;
                    if (nrExtraoptiuni != 0)
                        muta += latimeBaraGrafic;
                    g.FillRectangle(vectBrush[3], vl+ muta, vb - nrTipAbonamente * scala, latimeBaraGrafic, nrTipAbonamente * scala);
                    g.DrawString("Nr extraoptiuni:" + nrTipAbonamente, Font, new SolidBrush(Color.Black), vl + muta, vb - nrTipAbonamente * scala - Font.Height);
                }

            }

            //curat lista
            listTipFormularLog1.Clear();
        }

        void pdPrint(object sender, PrintPageEventArgs e)
        {
            //desenam ce primim in functia DragDrop
            Pen p1 = new Pen(Color.Red, 3); Brush b1 = new SolidBrush(Color.Aquamarine);
            Graphics g = e.Graphics;
            int vl = e.PageBounds.X + 10, vr = e.PageBounds.Width - 20;
            int vt = e.PageBounds.Y + 10, vb = e.PageBounds.Height - 20;
            g.DrawRectangle(p1, vl, vt, vr - vl, vb - vt);

            Brush[] vectBrush = new SolidBrush[]
            {
                new SolidBrush(Color.Red),
                new SolidBrush(Color.Green),
                new SolidBrush(Color.Yellow),
                new SolidBrush(Color.Blue)
            };


            int nrFormulare = 0;
            int nrClienti = 0;
            float profit = -1;
            int nrExtraoptiuni = 0;
            int nrTipAbonamente = 0;
            foreach (TipFormularLog tipFormularLog in listTipFormularLogForPrint)
            {
                nrFormulare++;
                switch (tipFormularLog.tipFormular)
                {
                    case 0:
                        nrClienti++;
                        break;
                    case 1:
                        //fac un fel de join
                        int idTipAbonament = -1;
                        if (File.Exists(abonamentPath))
                        {
                            //citit din fisier
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

                                    if (abonament.NrOrdineAbonament == tipFormularLog.idTranzactie)
                                        idTipAbonament = abonament.AbonamentTip;

                                    linie = readtext.ReadLine();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nu avem Bd abonamente!");
                        }

                        if (idTipAbonament != -1)
                        {
                            if (File.Exists(tipAbonamentPath))
                            {
                                //citit din fisier
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

                                        if (idTipAbonament == tipAbonament.NrOrdineTipAbonament)
                                            profit += tipAbonament.Pret;


                                        linie = readtext.ReadLine();

                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Nu avem Bd tip abonamente!");
                            }
                        }

                        break;
                    case 2:
                        nrExtraoptiuni++;
                        break;
                    case 3:
                        nrTipAbonamente++;
                        break;
                    default:
                        MessageBox.Show("Date gresite!");
                        break;
                }
            }
            //afisez graficele
            if (nrFormulare != 0)
            {
                int nrTipuriFormulare = 0;
                if (nrClienti != 0)
                    nrTipuriFormulare++;
                if (profit != -1)
                    nrTipuriFormulare++;
                if (nrExtraoptiuni != 0)
                    nrTipuriFormulare++;
                if (nrTipAbonamente != 0)
                    nrTipuriFormulare++;
                int latimeBaraGrafic = (vr - vl) / nrTipuriFormulare;

                int scala = 1000;//pot modif scala pt a incapea in grafic

                while (scala * nrClienti + 50 > vb || scala * (profit + 1) + 50 > vb ||
                      scala * nrExtraoptiuni + 50 > vb || scala * nrTipAbonamente + 50 > vb)
                    scala--;

                if (nrClienti != 0)
                {
                    g.FillRectangle(vectBrush[0], vl, vb - nrClienti * scala, latimeBaraGrafic, nrClienti * scala);
                    g.DrawString("Nr clienti:" + nrClienti, Font, new SolidBrush(Color.Black), vl, vb - nrClienti * scala - Font.Height);
                }
                if (profit != -1)
                {
                    int muta = 0;
                    if (nrClienti != 0)
                        muta += latimeBaraGrafic;
                    g.FillRectangle(vectBrush[1], vl + muta, vb - (profit + 1) * scala, latimeBaraGrafic, (profit + 1) * scala);
                    g.DrawString("Profitul lunar este:" + (profit + 1), Font, new SolidBrush(Color.Black), vl + muta, vb - (profit + 1) * scala - Font.Height);
                }
                if (nrExtraoptiuni != 0)
                {
                    int muta = 0;
                    if (nrClienti != 0)
                        muta += latimeBaraGrafic;
                    if (profit != -1)
                        muta += latimeBaraGrafic;
                    g.FillRectangle(vectBrush[2], vl + muta, vb - nrExtraoptiuni * scala, latimeBaraGrafic, nrExtraoptiuni * scala);
                    g.DrawString("Nr extraoptiuni:" + nrExtraoptiuni, Font, new SolidBrush(Color.Black), vl + muta, vb - nrExtraoptiuni * scala - Font.Height);
                }
                if (nrTipAbonamente != 0)
                {
                    int muta = 0;
                    if (nrClienti != 0)
                        muta += latimeBaraGrafic;
                    if (profit != -1)
                        muta += latimeBaraGrafic;
                    if (nrExtraoptiuni != 0)
                        muta += latimeBaraGrafic;
                    g.FillRectangle(vectBrush[3], vl + muta, vb - nrTipAbonamente * scala, latimeBaraGrafic, nrTipAbonamente * scala);
                    g.DrawString("Nr extraoptiuni:" + nrTipAbonamente, Font, new SolidBrush(Color.Black), vl + muta, vb - nrTipAbonamente * scala - Font.Height);
                }

            }
        }

        private void printareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(pdPrint);
            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = pd;
            dlg.ShowDialog();
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            //formatam ce trimitem
            string obj = null;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                obj += row.Cells[0].Value.ToString();
                obj += " ";
                obj += row.Cells[1].Value.ToString();
                obj += "\n";
            }
            //scapam de ultimul "\n"
            if (obj != null)
                obj = obj.Remove(obj.Length - 1, 1);

            if (obj != null)
                dataGridView1.DoDragDrop(obj, DragDropEffects.Copy | DragDropEffects.Move);
        }
    }
}