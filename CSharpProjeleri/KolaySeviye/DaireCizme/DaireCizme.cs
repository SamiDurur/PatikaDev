using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KolaySeviye.Hesaplamalar;

namespace KolaySeviye.DaireCizme
{
    internal class DaireCizme
    {
        public void YariCap()
        {
            Geometri geometri = new();
            double yCap;
            Console.Write("Yarı çapı kaç satır olsun: ");
            if (!double.TryParse(Console.ReadLine(), out yCap) || yCap <= 0)
            {
                Console.WriteLine("Yanlış tuşlama yapıldı.Tekrar deneyin.");
                return;
            }
            else
                geometri.Daire(yCap);
        }
    }
}
