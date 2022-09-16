using System;

namespace Hata_Yönetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exception Handling - Hata Yönetimi
            
            //Manuel olarak Hata Fırlatma throw
            int sayi1=-2;
            if(sayi1<0)
            throw new Exception("0 dan düşük değer girdin");
            else
            Console.WriteLine(sayi1);

            
            /*
            try{ Hataya sebebiyet verme ihtimali olan kod }
            catch { Hata ile karşılaşıldığında ne yapılacağı buraya yazılır }
            finally{ Hata olsun olmasın mutlaka yapılmasını istediğimiz işler varsa buraya yazarız }
            */
            try
            {
                Console.WriteLine("Bir Sayı Giriniz:");
                int sayi= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayi :"+sayi);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Hata : "+ ex.Message.ToString());


            }
            finally
            {
                Console.WriteLine("İşlem Tamamlandı");
            }
            try
            {
                int a=int.Parse(null);
                
            }
            catch (ArgumentNullException ex)//Boş değer gördüğü zaman vereceği hata
            {
                Console.WriteLine("Boş Değer Girdiniz.");
                Console.WriteLine(ex);                
            }
            catch (FormatException ex) // Veri tipi uygun verilmediğinde vereceği hata
            {
                Console.WriteLine("Veri Tipi Uygun değil");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex) //Verilen değer aralığın altında veya üstünde ise vereceği hata
            {
                Console.WriteLine("Değer Aralıkları dışında değer girildi(çok küçük veya çok büyük bir değer girdiniz)");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("a değerinini işlemi tamamlandı");
            }

            try
            {
               
                int b=int.Parse("Test");
                
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş Değer Girdiniz.");
                Console.WriteLine(ex);                
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Veri Tipi Uygun değil");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Değer Aralıkları dışında değer girildi(çok küçük veya çok büyük bir değer girdiniz)");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("b değerinini işlemi tamamlandı");
            }

            try
            {
                int c=int.Parse("-70000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş Değer Girdiniz.");
                Console.WriteLine(ex);                
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Veri Tipi Uygun değil");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Değer Aralıkları dışında değer girildi(çok küçük veya çok büyük bir değer girdiniz)");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("c değerinini işlemi tamamlandı");
            }
            
            
        }
    }
}
