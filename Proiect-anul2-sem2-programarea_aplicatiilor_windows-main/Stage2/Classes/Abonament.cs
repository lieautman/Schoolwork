using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonatiTelefonici
{
    class Abonament
    {
        public int NrOrdineAbonament { get; set; }

        public int NrOrdineClient { get; set; }
        
        public int AbonamentTip { get; set; }

        public Abonament()
        {
            this.NrOrdineAbonament = -1;
            this.NrOrdineClient = -1;
            this.AbonamentTip = 0;
        }
        public Abonament(int NrOrdineAbonament, int NrOrdineClient, int Abonamenttip)
        {
            this.NrOrdineAbonament = NrOrdineAbonament;
            this.NrOrdineClient = NrOrdineClient;
            this.AbonamentTip = Abonamenttip;
        }

        public override string ToString()
        {
            return this.NrOrdineAbonament + " " + this.NrOrdineClient + " " + this.AbonamentTip;
        }
        public static List<Abonament> operator +(List<Abonament> la, Abonament a)
        {
            la.Add(a);
            return la;
        }
        //mi-ar trebuii pt a updata datele dar nu am putut sa fac asta
        public static List<Abonament> operator -(List<Abonament> la, Abonament a)
        {
            la.Remove(a);
            return la;
        }
        public int stringtoint(string s)
        {
            int a = Convert.ToInt32(s);
            return a;
        }
    }
}
