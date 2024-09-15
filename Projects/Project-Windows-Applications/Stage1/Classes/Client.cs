using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonatiTelefonici
{
    class Client
    {
        public int NrOrdine { get; set; }
        public string CNP { get; set; }
        public string nume { get; set; }
        public string prenume { get; set; }
        //public int varsta { get; set; }
        public string nationalitate { get; set; }
        public string plata { get; set; }

        public Client()
        {
            this.NrOrdine = -1;
            this.CNP = "";
            this.nume = "";
            this.prenume = "";
            //this.varsta = -1;
            this.nationalitate = "";
            this.plata = "";
        }
        public Client(int NrOrdine, string CNP, string nume, string prenume, /*int varsta,*/ string nationalitate, string plata)
        {
            this.NrOrdine = NrOrdine;
            this.CNP = CNP;
            this.nume = nume;
            this.prenume = prenume;
            //this.varsta = varsta;
            this.nationalitate = nationalitate;
            this.plata = plata;
        }

        public override string ToString()
        {
            return this.NrOrdine + " " + this.CNP + " " + this.nume + " " + this.prenume + " " + this.nationalitate + " " + this.plata;
        }

    }
}
