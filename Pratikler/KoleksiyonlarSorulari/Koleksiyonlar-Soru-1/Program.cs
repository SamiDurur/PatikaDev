//Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanarak yazınız.)

//Negatif ve numeric olmayan girişleri engelleyin.
//Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
//Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.

using System.Collections;

ArrayList asal = new ArrayList();
ArrayList asalOlmayan = new ArrayList();
for (int i = 0; i < 20; i++)
{
    uint sayi;
    if (uint.TryParse(Console.ReadLine(), out sayi))
    {
        int control = 0;
        for (int j = 2; j < sayi; j++)
            if (sayi % j == 0)
                control++;
        if (control != 0)
            asalOlmayan.Add(sayi);
        else
            asal.Add(sayi);
    }
    else
        Console.WriteLine("Negatif veya Numeric olmayan giriş yaptınız");
}
asal.Sort();
asalOlmayan.Sort();
asal.Reverse();
asalOlmayan.Reverse();
Console.WriteLine("Asal Sayılar");
foreach (var item in asal)
    Console.WriteLine(item);
Console.WriteLine("Asal Olmayan Sayılar");
foreach (var item in asalOlmayan)
    Console.WriteLine(item);
int asalOrt = 0;
int asalOlmayanOrt = 0;
for (int i = 0; i < asal.Count; i++)
{
    asalOrt += Convert.ToInt32(asal[i]);
}
for (int i = 0; i < asalOlmayan.Count; i++)
{
    asalOlmayanOrt += Convert.ToInt32(asalOlmayan[i]);
}

Console.WriteLine(" Asal sayı adeti = " + asal.Count + " Asal sayıların ortalaması = " + asalOrt / asal.Count);
Console.WriteLine(" Asal olmayan sayı adeti = " + asalOlmayan.Count + " Asal olmayan sayıların ortalaması = " + asalOlmayanOrt / asalOlmayan.Count);
