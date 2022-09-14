//system.collection.generic
//Liste türüdür.
//her elemanı  key (anahtar) ve value (değer) olarak kaydeder

//Key ler her elemanda uniq(tek) olması gerekiyor

Dictionary<int, string> kullanıcılar = new Dictionary<int, string>();
kullanıcılar.Add(11, "Sami DURUR");
kullanıcılar.Add(12, "Umit");
kullanıcılar.Add(13, "Ramazan");
kullanıcılar.Add(33, "Omer");
kullanıcılar.Add(34, "Burcu");

//dizinin elemanlarına erişim

Console.WriteLine("**-** Elemanlara Erişim **-**");
Console.WriteLine(kullanıcılar[12]);

foreach (var item in kullanıcılar)
    Console.WriteLine(item);

//Count - Kaç elemandan oluşur
Console.WriteLine("**-** Count **-**");

Console.WriteLine(kullanıcılar.Count);

//Contains - Bu elemandan  listede varmı
Console.WriteLine("**-** Contains **-**");

Console.WriteLine(kullanıcılar.ContainsKey(11));
Console.WriteLine(kullanıcılar.ContainsValue("Vural"));

//Remove - Silme
Console.WriteLine("**-** Remove **-**");

kullanıcılar.Remove(12);

foreach (var item in kullanıcılar)
{
    Console.WriteLine(item);
    Console.WriteLine(item.Key);
    Console.WriteLine(item.Value);
}


//Keys
Console.WriteLine("**-** Keys **-**");
foreach (var item in kullanıcılar.Keys)
    Console.WriteLine(item);


//values
Console.WriteLine("**-** Values **-**");
foreach (var item in kullanıcılar.Values)
    Console.WriteLine(item);
