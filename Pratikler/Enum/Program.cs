//Uygulama geliştirirken sabit değerlerle çalışmak durumunda kalırız.
//Bu noktalarda okunabilirliği yüksek bir program yazmak istiyorsak enum'lardan faydalanırız.
//Sayısal verilerı string ifadelerle saklamanızı sağlar. Okunabilirliğe katkısı da tam olarak burdan gelir diyebiliriz.


Console.WriteLine(Gunler.Pazar);
Console.WriteLine((int)Gunler.Perşembe);
Console.WriteLine((int)Gunler.Cumartesi);

int sıcaklık = 32;

if (sıcaklık <= (int)HavaDurumu.Normal)
    Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekleyelim");
else if (sıcaklık >= (int)HavaDurumu.Sıcak)
    Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün");
else if (sıcaklık>=(int)HavaDurumu.Normal&&sıcaklık<(int)HavaDurumu.CokSıcak)
    Console.WriteLine("Hadi dışarıya çıkalım");
enum Gunler
{
    Pazartesi=1,
    Salı,
    Çarşamba,
    Perşembe,
    Cuma=20,
    Cumartesi,
    Pazar
}
enum HavaDurumu
{
    Soguk=5,
    Normal=20,
    Sıcak=27,
    CokSıcak=30,
}