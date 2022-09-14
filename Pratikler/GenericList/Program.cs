//List<T> class
//System.Collections.Generic namespace altından geliyor
//<T> object türündedir.
//List<T> -----<T>hangi tipte bir liste oluşturacağımızı burada belirleriz.
//<int> - <string> - <T> - <var>

    List<int> sayiListesi = new List<int>();
    sayiListesi.Add(23);
    sayiListesi.Add(10);
    sayiListesi.Add(22);
    sayiListesi.Add(35);
    sayiListesi.Add(55);

    List<string> renkListesi = new List<string>();
    renkListesi.Add("Mavi");
    renkListesi.Add("Kırmızı");
    renkListesi.Add("Sarı");
    renkListesi.Add("Yeşil");
    renkListesi.Add("Mor");

//Count Kaç eleman olduğunu gösterir
    Console.WriteLine(sayiListesi.Count);
    Console.WriteLine(renkListesi.Count);
//Foreach ve List.ForEach ile Elemanlara erişim
    foreach (var sayi in sayiListesi)
        Console.WriteLine(sayi);
    foreach (var renk in renkListesi)
        Console.WriteLine(renk);

    sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
    renkListesi.ForEach(renk=> Console.WriteLine(renk));

//Listeden eleman çıkarma 
    sayiListesi.Remove(22);
    renkListesi.Remove("Mor");
    //indexine göre  silme
    sayiListesi.RemoveAt(0);
    renkListesi.RemoveAt(1);

    sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
    renkListesi.ForEach(renk=> Console.WriteLine(renk));

//Liste içerisinde arama
    if(sayiListesi.Contains(10))
        Console.WriteLine("10 Liste içerisinde bulundu!");

//Eleman ile index'ine erişme
    Console.WriteLine(renkListesi.BinarySearch("Sarı"));
    Console.WriteLine(sayiListesi.BinarySearch(55));

//Diziyi List'e çevirme
    string[] hayvanlar={"Kedi","köpek","maymun","şenpanze"};
    List<string> hayvan=new List<string> (hayvanlar);
    
    hayvan.ForEach(hayvn=> Console.WriteLine(hayvn));

//Liste Temizleme

    hayvan.Clear();


//Liste içerisinde nesne tutma ve kullanıcı ekleme

    List <Kullanıcılar> kullanıcıListesi= new List<Kullanıcılar>();
    Kullanıcılar kullanıcı1=new Kullanıcılar();
    kullanıcı1.Isim="Sami";
    kullanıcı1.Soyisim="Zımba";
    kullanıcı1.Yas=26;

    Kullanıcılar kullanıcı2=new Kullanıcılar();
    kullanıcı2.Isim="Umit";
    kullanıcı2.Soyisim="Dudur";
    kullanıcı2.Yas=27;

    kullanıcıListesi.Add(kullanıcı1);
    kullanıcıListesi.Add(kullanıcı2);

    List<Kullanıcılar> yeniListe=new List<Kullanıcılar>();
    yeniListe.Add(new Kullanıcılar(){
        Isim="Ata",
        Soyisim="Yaşar",
        Yas=22
    });

    //Listenin içine Erişme
    foreach (var kullanıcı in kullanıcıListesi)
    {
        Console.WriteLine("Kullanıcı Adı:"+kullanıcı.Isim);
        Console.WriteLine("Kullanıcı Soyadı:"+kullanıcı.Soyisim);
        Console.WriteLine("Kullanıcı Yaşı:"+kullanıcı.Yas);
    }
        
        yeniListe.Clear();
public class Kullanıcılar{



    private string isim;
    private string soyisim;
    private int yas;

    public string Isim { get{return isim;} set{ isim=value; } }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int Yas { get => yas; set => yas = value; }

}