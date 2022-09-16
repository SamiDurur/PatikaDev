//Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.
string cumle=Console.ReadLine();
string sesli = "aeoöuüıi";
List<char> sesliler = new List<char>();

for(int i=0;i<cumle.Length;i++)
{
    if (sesli.Contains(cumle[i])) 
    {
        sesliler.Add(cumle[i]); 
    }
    
}
Console.WriteLine("Sesli harfler");
foreach (var item in sesliler)
    Console.Write(item);

sesliler.Sort();
Console.WriteLine("Sıralı Sesli harfler");
foreach (var item in sesliler)
    Console.Write(item);
