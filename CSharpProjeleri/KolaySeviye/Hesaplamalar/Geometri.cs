using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolaySeviye.Hesaplamalar
{
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
                for (int yildizSay = satirSay; yildizSay <= kacSatir; yildizSay++) { Console.Write("*"); }
                Console.WriteLine();
            }
            Console.WriteLine("\n Ana menü için bir tuşa basın.");
            Console.ReadLine();
            Console.Clear();
        }
        public void Daire(double yCap)
        {
            Console.Clear();
            double thickness = 0.4;
            double dDis = yCap + thickness;
            for (double y = yCap; y >= -yCap; --y)
            {
                for (double x = -yCap; x < dDis; x += 0.5)
                {
                    double value = x * x + y * y;                    

                    if (value <= dDis * dDis)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
