        // See https://aka.ms/new-console-template for more information
        int result=1;
        for(int i= 1;i<=4;i++)
            result=result*3;
        Console.WriteLine(result);
        //Recursive - öz yinelemeli metotlar
        //3^4
        Islemler intence=new();
            Console.WriteLine(intence.Expo(3,4));
        

        //Extension Metotlar Genişletilebilir Metotlar
        string ifade="Abdullah Sami DURUR";
        Console.WriteLine(ifade);

        bool sonuc=ifade.BoslukKontrol();
        Console.WriteLine(sonuc);
        //veya
        ifade.BoslukKontrol().Yazdir();
        
        if(sonuc)
            Console.WriteLine(ifade.BoslukSil());
        
        Console.WriteLine(ifade.Büyüt());
        
        Console.WriteLine(ifade.Kücült());

        int[] dizi1 ={1,10,5,22,3,55,1,3};
        
        dizi1.DiziYazdir();
        
        dizi1.Sirala();
        
        dizi1.DiziYazdir();

        int sayi=5;
        int sayi2=10;
        bool cift=sayi.Cift();
        
        sayi.Yazdir();
        
        cift.Yazdir();
        
        ifade.IlkKarakter().Yazdir();
        
        //Extension ile arasındaki fark ilk satır extension
        sayi.Yazdir(sayi2);
        Extension.Yazdir(sayi,sayi2);
        

public class Islemler{
    public int Expo(int sayi, int üs)
    {
        if(üs<2)
            return sayi;
        return Expo(sayi,üs-1)*sayi;
    //Expo(3,4)
    //Expo(3,3)*3;
    //Expo(3,2)*3*3;
    //Expo(3,1)*3*3*3;
    //  3*3*3*3=3^4;
    }
}
public static class Extension{
    
    public static bool BoslukKontrol(this string param)
    {   //Dize içinde Olup Olmadığını kontrol eder
        return param.Contains(" ");
    }
    public static string BoslukSil(this string param)
    {   
        //Split komutu string teki karakterleri aşağıda her boşluk gördüğünde dizide bir öğe olarak almak için kullanılıyor
        string[]dizi=param.Split(" ");
        //Her öğe veya üye arasında belirtilen ayırıcıyı kullanarak belirtilen dizinin veya koleksiyonun üyelerini birleştirir.
        return string.Join("_",dizi);

    }
    public static string Büyüt(this string param)
    {   //ToUpper Harfleri Büyütmek için
        return param.ToUpper();
    }
    public static string Kücült(this string param)
    {   //ToLower Harfleri küçültmek için
        return param.ToLower();
    }
    public static int[] Sirala(this int[] param)
    {
        Array.Sort(param);
        return param;
    }
    public static void DiziYazdir(this int[] param)
    {
        Console.WriteLine("********************************");
        foreach (int item in param)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("********************************");
    }
    public static bool Cift(this int param)
    {
        return param%2==0;
    }
    public static string IlkKarakter(this string param)
    {
        //Substring() string içindeki karakterlerden istediklerini yazdırmak için kullanılır
        //ilk yazılan  sayı nerden başladığı 2. yazılanda başladığı yerden itibaren kaç karakter yazacağı
        return param.Substring(0,2);
    }
    public static void Yazdir(this int param)
    {
        Console.WriteLine(param);
    }
    public static void Yazdir(this string param)
    {
        Console.WriteLine(param);
    }
    public static void Yazdir(this bool param)
    {
        Console.WriteLine(param);
    }
    public static void Yazdir(this int param,int param2)
    {
        Console.WriteLine(param+param2);
    }
}