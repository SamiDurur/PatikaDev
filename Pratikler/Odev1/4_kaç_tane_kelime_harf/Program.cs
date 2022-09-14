//Bir konsol uygulamasında kullanıcıdan bir cümle yazmasını isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
Console.WriteLine("Bir Cümle Yazın");

string cumle = Console.ReadLine();
cumle=cumle.Trim();
cumle.Yontem1Kelime();
cumle.Yontem2Kelime();
cumle.Harf();
public static class Extension
{
    public static void Yontem1Kelime(this string param)
    {
        int i=0;
        string[] kelime = param.Split(" ");
        foreach (string item in kelime)
        {
            if(!string.IsNullOrWhiteSpace(item))
            i++;
        }
        Console.WriteLine("{0} Adet kelime var",i);
    }
    public static void Yontem2Kelime(this string param)
    {   
        List<string> kelime = param.Split(' ').ToList();
        List<string> temiz= new List<string>();
        foreach (string item in kelime)
        {
            if(!string.IsNullOrWhiteSpace(item))
            temiz.Add(item);
        }
        Console.WriteLine("{0} Adet kelime var",temiz.Count);

    }
    
    public static void Harf(this string param)
    {
        string[] harf = param.Split(" ");
        string harfSayisi = string.Join("",harf);
        Console.WriteLine("{0} Adet harf var",harfSayisi.Length);
    }
}