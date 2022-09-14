// See https://aka.ms/new-console-template for more information
// Now  kodunun yerine tablodan çekilen datetime veya ekrandan çekilen datetime kullanılabilir 
Console.WriteLine(DateTime.Now);// şuanın tarihini ve saatini getirir 9.06.2022 15:54:49
Console.WriteLine(DateTime.Now.Date);//saat tarafını 00:00:00 olarak  görüp tarihi getiriyor 9.06.2022 00:00:00
Console.WriteLine(DateTime.Now.Day);//günü getirir 9
Console.WriteLine(DateTime.Now.Month);//ayı getirir 6
Console.WriteLine(DateTime.Now.Year);//yılı getirir 2022
Console.WriteLine(DateTime.Now.Hour);//saati getirir 15
Console.WriteLine(DateTime.Now.Minute);//dakikayı getirir 54
Console.WriteLine(DateTime.Now.Second);//saniyeyi getirir 49

Console.WriteLine(DateTime.Now.DayOfWeek);//Haftanın hangi gününde olduğunu getirir wednesday thursday gibi
Console.WriteLine(DateTime.Now.DayOfYear);//yılın hangi gününde olduğunu getirir

Console.WriteLine(DateTime.Now.ToLongDateString());//9 haziran 2022 Perşembe
Console.WriteLine(DateTime.Now.ToShortDateString());//9.06.2022

Console.WriteLine(DateTime.Now.ToLongTimeString());//15:54:49  saat dakika saniye
Console.WriteLine(DateTime.Now.ToShortTimeString());//15:54 saat dakika

Console.WriteLine(DateTime.Now.AddDays(2));//2 gün ekledi
Console.WriteLine(DateTime.Now.AddHours(3));//3 saat ekledi
Console.WriteLine(DateTime.Now.AddSeconds(30));//30 saniye ekledi
Console.WriteLine(DateTime.Now.AddMonths(3));//3 ay ekledi
Console.WriteLine(DateTime.Now.AddYears(1));//1 yık ekledi
Console.WriteLine(DateTime.Now.AddMilliseconds(50));//50 milisaniye ekledi

//DateTime Format 
//gün
Console.WriteLine(DateTime.Now.ToString("dd"));//09 Gösterir
Console.WriteLine(DateTime.Now.ToString("ddd"));//Per Gösterir
Console.WriteLine(DateTime.Now.ToString("dddd"));//Perşembe Gösterir
//ay
Console.WriteLine(DateTime.Now.ToString("MM"));//06 Gösterir
Console.WriteLine(DateTime.Now.ToString("MMM"));//Haz Gösterir
Console.WriteLine(DateTime.Now.ToString("MMMM"));//Haziran Gösterir
//yıl
Console.WriteLine(DateTime.Now.ToString("yy"));//22 Gösterir
Console.WriteLine(DateTime.Now.ToString("yyyy"));//2022 Gösterir

Console.WriteLine("******Math Kütüphanesi*****");
//Math Kütüphanesi

Console.WriteLine(Math.Abs(-25)); //25 - Mutlak halini ekrana yazdırır
Console.WriteLine(Math.Sin(10)); // Belirtilen açının sinüsünü döndürür.
Console.WriteLine(Math.Cos(10)); // Belirtilen açının kosinüsünü döndürür.
Console.WriteLine(Math.Tan(10)); // Belirtilen açının tanjantını döndürür.

Console.WriteLine(Math.Ceiling(22.3));//23 herzaman üstteki sayıya yuvarlar
Console.WriteLine(Math.Round(22.3));//22 Enyakın sayıya yuvarlar 2.5 se 2 ye 2.6 ise 3 yuvarlar
Console.WriteLine(Math.Round(22.6));//23
Console.WriteLine(Math.Floor(22.7));//22 herzaman alttaki sayıya yuvarlar

Console.WriteLine(Math.Min(22,3));//Küçük sayıyı ekrana getirir
Console.WriteLine(Math.Max(22,3));//Büyük sayıyı ekrana getirir

Console.WriteLine(Math.Pow(3,4));//3^4=81 - üç üzeri 4 işlemini yapıp ekrana getirir
Console.WriteLine(Math.Sqrt(9));// 3 Sayının karekökünü ekrana getirir
Console.WriteLine(Math.Log(9));// 9 un e tabanındaki logaritmik karşılığını ekranan getirir
Console.WriteLine(Math.Exp(3));// e üzeri 3 ü verir
Console.WriteLine(Math.Log10(10));//10 sayısının logaritma 10 karşılığını verir