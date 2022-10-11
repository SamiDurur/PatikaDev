using KolaySeviye;
using KolaySeviye.Algoritma;
using KolaySeviye.DaireCizme;
using KolaySeviye.OrtalamaHesaplama;

OrtalamaHesapla ortalamaHesaplama = new();
UcgenCizme ucgenCizme = new();
DaireCizme daireCizme = new();

while (true)
{
    Console.WriteLine("\n *******************************************");
    Console.WriteLine("                 ANA MENÜ");
    Console.WriteLine("  Lütfen yapmak istediğiniz işlemi seçiniz");
    Console.WriteLine(" *******************************************");
    Console.WriteLine(" (1) Ortalama Hesaplama");
    Console.WriteLine(" (2) Üçgen Çizme");
    Console.WriteLine(" (3) Daire Çizme");
    Console.WriteLine(" (4) Rehberi Listelemek");
    Console.WriteLine(" (5) Rehberde Arama Yapmak");
    Console.WriteLine(" (6) Uygulamayı Sonlandır");
    int a = 0;
    Int32.TryParse(Console.ReadLine(), out a);
    switch (a)
    {
        case 1:
            Console.Clear();
            ortalamaHesaplama.Derinlik();
            break;
        case 2:
            Console.Clear();
            ucgenCizme.Boyut();
            break;
        case 3:
            Console.Clear();
            daireCizme.YariCap();
            break;
        case 4:
            //Contacts.List();
            break;
        case 5:
            //Contacts.Search();
            break;
        case 6:
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine(" Geçersiz giriş");
            break;
    }
}