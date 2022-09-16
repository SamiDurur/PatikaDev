//Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan,
//her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız.
//(Array sınıfını kullanarak yazınız.)
int[] sayilar = new int[20];
for (int i = 0; i < 20; i++)
{
    sayilar[i] = Convert.ToInt32(Console.ReadLine());
}
Array.Sort(sayilar);
int enKucukOrt = (sayilar[0] + sayilar[1] + sayilar[2]) / 3;
Console.WriteLine("En küçük 3 sayı = " + sayilar[0] +", "+ sayilar[1] + ", " + sayilar[2]);
Array.Reverse(sayilar);
Console.WriteLine("En büyük 3 sayı = " + sayilar[0] + ", " + sayilar[1] + ", " + sayilar[2]);
int enBuyukOrt = (sayilar[0] + sayilar[1] + sayilar[2]) / 3;

Console.WriteLine("En küçük 3 tane sayının ortalaması = " + enKucukOrt);
Console.WriteLine("En büyük 3 tane sayının ortalaması = " + enBuyukOrt);
Console.WriteLine("En küçük 3 ve en büyük 3 tane sayının ortalamalarının toplamı = " + (enBuyukOrt + enKucukOrt));