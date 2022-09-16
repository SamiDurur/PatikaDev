using System;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            byte byte_min = 0;
            byte byte_max = 255;                                     //1 byte

            sbyte sbyte_min = -128;
            sbyte sbyte_max = 127;                                   //1 byte
            
            short short_min = -32768;
            short short_max = 32767;                                 //2 byte

            ushort ushort_min = 0;
            ushort ushort_max = 65535;                               //2 byte

            Int16 int16_min = -32768;
            Int16 int16_max = 32767;                                 //2 byte

            int int_min = -2147483647;
            int int_max = 2147483647;                                //4 byte
            
            Int32 int32_min = -2147483647;
            Int32 int32_max = 2147483647;                            //4 byte
            
            Int64 int64_min = -9223372036854775808;
            Int64 int64_max = 9223372036854775807;                   //8 byte
            
            uint uint_min = 0;
            uint uint_max = 4294967295;                             //4 byte

            long long_min = -9223372036854775808;
            long long_max = 9223372036854775807;                    //8 byte
            
            ulong ulong_min = 0;
            ulong ulong_max = 18446744073709551615;                 //8 byte

            float float1 = 5; 
            float float2 = 5.5f;                                   //4 byte
            
            double double1= 5;
            double double2= 5.533;                                 //8 byte

            decimal decimal1 = 5;
            decimal decimal2 = 5.525m;                             //16 byte

            //char tek karakter içerir. Tüm unicode karateri içerir
            char char1 = 'a';                                      //2 byte

            string string1 = "Sami";                               //sınırsız

            bool bool1 = true;
            bool bool2 = false;

            //Tarihi ve saati tutmak için kullanılır
            DateTime dt = DateTime.Now;

            //Tüm değer tipleri objecte yazılabilir
            
            object object1 = "sami";
            object object2 = 's';
            object object3 = 16;
            object object4 = 88.14;

            string string2 = string.Empty;
            string2 = "Abdullah Sami DURUR";
            string ad = "Abdullah Sami";
            string soyad = "DURUR";
            string adSoyad = ad + " " + soyad;
            Console.WriteLine(adSoyad);

            int sayi1 = 2;
            int sayi2 = 7;
            int carp = sayi1*sayi2;
            Console.WriteLine(carp);

            bool bool3 = 10 < 2;

            string string3 = "20";
            int int1 = 20;
            string yeniDeger = string3 + int1.ToString();
            Console.WriteLine(yeniDeger);

            int int2 = int1 + Convert.ToInt32(string3);
            Console.WriteLine(int2);

            int int3 = int1 + int.Parse(string3);
            Console.WriteLine(int3);

            //Tarihi gün ay yıl aralarında nokta olarak gösterir
            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);
            
            /*Tarihi gün ay yıl aralarında slash olarak gösterir.Eğer sistem tarihinde biçimde 
            aralarında nokta varsa debug yaptığında yazılan kodda slash atılmış olsa bile nokta atar */
            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            //Tarihi gün ay yıl aralarında slash ve saat dakika saniye aralarında iki nokta olarak gösterir
            string datetime3 = DateTime.Now.ToString("dd,MM,yyyy  HH:mm:ss");
            Console.WriteLine(datetime3);

            //Saat dakika aralarında iki nokta olarak gösterir
            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);
        }
    }
}
