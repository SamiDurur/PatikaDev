using System;
using System.Collections;

//system.collections namepace
//Varsayılan boyutu başlangıç olarak 4'tür. Aşıldığından otomatik olarak 2 katına çıkarılır.
//Yani bir array liste 5. elemanı eklemeye calıştıgınızda atka planda boyutunun 8'e çıkarır.
//Diğer liste türlerinden farkı tüm değer türlerini içinde barındırabiliyor olması

ArrayList list = new ArrayList();
list.Add("sami");
list.Add(5);
list.Add(true);
list.Add("Sa");
list.Add('b');

//verilere erişim 

Console.WriteLine(list[1]);

foreach (var i in list)
    Console.WriteLine(i);

//AddRange diğer listeleri veya farklı liste türündekileri içine dahil etmeyi sağlar

Console.WriteLine("**-** AddRange **-**");

string[] renkler = new string[] { "sarı", "mavi", "mor" };
List<int> sayilar = new List<int>() { 77, 33, 51, 24, 667, 2, 33, 1, 54 };
list.AddRange(renkler);
list.AddRange(sayilar);

foreach (var item in list)
    Console.WriteLine(item);

//clear Listeyi temizleme

Console.WriteLine("**-** clear **-**");

list.Clear();

list.AddRange(sayilar);

//Sort
//Sıralama yapılabilmesi için tüm değerlerin aynı türde olması lazım charsa hepsi char intse hepsi int stringse hepsi string
//değerler farklı türdeyse işlemi durdurur hata verir 

Console.WriteLine("**-** Sort **-**");

list.Sort();

foreach (var item in list)
    Console.WriteLine(item);

//BinarySearch aradığın şeyin index ini verir

Console.WriteLine("**-** Binary Search **-**");

//değerler farklı türdeyse işlemi durdurur hata verir 
Console.WriteLine(list.BinarySearch(1));

//Reverse Listeyi ters çevirme
Console.WriteLine("**-** Reverse **-**");

list.Reverse();

foreach (var item in list)
    Console.WriteLine(item);
//--------------------------------------------------
Console.WriteLine("---------- Deneme ---------");

Console.WriteLine("**-** string **-**");

list.Clear();
list.AddRange(renkler);
list.Sort();
foreach (var item in list)
    Console.WriteLine(item);
Console.WriteLine(list.BinarySearch("sarı"));

Console.WriteLine("**-** char **-**");
list.Clear();
char[] car = new char[] { 'd', 'b', 'c', 'a' };
list.AddRange(car);
list.Sort();
foreach (var item in list)
    Console.WriteLine(item);
Console.WriteLine(list.BinarySearch('d'));