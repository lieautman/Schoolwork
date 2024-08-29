using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonatiTelefonici
{
    class TipFormularLog
    {
        public int tipFormular { get; set; }
        public int idTranzactie { get; set; }
        public TipFormularLog()
        {
            tipFormular = 0;
            idTranzactie = 0;
        }
        public TipFormularLog(int tipFormulat,int idTranzactie)
        {
            this.tipFormular = tipFormular;
            this.idTranzactie = idTranzactie;
        }
        public override string ToString()
        {
            return tipFormular + " " + idTranzactie;
        }
    }
}
