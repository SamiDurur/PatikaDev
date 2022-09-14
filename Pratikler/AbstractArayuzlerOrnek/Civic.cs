using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arayuzler_ornek
{
    internal class Civic : IOtomobil
    {
        public Marka HangiMarkaArac()
        {
            return Marka.Honda;
        }

        public int KacTekerlektenOluşur()
        {
            return 4;
        }

        public Renk StandartRengiNe()
        {
            return Renk.Beyaz;
        }
    }
}
