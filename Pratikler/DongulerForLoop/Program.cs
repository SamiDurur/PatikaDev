using System;

namespace donguler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ekrandan girilen sayıya kadar alan tek sayılarını ekrana yazıdır
            Console.WriteLine("Lütfen bir sayı giriniz");
            int giris=int.Parse(Console.ReadLine());
            for (int i = 1; i < giris; i++)
            {
                if(i%2==1)
                 Console.WriteLine(i);
            }
            //1 ile 1000 arasındaki sayıları tek ve çift olarak ayırıp toplamlarını ekrana yazdır
            int tek=0;
            int cift=0;
            for (int i = 1; i <= 500; i++)
            {
                if(i%2==0)
                cift+=i;
                else
                tek+=i;
            }
            Console.WriteLine("1-1000 arasındaki tek sayıların toplamı: "+tek);
            Console.WriteLine("1-1000 arasındaki çift sayıların toplamı: " + cift);
            
            // break continue
            
            //Break komutu istenilen koşul gerçekleştiğinde döngüyü durdurur
            for (int i = 0; i <= 10; i++)
            {
                if(i==7)
                    break;
                Console.WriteLine(i);
            }
            //Continue komutu istenilen  koşul gerçekleştiğinde o bölümü atlar
            for (int i = 0; i <= 10; i++)
            {
                if(i==7)
                    continue;
                Console.WriteLine(i);
            }

            //iç içe loop ta break
            for (int a = 1; a <= 2; a++)
            {
                Console.WriteLine(a+". a döngüsüne girildi");
                for (int b = 1; b <= 2; b++)
                {
                    Console.WriteLine(b+". b döngüsüne girildi");
                    for (int c = 1; c <= 5; c++)
                        {
                            Console.WriteLine(c+". c döngüsüne girildi");
                            if(c==3)
                                break;
                            Console.WriteLine(c+". c döngüsü tamamlandı");
                        }
                    Console.WriteLine(b+". b döngüsü tamamlandı");
                }
                Console.WriteLine(a+". a döngüsü tamamlandı");
            }
            //iç içe loop ta continue
            for (int a = 1; a <= 2; a++)
            {
                Console.WriteLine(a+". a döngüsüne girildi");
                for (int b = 1; b <= 2; b++)
                {
                    Console.WriteLine(b+". b döngüsüne girildi");
                    for (int c = 1; c <= 5; c++)
                        {
                            Console.WriteLine(c+". c döngüsüne girildi");
                            if(c==3)
                                continue;
                            Console.WriteLine(c+". c döngüsü tamamlandı");
                        }
                    Console.WriteLine(b+". b döngüsü tamamlandı");
                }
                Console.WriteLine(a+". a döngüsü tamamlandı");
            }
            
            //for (int i; ;)  Sonsuz döngüyü ifade eder
        }
    }
}
