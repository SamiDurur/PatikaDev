using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_ornek
{
    internal abstract class Otomobil:IOtomobil
    {
        public abstract Marka HangiMarkaArac();

        public int KacTekerlektenOlusur() 
        {
            return 4; 
        }
        public virtual Renk StandartRengiNe()
        {
            return Renk.Beyaz;
        }

    }
}
