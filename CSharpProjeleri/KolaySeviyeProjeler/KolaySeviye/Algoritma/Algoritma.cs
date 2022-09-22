using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolaySeviye.Algoritma
{
    internal class Algoritma
    {
        public void Boyut()
        {
            Geometri geometri = new();
            uint kacSatir = 0;
            bool dogrugiris;
            Console.Write("Eşkenar üçgen satır yüksekliğini girin: ");
            dogrugiris = uint.TryParse(Console.ReadLine(), out kacSatir);
            if (!dogrugiris)
            {
                Console.WriteLine("Yanlış tuşlama yapıldı.Tekrar deneyin.");
                Boyut();
            }
            else
                geometri.Ucgen(Convert.ToInt32(kacSatir));
        }

    }

    public class Geometri
    {
        public void Ucgen(int kacSatir)
        {
            Console.Clear();
            for (int a = kacSatir; a >= 1; a--)
                Console.Write(" ");
            kacSatir--;

            Console.WriteLine("*");

            for (int satirSay = kacSatir; satirSay > 0; satirSay--)
            {
                for (int boslukSay = satirSay; boslukSay > 0; boslukSay--) { Console.Write(" "); }
                for (int yildizSay = satirSay; yildizSay <= kacSatir; yildizSay++) { Console.Write("*"); }
                Console.Write("*");
                for(int yildizSay = satirSay; yildizSay <= kacSatir; yildizSay++) { Console.Write("*"); }
                Console.WriteLine();
            }
            Console.WriteLine("\n Ana menü için bir tuşa basın.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}