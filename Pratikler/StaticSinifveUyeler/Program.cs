//Static olan sınıfların içerisinde static olmayan herhangi bir metot ve property kullanamayız tanımlayamayız
//static sınıflara kalıtım işlemi uygulanamaz


Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);

Calisan calisan = new Calisan("ramazan","kayık","Satın Alma");
Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);
Calisan calisan2 = new Calisan("ramiz", "karaeski", "Aktör");
Calisan calisan3 = new Calisan("remziye", "şişik", "IK");
Console.WriteLine("Çalışan Sayısı: {0}", Calisan.CalisanSayisi);

//static bir sını üyesine erişe bilmek için SınıfAdı.Ulaşılacakİşlem
Islemler.Topla(59, 20);

Console.WriteLine("Toplama işlemi sonucu: {0}", Islemler.Topla(100, 200));

Console.WriteLine("Çıkarma işlemi sonucu: {0}",Islemler.Cıkar(500,100));



class Calisan
{
    private static int calisanSayisi;

    public static int CalisanSayisi { get => calisanSayisi; }

    private string isim;
    private string soyisim;
    private string departman;

    static Calisan()
    {
        calisanSayisi = 0;
    }

    public Calisan(string isim, string soyisim, string departman)
    {
        this.isim = isim;
        this.soyisim = soyisim;
        this.departman = departman;
        calisanSayisi++;
    }
}
static class Islemler
{
    public static long Topla(int sayi1,int sayi2)
    {
        return sayi1 + sayi2;   
    }
    public static long Cıkar(int sayi1, int sayi2)
    {
        return sayi1 - sayi2;
    }
}