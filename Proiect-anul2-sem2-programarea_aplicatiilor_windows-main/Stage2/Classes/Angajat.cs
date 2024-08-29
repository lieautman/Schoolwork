using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonatiTelefonici
{
    public enum TipUser
    {
        Regular,
        Manager,
        Admin
    }
    public class Angajat : Persoana, ICloneable
    {
        public string username { get; set; }
        public TipUser tipUser { get; set; }

        public void stringToEnum(string s)
        {
            TipUser buffer = (TipUser)Enum.Parse(typeof(TipUser), s);
            this.tipUser = buffer;
        }

        public Angajat() : base()
        {
            username = "";
            tipUser = 0;
        }
        public Angajat(string nume, string prenume, string email)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.email = email;
        }
        public Angajat(string nume, string prenume, string email, string username, string tipUser) : base(nume, prenume, email)
        {
            this.username = username;
            this.stringToEnum(tipUser);
        }
        public override string ToString()
        {
            return this.username + " " + this.tipUser + " " + this.nume + " " + this.prenume + " " + this.email;
        }

        public object Clone()
        {
            Angajat clona = new Angajat();
            clona.nume = this.nume;
            clona.prenume = this.prenume;
            clona.email = this.email;
            clona.username = this.username;
            clona.tipUser = this.tipUser;
            return clona;
        }
    }
}
