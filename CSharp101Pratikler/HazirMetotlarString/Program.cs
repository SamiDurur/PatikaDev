// See https://aka.ms/new-console-template for more information

string degisken ="Dersimiz CSharp, Hoşgeldin";
string degisken2="dersimiz CSharp, Hoşgeldin";

//Length; dizide veya stringde uzunluğunu verir
Console.WriteLine(degisken.Length);

//ToUpper(); ToLower(); String içindekileri uppur büyük harf lower küçük harf olarak gösterir
Console.WriteLine(degisken.ToUpper());
Console.WriteLine(degisken.ToLower());

//Concat  String Concat yöntemi ile iki yada daha fazla string türündeki değerler birleştirilir.Tanımlanan degiskenin içerisinde bulunan ve " Merhaba"yazısı  birleştirilecektir.
Console.WriteLine(String.Concat(degisken," Merhaba"));

//Compare , CopareTo da 1. değişken 2. değişkene eşit olursa 0 döndürür - 1. değişken 2. değişkenden daha büyük bir karakter sayısına sahipse 1 döndürür - eğer 1.değişken 2. değişkenden daha küçük bir karakter sayısına sahipse -1 döndürür.
Console.WriteLine(degisken.CompareTo(degisken2));
//Compare //Sondaki true olursa Büyük küçük harf duyarsız olarak eşleştirme yapar,false yazılırsa büyük küçük harf duyarlı olur
Console.WriteLine(String.Compare(degisken,degisken2,true));
Console.WriteLine(String.Compare(degisken,degisken2,false));

//Contains değiken in içerisinde değisken2 varsa true dönecek
Console.WriteLine(degisken.Contains(degisken2));
Console.WriteLine(degisken.EndsWith("Hoşgeldin"));
Console.WriteLine(degisken.StartsWith("Dersimiz"));

//IndexOf İçinde varsa kaçıncı sırada olduğunu yoksa -1 olarak döner
Console.WriteLine(degisken.IndexOf("ersi"));
Console.WriteLine(degisken.IndexOf("Cs"));

//LastIndexOf baştan sona doğru arayarak son bulduğunun kaçıncı sırada olduğunu yazar
Console.WriteLine(degisken.LastIndexOf("i"));

//insert Değişken içine ekleme hangi satırdan başlayıp sonrasında ne eklemesi gerekiyorsa onu yazarak ekler
Console.WriteLine(degisken.Insert(0,"Merhaba "));

//PadLeft, PadRight karakter uzunluğunu sağ veya sola boşluk atarak yazılan rakama tamamlar (20 tana karakter varsa 30 yazdığın zaman 10 tane boşluk atar sağına veya soluna)
Console.WriteLine(degisken+degisken2.PadLeft(30));
//Boşluk yerine başka karakterde seçilebilir
Console.WriteLine(degisken.PadRight(40,'*')+degisken2);
Console.WriteLine(degisken+degisken2.PadLeft(30,'3'));
Console.WriteLine(degisken.PadRight(40,'_'));

//Remove yazdığın indexten başlayarak  geri kalanını siler ve yazılan indexten öncesini ekrana getirir
Console.WriteLine(degisken.Remove(20));
//aradan silme yapmak içinde başlama index ini ve kaç karakter silinecek 
Console.WriteLine(degisken.Remove(18,5));
//baştakini silme
Console.WriteLine(degisken.Remove(0,1));

//Replace değiştirme işlemi yapar  ilk değişecek değeri 2.de olmasını istediğin değer
Console.WriteLine(degisken.Replace("CSharp","C#"));
Console.WriteLine(degisken.Replace(" ","*"));

//Split Parçalayıp diziye atar.Boşluğuna göre  diziye atayıp 1. diziyi ekrana yazdırma
Console.WriteLine(degisken.Split(" ")[1]);
                                                                                                             //"Dersimiz CSharp, Hoşgeldin"
//Substring Verilen index ten başlayarak sonuna kadar getiriyor (aşağıda 4. indexten başlayıp sonuna kadar getirdi "imiz CSharp, Hoşgeldin")
Console.WriteLine(degisken.Substring(4));
//Aradaki veriyi gösterme - 4.indexten başla 5 karakter getir
Console.WriteLine(degisken.Substring(4,5));






