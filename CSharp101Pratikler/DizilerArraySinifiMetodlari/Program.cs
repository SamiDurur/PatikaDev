using System;

namespace diziler_array_sinifi_metodlari
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort (küçükten büyüğe sıralar)
            int[] sayiDizisi={23,12,4,86,72,3,11,17};
            Console.WriteLine("******** Sırasız Dizi ********");
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);
            Console.WriteLine("******** Sıralı Dizi ********");
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);
            
            //Clear (indexin değerini silme)
            Console.WriteLine("********* Array Clear *******");
            // sayiDizisi elemanlaarını kullanarak 3.index ten itibaren 2 tane elemanı 0'lar.
            Array.Clear(sayiDizisi,3,2);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);
            
            //Reverse (diziyi Terse çevirme)
            Console.WriteLine("******** Array Reverse ******");
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);
            
            //IndexOf (aradığın değerin indexini veriyor)
            Console.WriteLine("******** Array IndexOf *********");
            Console.WriteLine(Array.IndexOf(sayiDizisi,23));

            //Resize (Yeniden Boyutlandırma yapar)
            Console.WriteLine("********* Array Resize *********");
            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8]=99;
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);


        }
    }
}
