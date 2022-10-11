using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KolaySeviye.Hesaplamalar;

namespace KolaySeviye.Algoritma
{
    internal class UcgenCizme
    {
        public void Boyut()
        {
            Geometri geometri = new();
            uint kacSatir = 0;
            Console.Write("Eşkenar üçgen satır yüksekliğini girin: ");
            if (!uint.TryParse(Console.ReadLine(), out kacSatir))
            {
                Console.WriteLine("Yanlış tuşlama yapıldı.Tekrar deneyin.");
                return;
            }
            else
                geometri.Ucgen(Convert.ToInt32(kacSatir));
        }

    }
}