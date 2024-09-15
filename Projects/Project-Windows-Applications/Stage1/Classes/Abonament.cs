using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonatiTelefonici
{
    enum AbonamentTip
    {
        Abonamentul0,
        Abonamentul1,
        Abonamentul2,
        Abonamentul3
    }
    class Abonament
    {
        public int NrOrdineAbonament { get; set; }

        public int NrOrdineClient { get; set; }
        
        public AbonamentTip Abonamenttip { get; set; }

        public Abonament()
        {
            this.NrOrdineAbonament = -1;
            this.NrOrdineClient = -1;
            this.Abonamenttip = 0;
        }
        public Abonament(int NrOrdineAbonament, int NrOrdineClient, AbonamentTip Abonamenttip)
        {
            this.NrOrdineAbonament = NrOrdineAbonament;
            this.NrOrdineClient = NrOrdineClient;
            this.Abonamenttip = Abonamenttip;
        }

        public override string ToString()
        {
            return this.NrOrdineAbonament + " " + this.NrOrdineClient + " " + this.Abonamenttip;
        }

        public AbonamentTip stringtoenum(string s)
        {
            AbonamentTip a = (AbonamentTip)Enum.Parse(typeof(AbonamentTip), s);
            return a;
        }
    }
}
