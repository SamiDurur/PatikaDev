using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KolaySeviye.Hesaplamalar;

namespace KolaySeviye.OrtalamaHesaplama
{
    public class OrtalamaHesapla
    {
        private uint derinlik = 1;
        public void Derinlik()
        {
            Matematik fibonacciHesaplama = new();
            Console.Write("Sırasıyla kaç tane fibonacci sayısının ortalaması alınsın :");
            if (!uint.TryParse(Console.ReadLine(), out derinlik))
            {
                Console.WriteLine("Yanlış tuşlama yapıldı.Tekrar deneyin.");
                return;
            }
            else
                fibonacciHesaplama.Fibonacci(Convert.ToInt32(derinlik));

        }
    }
}
