using System;

namespace metotlar_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametre
            string sayi="999";
            
            int outsayi;
            bool sonuc = int.TryParse(sayi,out outsayi);
            if(sonuc){
                Console.WriteLine("Başarılı!");
                Console.WriteLine(outsayi);
            }
            else
            Console.WriteLine("başarısız!");

            Metotlar_Overloading instance = new Metotlar_Overloading(); 
            instance.Topla(4,6,out int toplamSonuc);
            Console.WriteLine(toplamSonuc);

            //Mwtot Aşırı yükleme - Overloading
            
            int ifade=980;
            string isim="Sami";
            string yas="Yaşı: ";
            int yas1=26;
            //eğer int olarak metot aşırı yüklemesi yapmasaydım alttaki koda hata vericekti 
            //yazdır metot unu aşağıda 2 kere tanımladım birinde int birinde string 
            instance.Yazdir("Tamamdır");
            instance.Yazdir(ifade);
            instance.Yazdir(ifade,yas1);
            instance.Yazdir(isim," DURUR");
            instance.Yazdir("Sami ","DURUR");
            instance.Yazdir(yas,yas1);
            instance.Yazdir(ifade,isim);

        }
    }

    class Metotlar_Overloading
    {
        public void Topla(int a,int b,out int toplam)
        {
            toplam=a+b;
        }
        //Metot Aşırı yükleme - Overloading
        //Metot Imzası
        //metotAdi + parametre sayisi + Parametre
        //overloading metot kullanabilmek icin  verTipi değişmeli ya da fazladan veri girilmeli ornek
        public void Yazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public void Yazdir(int veri)
        {
            Console.WriteLine(veri);
        }
        public void Yazdir(int veri,int veri1)
        {
            Console.Write(veri);
            Console.WriteLine(veri1);
        }
         public void Yazdir(string veri,string veri1)
        {
            Console.Write(veri);
            Console.WriteLine(veri1);
        }
         public void Yazdir(string veri,int veri1)
        {
            Console.Write(veri);
            Console.WriteLine(veri1);
        }
         public void Yazdir(int veri,string veri1)
        {
            Console.Write(veri);
            Console.WriteLine(veri1);
        }
    }
}
