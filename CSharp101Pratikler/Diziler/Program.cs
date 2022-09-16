using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi Tanımlama
            string[]renkler = new string[5];
            
            string []hayvanlar={"kedi","köpek","kuş","maymun"};

            int[]dizi;
            dizi= new int[5];

            //Dizilere Değer Atama ve Erişim
            renkler[0]="Mavi";
            
            dizi[3]=10;

            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //Döngülerle dizi kullanımı
            
            //Klavyeden girilen n tane sayının ortalamsını hesaplayan program
            Console.Write("Dizinin Eleman sayısını giriniz: ");
            int dizisayisi=int.Parse(Console.ReadLine());
            int[] dizi1 =new int[dizisayisi];
            
            for (int i = 0; i < dizisayisi; i++)
            {
                Console.Write("{0}. Sayıyı gir : ",i+1);
                dizi1[i]=int.Parse(Console.ReadLine());
            }
            int topla=0;
            foreach (var item in dizi1)
                topla+=item;
            Console.WriteLine("Sayıların toplamı: "+topla);
            Console.WriteLine("Sayıların Ortalaması: " +topla/dizisayisi);
        }
    }
}
