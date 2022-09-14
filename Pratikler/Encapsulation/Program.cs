//Encapsulation
// Encapsulation yani Kapsülleme kavramı bir özelliği başka sınıflardan saklamak ya da korumaktır.
Ogrenci ogrenci = new Ogrenci();
ogrenci.Isim = "Sami";
ogrenci.Soyisim = "durur";
ogrenci.OgrenciNo = 536;
ogrenci.Sinif = 3;
ogrenci.Yas = 9;
ogrenci.OgrenciBilgileriniGetir();

ogrenci.SınıfAtlat();
ogrenci.OgrenciBilgileriniGetir();
//constructor erişimi
Ogrenci ogrenci1 = new Ogrenci("ömer", "köprü", 548,1,7);
ogrenci1.OgrenciBilgileriniGetir();

ogrenci1.SınıfDusur();
ogrenci1.OgrenciBilgileriniGetir();

Ogrenci ogrenci2 = new Ogrenci("murtaza", "bağrıyanık", 566, 1, 4);
ogrenci2.OgrenciBilgileriniGetir();


class Ogrenci
{
    private string isim;
    private string soyisim;
    private int ogrenciNo;
    private int sinif;
    private int yas;

    public string Isim
    {
        get
        { return isim; }
        set
        { isim = value; }
    }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
    public int Sinif
    {
        get => sinif;
        set
        {
            if (value < 1)
            {
                Console.WriteLine("Sınıf en az 1 olabilir");
                sinif = 1;
            }
            else
                sinif = value;
        }
    }

    public int Yas
    {
        get => yas; set
        {
            if (value > 5)
                yas = value;
            else
            {                             
                Console.WriteLine("Yaş en az 6 olmalıdır.Yaş 6 olarak atandı.");
                yas = 6;
            }
        }
    }
    //Constructor erişim için
    public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif,int yas)

    {
        Isim = isim;
        Soyisim = soyisim;
        OgrenciNo = ogrenciNo;
        Sinif = sinif;
        Yas = yas;
    }
    public Ogrenci() { }

    public void OgrenciBilgileriniGetir()
    {
        Console.WriteLine("****** Öğrenci Bilgileri ********");
        Console.WriteLine("Öğrenci Adı      :{0}", this.Isim);
        Console.WriteLine("Öğrenci Soyadı   :{0}", this.Soyisim);
        Console.WriteLine("Öğrenci No       :{0}", this.OgrenciNo);
        Console.WriteLine("Öğrenci Sınıfı   :{0}", this.Sinif);
        Console.WriteLine("Öğrenci Yaşı     :{0}", this.Yas);
    }

    public void SınıfAtlat()
    {
        this.Sinif = this.Sinif + 1;
    }
    public void SınıfDusur()
    {
        this.Sinif = this.Sinif - 1;
    }
}