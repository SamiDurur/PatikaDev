//Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
Console.WriteLine("Girilecek Sayi Adetini Belirleyin");
long n;
long m;
long.TryParse(Console.ReadLine(),out n);
Console.WriteLine("Pozitif Bir Sayı Girin");
long.TryParse(Console.ReadLine(),out m);
long[] dizi=new long [n];

Console.WriteLine("{0} Adet Pozitif Sayı Girin",n);
for (long i = 0; i < n; i++)
{
    Console.WriteLine("{0}. Sayıyı Gir",i+1);
    long.TryParse(Console.ReadLine(),out dizi[i]);
}
dizi.Yazdir(m);
public static class Extension
{
public static void Yazdir(this long[] dizi,long m)
{
    Console.WriteLine("{0} Sayısına eşit veya tam bölünenler aşağıdadır",m);
    foreach (long item in dizi)
    {
        if(item==0)
            Console.Write("Sayıyı 0 olarak girdiniz veya sayı girişi yapmadınız: ");
        if(item%m==0||item==m)
            Console.WriteLine(item);
    }
}
}