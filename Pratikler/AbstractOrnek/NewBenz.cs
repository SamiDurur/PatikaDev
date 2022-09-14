using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_ornek
{
    internal class NewBenz : Otomobil
    {
        public override Marka HangiMarkaArac()
        {
            return Marka.Mercedes;
        }
        public override Renk StandartRengiNe()
        {
            return Renk.Gri;
        }
    }
}
