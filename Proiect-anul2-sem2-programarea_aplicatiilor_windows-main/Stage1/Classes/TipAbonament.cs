using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonatiTelefonici
{
    class TipAbonament
    {
        public int NrOrdineTipAbonament { get; set; }
        public int NrMesaje { get; set; }
        public int NrMinute { get; set; }
        public int NrGbInternet { get; set; }
        public float Pret { get; set; }

        public TipAbonament()
        {
            this.NrOrdineTipAbonament = -1;
            this.NrMesaje = -1;
            this.NrMinute = -1;
            this.NrGbInternet = -1;
            this.Pret = -1;
        }
        public TipAbonament(int NrOrdineTipAbonament,int NrMesaje,int NrMinute,int NrGbInternet,float Pret)
        {
            this.NrOrdineTipAbonament = NrOrdineTipAbonament;
            this.NrMesaje = NrMesaje;
            this.NrMinute = NrMinute;
            this.NrGbInternet = NrGbInternet;
            this.Pret = Pret;
        }
        public override string ToString()
        {
            return this.NrOrdineTipAbonament + " " + this.NrMesaje + " " + this.NrMinute + " " + this.NrGbInternet + " " + this.Pret;
        }
    }
}
