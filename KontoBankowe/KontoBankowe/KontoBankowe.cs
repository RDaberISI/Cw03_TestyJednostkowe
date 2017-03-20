using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Compatibility;
using NUnit.Framework;

namespace Bank
{
    public class KontoBankowe
    {
        private double _stanKonta = 0;

        public KontoBankowe(double kwota)
        {
            this._stanKonta = kwota;
        }

        public void WyplacPieniadze(double kwota)
        {
            if (kwota > this._stanKonta)
                throw new WyjatekNiewystarczajaceSrodkiNaKoncie();
            else
                this._stanKonta -= kwota;
        }

        public void WplacPieniadze(double kwota)
        {
            this._stanKonta += kwota;
        }

        public double SprawdzStanKonta
        {
            get { return this._stanKonta; }
        }

        public void PrzelejKwoteNaInneKonto(KontoBankowe konto, double kwota)
        {
            if (kwota > this._stanKonta)
                throw new WyjatekNiewystarczajaceSrodkiNaKoncie();
            else
            {
                this._stanKonta -= kwota;
                konto._stanKonta += kwota;
            }
        }
    }

    public class WyjatekNiewystarczajaceSrodkiNaKoncie : ApplicationException
    {

    }
}
