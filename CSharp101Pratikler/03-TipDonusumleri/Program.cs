using System;

namespace Tip_donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit Conversion (Bilinçsiz Dönüşüm)
            //Büyük kapasiteliden küçük kapasiteliye bilinçsiz dönüşüm yapılamıyor
            Console.WriteLine("***** Implicit Conversion *****");

            byte b=5;
            sbyte sb=30;
            short s=10;

            int i=b+sb+s;
            Console.WriteLine("i: " + i);

            long l=i;
            Console.WriteLine("l: "+l);

            float f=l;
            Console.WriteLine("f: "+f);

            string st="Sami";
            char c='s';
            object o=st+c+i;
            Console.WriteLine("o: "+o);

            //Explicit Conversion (Bilinçli Dönüşüm)

            Console.WriteLine("***** Explicit Conversion *****");

            int ii=4;
            byte bb=(byte)ii;
            Console.WriteLine("bb: "+bb);

            int x=100;
            byte y=(byte)x;
            Console.WriteLine("y: "+y);

            float w=10.3f;
            byte v=(byte)w;
            Console.WriteLine("v: "+v);
                
                //ToString Methodu
                
                Console.WriteLine("***** ToString Methodu *****");
                int xx=6;
                string yy=xx.ToString();
                Console.WriteLine("yy: "+yy);
                
                string zz=12.5f.ToString();
                Console.WriteLine("zz: "+zz);

                //System.Convert
                Console.WriteLine("***** System.Convert Sınıfı *****");
                
                string s1="10",s2="20";
                int sayi1;
                int sayi2;
                int toplam;
                sayi1=Convert.ToInt32(s1);
                sayi2=Convert.ToInt32(s2);

                toplam=sayi1+sayi2;
                
                Console.WriteLine("Toplam :"+toplam);

                //Parse Methodu
                Console.WriteLine("***** Parse Methodu*****");
                ParseMethod();


        }
            public static void ParseMethod()
            {
                 string metin1="10";
                string metin2="10,55";
                int rakam1;
                double double1;

                rakam1=Int32.Parse(metin1);
                double1=Double.Parse(metin2);

                Console.WriteLine("rakam1:"+rakam1);
                Console.WriteLine("double1:"+double1);
            }
    } 
}
