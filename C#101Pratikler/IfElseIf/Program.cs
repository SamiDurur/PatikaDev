using System;

namespace if_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int time=DateTime.Now.Hour;

            //İf-else if

            if(time>=6&&time<11)
                Console.WriteLine("Good Morning!");
            else if(time>=11&&time<=18)
                Console.WriteLine("Good Day");
            else if(time>18&&time<=23)
                Console.WriteLine("Good Evening");
            else
                Console.WriteLine("Goodnight");

            //Ternary if

            string sonuc=time<=18 ? "Good Day":"Good Evening";
            Console.WriteLine(sonuc);

            /*************************************/

            Console.WriteLine(time<=18 ? "Good Day":"Good Evening");

            /****************************************/

            string sonuc2=time>=6&&time<11 ? "Good Morning!":time>=11&&time<=18 ? "Good Day":time>18&&time<=23 ? "Good Evening":"Goodnight";
            Console.WriteLine(sonuc2);

            /*************************************/

            Console.WriteLine
            (time>=6&&time<11 ? "Good Morning!":time>=11&&time<=18 ? "Good Day":time>18&&time<=23 ? "Good Evening":"Goodnight");
        
        }
    }
}
