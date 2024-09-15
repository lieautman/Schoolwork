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

using System.Security.Cryptography; // pt criptare parola

namespace AbonatiTelefonici
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }




        public static byte[] GetHash(string inputString)
        {
            HashAlgorithm algorithm = SHA256.Create();
            return algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString));
        }
        public static string GetHashString(string inputString)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte b in GetHash(inputString))
                sb.Append(b.ToString());

            return sb.ToString();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = DbConturi.accdb";
            OleDbConnection conexiune = new OleDbConnection(connString);

            try
            {
                conexiune.Open();
                OleDbCommand comanda = new OleDbCommand();
                comanda.Connection = conexiune;
                comanda.CommandText = "SELECT username,parola_hash,tip,nume,prenume,email from conturi where username='"+tbUsername.Text+"'";

                OleDbDataReader reader = comanda.ExecuteReader();

                reader.Read();

                //MessageBox.Show("Parola locala: "+GetHashString(tbParola.Text));
                //MessageBox.Show("Parola server: "+reader["parola_hash"].ToString());
                string parola_local = "";
                string parola_sever = "";
                for(int i = 0; i < 20; i++)
                {
                    parola_local = parola_local + GetHashString(tbParola.Text)[i];
                    parola_sever = parola_sever + reader["parola_hash"].ToString()[i];
                }

                //MessageBox.Show("Parola locala cut: " + parola_local);
                //MessageBox.Show("Parola server cut: " + parola_sever);

                if (parola_local != parola_sever)
                {
                    epNecompletat.SetError(tbParola, "Parola gresita!");
                    tbUsername.Clear();
                    tbParola.Clear();
                }
                else
                {
                    //citire date despre persoana/angajat si creare obiect
                    Angajat angajat = new Angajat(  reader["nume"].ToString(),
                                                    reader["prenume"].ToString(), 
                                                    reader["email"].ToString(), 
                                                    reader["username"].ToString(), 
                                                    reader["tip"].ToString());
                    if(reader["tip"].ToString() == "0")
                    {
                        conexiune.Close();
                        FormMain_Client frm = new FormMain_Client(angajat);
                        this.Hide();
                        frm.ShowDialog();
                        this.Show();
                        tbUsername.Clear();
                        tbParola.Clear();
                    }
                    if(reader["tip"].ToString() == "1")
                    {
                        conexiune.Close();
                        FormMain_Manager frm = new FormMain_Manager(angajat);
                        this.Hide();
                        frm.ShowDialog();
                        this.Show();
                        tbUsername.Clear();
                        tbParola.Clear();
                    }
                    if (reader["tip"].ToString() == "2")
                    {
                        conexiune.Close();
                        FormMain_Admin frm = new FormMain_Admin(angajat);
                        this.Hide();
                        frm.ShowDialog();
                        this.Show();
                        tbUsername.Clear();
                        tbParola.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message == "No data exists for the row/column.")
                {
                    epNecompletat.SetError(tbUsername, "Utilizator invalid!");
                    tbUsername.Clear();
                    tbParola.Clear();
                }
                else
                    MessageBox.Show(ex.Message);
            }
            finally
            {
                if(conexiune.State==ConnectionState.Open)
                    conexiune.Close();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            FormRegister frm = new FormRegister();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
