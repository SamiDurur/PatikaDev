using System;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Console.WriteLine("********* Atama ve İşlemli Atama ************");
            
            // Atama ve İşlemli Atama
            
            int s1=3;
            int s2=9;
            s2=s2+2;
            
            Console.WriteLine(s2);
            s2+=2;
            Console.WriteLine(s2);
            s2/=1;
            Console.WriteLine(s2);
            s1*=2;
            Console.WriteLine(s1);

            Console.WriteLine("********* Mantıksal Operatorler ************");
            
            //Mantıksal Operatörler
            // ||,&&, !
        
            bool isSuccess=true;
            bool isComplated=false;

            if(isSuccess&&isComplated)
            Console.WriteLine("Perfect!");

            if(isSuccess||isComplated)
            Console.WriteLine("Great!");

            if(isSuccess&&!isComplated)
            Console.WriteLine("Fine!");

            Console.WriteLine("********* İlişkisel Operatorler ************");

            //İlişkisel Operatorler
            // <, >, <= ,>=, ==, !=

            int s3=6;
            int s4=7;
            bool sonuc=s3<s4;
            
            Console.WriteLine(sonuc);
            sonuc=s3>s4;
            Console.WriteLine(sonuc);
            sonuc=s3>=s4;
            Console.WriteLine(sonuc);
            sonuc=s3<=s4;
            Console.WriteLine(sonuc);
            sonuc=s3==s4;
            Console.WriteLine(sonuc);
            sonuc=s3!=s4;
            Console.WriteLine(sonuc);

            Console.WriteLine("********* Aritmetik Operatörler ************");

            //Aritmetik Operatörler
            // +, -, *, /

            int s5=10;
            int s6=5;
            int sonuc1=s5/s6;
            Console.WriteLine(sonuc1);
            sonuc1=s5*s6;
            Console.WriteLine(sonuc1);
            sonuc1=s5+s6;
            Console.WriteLine(sonuc1);
            sonuc1=++s5;
            Console.WriteLine(sonuc1);
            
            // % : mod alır (Böldükten sonra kalanı getiren ifade)

            int sonuc2=20%3;
            Console.WriteLine(sonuc2);

        }
    }
}
