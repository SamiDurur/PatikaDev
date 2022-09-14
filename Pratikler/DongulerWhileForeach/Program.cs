using System;

namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 den başlayarak girilen sayının kedisi ile birlikte  toplayıp ortalamasını ver
            Console.Write("Sayıyı Gir : ");
            int sayi=int.Parse(Console.ReadLine());
            int sayac=1;
            int toplam=0;
            while (sayi>=sayac)
            {
                toplam+=sayac;
                sayac++;
            }
            Console.WriteLine(toplam);
            Console.WriteLine(toplam/sayac);

            //Tüm harfleri console yazdır.

            var a='A';
            while (a<='Z')
            {
                Console.Write(a+" - ");
                a++;
            }
            Console.WriteLine();

            //*************Foreach**********

            string[] arabalar={"TESLA","BMW","Ford","Toyota","Fiat","Nissan","Mini Cooper"};
            foreach (var item in arabalar)
            {
                Console.WriteLine(item);
            }



        }
    }
}
