using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_kalıtım
{
    public class Bitkiler : Canlilar
    {
        public override void UyaranlaraTepki()
        {
            //base.UyaranlaraTepki(); Bu kodu yazmadığım zaman sadece  aşağıdaki yazıyı ekrana yazdırır
            Console.WriteLine("Bitkiler güneşe tepki verir");
        }
        public Bitkiler()
        {
            base.Beslenme();
            base.Bosaltım();
            base.Solunum();
        }

        protected void FotosentezYapmak()
        {
            Console.WriteLine("Bitkiler fotosentez yapar.");
        }
    }
    public class TohumluBitkiler : Bitkiler
    {
        public TohumluBitkiler()
        {
            base.FotosentezYapmak();
            base.UyaranlaraTepki();

        }
        public void TohumlaCogalma()
        {
            Console.WriteLine("Tohumlu bitkiler tohumla çoğalır.");
        }
    }
    public class TohumsuzBitkiler : Bitkiler
    {
        public TohumsuzBitkiler()
        {
            base.FotosentezYapmak();
            
        }
        public void SporlaCogalma()
        {
            Console.WriteLine("Tohumsuz bitkiler sporla çoğalır.");
        }
    }
}
