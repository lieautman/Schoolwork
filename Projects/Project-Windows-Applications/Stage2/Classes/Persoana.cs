using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonatiTelefonici
{
    public abstract class Persoana
    {
        public string nume { get; set; }
        public string prenume { get; set; }
        public string email { get; set; }

        public Persoana()
        {
            nume = "";
            prenume = "";
            email = "";
        }
        public Persoana(string nume, string prenume, string email)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.email = email;
        }
        public override string ToString()
        {
            return this.nume + " " + this.prenume + " " + this.email;
        }
    }
}
