using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_kalıtım
{
    public class Hayvanlar : Canlilar
    {
        public override void UyaranlaraTepki()
        {
            base.UyaranlaraTepki();
            Console.WriteLine("Hayvanlar temasa tepki verir");
        }
        public Hayvanlar()
        {
            base.Beslenme();
            base.Bosaltım();
            base.Solunum();
        }
        protected void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar adaptasyon kurabilir.");
        }
    }
    public class Sürüngenler : Hayvanlar
    {
        public Sürüngenler()
        {
            base.Adaptasyon();
            base.UyaranlaraTepki();
        }
        public void SürünerekHareketEderler()
        {
            Console.WriteLine("Sürüngenler sürünerek hareket ederler.");
        }
    }
    public class Kuslar : Hayvanlar
    {
        public Kuslar()
        {
            base.Adaptasyon();
            base.UyaranlaraTepki();
        }
        public void Ucmak()
        {
            Console.WriteLine("Kuşlar uçar.");
        }
    }

}
