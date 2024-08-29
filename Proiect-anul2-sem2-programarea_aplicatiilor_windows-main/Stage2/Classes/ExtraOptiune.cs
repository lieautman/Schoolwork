using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbonatiTelefonici
{
    enum ExtraOptiuneTip
    {
        MinuteConvorbire,
        Mesaje,
        GbInternet
    }
    class ExtraOptiune
    {
        public int NrOrdineExtraoptiune { get; set; }

        public int NrOrdineAbonament { get; set; }

        public ExtraOptiuneTip Optiune { get; set; }
        public int Number { get; set; }


        public ExtraOptiune()
        {
            this.NrOrdineExtraoptiune = -1;
            this.NrOrdineAbonament = -1;
            this.Optiune = 0;
            this.Number = 0;
        }
        public ExtraOptiune(int NrOrdineExtraoptiune, int NrOrdineAbonament, ExtraOptiuneTip Optiune, int Number)
        {
            this.NrOrdineExtraoptiune = NrOrdineExtraoptiune;
            this.NrOrdineAbonament = NrOrdineAbonament;
            this.Optiune = Optiune;
            this.Number = Number;
        }

        public override string ToString()
        {
            return this.NrOrdineExtraoptiune + " " + this.NrOrdineAbonament + " " + this.Optiune + " " + this.Number;
        }
        public static List<ExtraOptiune> operator +(List<ExtraOptiune> leo, ExtraOptiune eo)
        {
            leo.Add(eo);
            return leo;
        }
        //mi-ar trebuii pt a updata datele dar nu am putut sa fac asta
        public static List<ExtraOptiune> operator -(List<ExtraOptiune> leo, ExtraOptiune eo)
        {
            leo.Remove(eo);
            return leo;
        }
        public ExtraOptiuneTip stringtoenum(string s)
        {
            if (s.Contains("Mesaje"))
            {
                return (ExtraOptiuneTip)Enum.Parse(typeof(ExtraOptiuneTip), "Mesaje");
            }
            else if(s.Contains("Minute Convorbire")|| s.Contains("MinuteConvorbire"))
            {
                return (ExtraOptiuneTip)Enum.Parse(typeof(ExtraOptiuneTip), "MinuteConvorbire");
            }
            else if (s.Contains("Gb Internet")|| s.Contains("GbInternet"))
            {
                return (ExtraOptiuneTip)Enum.Parse(typeof(ExtraOptiuneTip), "GbInternet");
            }
            else
            {
                return (ExtraOptiuneTip)Enum.Parse(typeof(ExtraOptiuneTip), "error");
            }
        }
    }
}
