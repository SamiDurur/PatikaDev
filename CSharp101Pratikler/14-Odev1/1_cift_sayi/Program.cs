//Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
Console.WriteLine("Girilecek Sayi Adetini Belirleyin");

long n;
long.TryParse(Console.ReadLine(),out n);

long[] dizi=new long [n];

Console.WriteLine("{0} Adet Pozitif Sayı Girin",n);
for (long i = 0; i < n; i++)
{
    Console.WriteLine("{0}. Sayıyı Gir",i+1);
    long.TryParse(Console.ReadLine(),out dizi[i]);
}
dizi.Yazdir();
public static class Extension
{
    public static void Yazdir(this long[] dizi)
    {
        Console.WriteLine("Girmiş olduğunuz sayılarda çift sayılar aşağıdakilerdir");
        foreach (long item in dizi)
        {
            if(item==0)
                Console.Write("Sayıyı 0 olarak girdiniz veya sayı girişi yapmadınız: ");
            if(item%2==0)
                Console.WriteLine(item);
        }
    }
}