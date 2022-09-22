using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KolaySeviye.OrtalamaHesaplama
{
    public class OrtalamaHesapla
    {
        private uint derinlik = 1;
        public void Derinlik()
        {
            Matematik fibonacciHesaplama = new();
            bool dogrugiris;
            Console.Write("Sırasıyla kaç tane fibonacci sayısının ortalaması alınsın :");
            dogrugiris = uint.TryParse(Console.ReadLine(), out derinlik);
            if (!dogrugiris)
            {
                Console.WriteLine("Yanlış tuşlama yapıldı.Tekrar deneyin.");
                Derinlik();
            }
            else
                fibonacciHesaplama.Fibonacci(Convert.ToInt32(derinlik));

        }
    }
    public class Matematik
    {
        private List<int> sayiList = new List<int>();
        public void Fibonacci(int derinlik)
        {
            int fibonacci1 = 1;
            int fibonacci2 = 1;
            int fibonacci3;
            sayiList.Clear();
            for (int i = 0; i < derinlik; i++)
            {
                sayiList.Add(fibonacci1);
                fibonacci3 = fibonacci1 + fibonacci2;
                fibonacci1 = fibonacci2;
                fibonacci2 = fibonacci3;
            }
            Ortalama(derinlik, sayiList);
        }
        private void Ortalama(int sayiAdeti, List<int> ortalamaList)
        {
            int toplam = 0;
            foreach (var i in ortalamaList)
                toplam += i;
            int ortalama = toplam / sayiAdeti;
            Console.WriteLine("Sayıların ortalaması :" + ortalama+"\n Ana menü için bir tuşa basın.");
            Console.ReadKey();
            Console.Clear();
            
        }
    }
}
