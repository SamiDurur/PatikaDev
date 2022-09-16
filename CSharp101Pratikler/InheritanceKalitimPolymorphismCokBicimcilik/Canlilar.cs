using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_kalıtım
{
    //public sealed class Canlilar - Sealed  anahtar kelimasi kalıtım yani inheritance ı ve Çok biçimcilik yani polymorphism in yapılmasını engeller
    public class Canlilar
    {
        protected void Beslenme()
        {
            Console.WriteLine("Canlılar beslenir");
        }
        protected void Solunum()
        {
            Console.WriteLine("Canlılar solunum yapar");
        }
        protected void Bosaltım()
        {
            Console.WriteLine("Canlılar boşaltım yapar");
        }
        public virtual void UyaranlaraTepki()
        {
            Console.WriteLine("Canlılar uyarılara tepki verir");
        }
        
    }

}
