//struct ta tanımlanan değerler default  değer atayamaz classta  int e 0  string e null değeri atar ama  struct atayamaz
Dikdortgen dikdortgen = new Dikdortgen();
dikdortgen.KisaKenar = 3;
dikdortgen.UzunKenar = 4;

Console.WriteLine("Class Alan Hesabı    :{0}", dikdortgen.Alanhesapla());
//Struct tanımlama şekilleri
Dikdortgen_Struct dikdortgen_Struct;
dikdortgen_Struct.KisaKenar= 3;
dikdortgen_Struct.UzunKenar = 4;
Console.WriteLine("Class Alan Hesabı    :{0}", dikdortgen_Struct.Alanhesapla());

Dikdortgen_Struct dikdortgen_Struct2=new(3,4);
Console.WriteLine("Class Alan Hesabı    :{0}", dikdortgen_Struct2.Alanhesapla());

Dikdortgen_Struct dikdortgen_Struct3 = new Dikdortgen_Struct(3, 4);
Console.WriteLine("Class Alan Hesabı    :{0}", dikdortgen_Struct3.Alanhesapla());



class Dikdortgen
{
    public int KisaKenar;
    public int UzunKenar;

    public Dikdortgen()
    {
        KisaKenar = 3;
        UzunKenar = 4;
    }

    
    public long Alanhesapla()
    {
        return KisaKenar * UzunKenar;
    }
}
struct Dikdortgen_Struct
{
    public int KisaKenar;
    public int UzunKenar;
    public Dikdortgen_Struct(int kisaKenar, int uzunKenar)
    {
        KisaKenar = kisaKenar;
        UzunKenar = uzunKenar;
    }
    public long Alanhesapla()
    {
        return KisaKenar * UzunKenar;
    }
}