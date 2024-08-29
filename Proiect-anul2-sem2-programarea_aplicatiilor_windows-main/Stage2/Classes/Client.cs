using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonatiTelefonici
{
    class Client:Persoana
    {
        public int NrOrdine { get; set; }
        public string CNP { get; set; }
        public string nationalitate { get; set; }
        public string plata { get; set; }

        public Client() : base()
        {
            this.NrOrdine = -1;
            this.CNP = "";
            this.nationalitate = "";
            this.plata = "";
        }
        public Client(int NrOrdine, string CNP, string nume, string prenume, string email, string nationalitate, string plata):base(nume, prenume, email)
        {
            this.NrOrdine = NrOrdine;
            this.CNP = CNP;
            this.nationalitate = nationalitate;
            this.plata = plata;
        }

        public override string ToString()
        {
            return this.NrOrdine + " " + this.CNP + " " + this.nume + " " + this.prenume + " " + this.email + " " + this.nationalitate + " " + this.plata;
        }

        public static List<Client> operator +(List<Client> lc, Client c)
        {
            lc.Add(c);
            return lc;
        }
        //mi-ar trebuii pt a updata datele dar nu am putut sa fac asta
        public static List<Client> operator -(List<Client> lc, Client c)
        {
            lc.Remove(c);
            return lc;
        }
    }
}
