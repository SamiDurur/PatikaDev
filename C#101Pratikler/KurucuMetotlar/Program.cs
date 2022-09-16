//kurucu metotlar - yapıcı metotlar - constructor
//Bir sınıftan bir nesne oluşturulduğunda biz tanımlamasak bile arka planda çalışan varsayılan yapıcı metotlara kurucu yada constructor denir.
//Sınıf nesnesi ilk oluşturulduğunda yapılmasını istediğimiz işleri kurucu metotlar içerisinde yaparız.
//Yapıcı metotların isimleri sınıf isimleri ile aynı olmak zorundadır.
//Public olarak bildirilmeleri gerekir.
//Geri dönüş değerleri yoktur.
//Kurucu metotların imzasını değiştirerek overload edebiliriz yani aşırı yükleyebiliriz. 
/*
 * Default constructor'ın görevi sınıfın içerindeki özelliklere ilk değer ataması yapılmadığında onların default değerlerini set etmektir.
 * Şöyle düşünebilirsiniz; sınıf içerisinde string veri tipinde bir özellik varsa ve siz ilk değer atamasını yapmazsanız
varsayılan kurucu onun atamasını arka planda null olarak yapar. Aynı integer tipinde bir özelliğin ilk değer atamasını 0 olarak yapar.
*/
/*****************************************************************************/
//Söz Dizimi
//class SınıfAdı
//{
//      [Erişim Belirleyici] [Veri Tipi] ÖzellikAdı;
//      [Erişim Belirleyici] [Geri Dönüş Tipi] MetotAdı([Parametre Listesi])
//      {
//          //Metot Komutları
//      }
//}

//Erişim Belirleyiciler
// * Public - Her yerden erişilebilir
// * Private - Sadece tanımlandığı sınıf içerisinde erişilebilir
// * Internal - Kendi bulunduğu proje içerisinde erişilebilir
// * Protected - Sadece tanımlandığı sınıfta ve o sınıftan kalıtım alan (miras) alan diğer sınıflarda erişilebilir

using System;
Calisan calisan1 = new Calisan("Ramazan", "Kara", 55566889, "Satın Alma");
calisan1.CalisanBilgileri();
Console.WriteLine("***--****--****--***");

Calisan calisan4 = new Calisan("Ramazan", "Kara");
calisan4.CalisanBilgileri();
Console.WriteLine("***--****--****--***");

Calisan calisan2 = new Calisan();
calisan2.Ad = "Sarah";
calisan2.Soyad = "Ayaz";
calisan2.No = 00856884;
calisan2.Departman = "Müdür";
calisan2.CalisanBilgileri();
Console.WriteLine("***--****--****--***");

Calisan calisan3 = new Calisan
{
    Ad = "Murtaza",
    Soyad = "Gözüküçük",
    No = 23566978,
    Departman = "İnsan Kaynakları"
};
calisan3.CalisanBilgileri();

class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;

    //Kurucu Metot
    public Calisan(string ad, string soyad, int no, string departman)
    {

        this.Ad = ad;
        this.Soyad = soyad;
        this.No = no;
        this.Departman = departman;
    }
    //kurucu metotu aşırı yükleme
    public Calisan(string ad, string soyad)
    {

        this.Ad = ad;
        this.Soyad = soyad;
    }
    public Calisan() { }
    public void CalisanBilgileri()
    {
        Console.WriteLine("Çalışanın Adı: {0}", Ad);
        Console.WriteLine("Çalışanın Soyadı: {0}", Soyad);
        Console.WriteLine("Çalışanın Numarası: {0:00000000}", No);
        Console.WriteLine("Çalışanın Deparmanı: {0}", Departman);
    }

}