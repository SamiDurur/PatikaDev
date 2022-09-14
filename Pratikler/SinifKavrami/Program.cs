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

Calisan calisan1 = new Calisan();
calisan1.Ad = "Ramazan";
calisan1.Soyad = ":Kara";
calisan1.No = 55566889;
calisan1.Departman = "Satın Alma";
calisan1.CalisanBilgileri();
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

    public void CalisanBilgileri()
    {
        Console.WriteLine("Çalışanın Adı: {0}", Ad);
        Console.WriteLine("Çalışanın Soyadı: {0}", Soyad);
        Console.WriteLine("Çalışanın Numarası: {0:00000000}", No);
        Console.WriteLine("Çalışanın Deparmanı: {0}", Departman);
    }

}