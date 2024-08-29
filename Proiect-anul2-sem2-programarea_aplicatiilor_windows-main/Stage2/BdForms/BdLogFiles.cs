using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;//pt acces
using System.IO;
using System.Xml;

namespace AbonatiTelefonici
{
    public partial class BdLogFiles : Form
    {
        public BdLogFiles()
        {
            InitializeComponent();


            List<Angajat> listAngajat = new List<Angajat>();

            string connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = DbConturi.accdb";

            OleDbConnection conexiune = new OleDbConnection(connString);

            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "SELECT * from conturi";

                OleDbDataReader reader = comanda.ExecuteReader();

                while (reader.Read())
                {
                    Angajat angajat = new Angajat();
                    angajat.username = reader["username"].ToString();
                    angajat.stringToEnum(reader["tip"].ToString());
                    angajat.nume = reader["nume"].ToString();
                    angajat.prenume = reader["prenume"].ToString();
                    angajat.email = reader["email"].ToString();


                    /* //lista trebuie sa aiba cel putin un element pt a se realiza codul de mai sus
                                        if (listAngajat.Count.Equals(0))
                                        {
                                            listAngajat.Add(angajat);
                                        }*/
                    listAngajat.Add(angajat);
                }
                //afisam datele in tabel
                dgvBdLogFile.DataSource = listAngajat;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conexiune.State == ConnectionState.Open)
                    conexiune.Close();
            }
        }
        private void dgvBdLogFile_DoubleClick(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvBdLogFile.SelectedRows)
            {
                Angajat angajat = new Angajat();

                angajat.username = row.Cells[0].Value.ToString();
                angajat.stringToEnum(row.Cells[1].Value.ToString());
                angajat.nume = row.Cells[2].Value.ToString();
                angajat.prenume = row.Cells[3].Value.ToString();
                angajat.email = row.Cells[4].Value.ToString();

                DisplayDateLogate frm = new DisplayDateLogate(angajat);
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
        }

        private void exportXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = GetDataTableFromDGV(dgvBdLogFile);
                DataSet ds = new DataSet();
                ds.Tables.Add(dt);

                ds.WriteXml("exportConturi.xml");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);   
            }
        }
        private DataTable GetDataTableFromDGV(DataGridView dgv)
        {
            DataTable dt = new DataTable();
            foreach(DataGridViewColumn column in dgv.Columns)
            {
                dt.Columns.Add();
            }
            object[] cellValues = new object[dgv.Columns.Count];
            foreach(DataGridViewRow row in dgv.Rows)
            {
                for(int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }
                dt.Rows.Add(cellValues);
            }


            return dt;
        } 
    }
}
