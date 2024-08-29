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

using System.Security.Cryptography;//pt criptare parola

namespace AbonatiTelefonici
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnInregistrare_Click(object sender, EventArgs e)
        {
            if (tbParola.Text != tbParola2.Text)
            {
                epNecompletat.SetError(tbParola, "Parolele trebuie sa fie la fel!");
                epNecompletat.SetError(tbParola2, "Parolele trebuie sa fie la fel!");
                tbParola.Clear();
                tbParola2.Clear();
            }
            else
            {
                //plasare in baza de date
                string connString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = DbConturi.accdb";
                OleDbConnection conexiune = new OleDbConnection(connString);
                try
                {
                    conexiune.Open();

                    OleDbCommand comanda = new OleDbCommand();
                    comanda.Connection = conexiune;

                    comanda.CommandText = "INSERT INTO conturi VALUES(?,?,?,?,?,?)";
                    comanda.Parameters.Add("username", OleDbType.Char, 20).Value = tbUsername.Text;
                    comanda.Parameters.Add("parola_hash", OleDbType.Char, 50).Value = GetHashString(tbParola.Text);
                    comanda.Parameters.Add("tip", OleDbType.Integer).Value = 0;
                    comanda.Parameters.Add("nume", OleDbType.Char, 20).Value = tbNume.Text;
                    comanda.Parameters.Add("prenume", OleDbType.Char, 20).Value = tbPrenume.Text;
                    comanda.Parameters.Add("email", OleDbType.Char, 20).Value = tbEmail.Text;
                    comanda.ExecuteNonQuery();

                    MessageBox.Show("S-a introdus cu succes!");
                    tbParola.Clear();
                    tbParola2.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conexiune.Close();
                }
            }
        }
    }
}
