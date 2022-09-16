using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arayuzler_ornek
{
    public class Focus : IOtomobil
    {
        public Marka HangiMarkaArac()
        {
            return Marka.Ford;
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
