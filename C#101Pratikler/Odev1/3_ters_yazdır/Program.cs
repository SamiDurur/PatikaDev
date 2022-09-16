//Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
Console.WriteLine("Pozitif Bir Sayı Girin");

long n;
long.TryParse(Console.ReadLine(),out n);

string[] dizi=new string [n];

Console.WriteLine("{0} Adet Kelime Girin",n);
for (long i = 0; i < n; i++)
{
    Console.WriteLine("{0}. Kelimeyi Gir",i+1);
    dizi[i]=Console.ReadLine();
}
Array.Reverse(dizi);
dizi.Yazdir();
public static class Extension
{
    public static void Yazdir(this string[] dizi)
    {
        Console.WriteLine("Girmiş olduğunuz kelimelerin ters sıralaması aşağıdaki gibidir");
        foreach (string item in dizi)
        {
            Console.WriteLine(item);
        }
    }
}