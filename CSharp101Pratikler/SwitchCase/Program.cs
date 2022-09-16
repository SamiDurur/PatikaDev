using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month=DateTime.Now.Month;
            //expression Kontrol etmek istediğimiz Koşul
            switch (month)
            {
                case 1:
                Console.WriteLine("You are in January");
                break;
                case 2:
                Console.WriteLine("You are in February");
                break;
                case 3:
                Console.WriteLine("You are in March");
                break;
                case 5:
                Console.WriteLine("You are in May");
                break;
                case 4:
                Console.WriteLine("You are in April");
                break;
                case 6:
                Console.WriteLine("You are in June");
                break;
                case 7:
                Console.WriteLine("You are in July");
                break;
                case 8:
                Console.WriteLine("You are in August");
                break;
                case 9:
                Console.WriteLine("You are in September");
                break;
                case 10:
                Console.WriteLine("You are in October");
                break;
                case 11:
                Console.WriteLine("You are in November");
                break;
                case 12:
                Console.WriteLine("You are in December");
                break;

                default:
                Console.WriteLine("Wrong Entry");
                break;
            }
            switch (month)
            {
                case 1 : case 2: case 3 :
                Console.WriteLine("You are in 1st Quarter");
                break;
                case 4 : case 5: case 6 :
                Console.WriteLine("You are in 2nd Quarter");
                break;
                case 7 : case 8: case 9 :
                Console.WriteLine("You are in 3rd Quarter");
                break;
                case 10 : case 12: case 11 :
                Console.WriteLine("You are in 4th Quarter");
                break;
                default:
                Console.WriteLine("Wrong Entry");
                break;
            }
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                Console.WriteLine("You are in Winter");
                break;
                case 3:
                case 4:
                case 5:
                Console.WriteLine("You are in Spring");
                break;
                case 8:
                case 7:
                case 6:
                Console.WriteLine("You are in Summer");
                break;
                case 9:
                case 10:
                case 11:
                Console.WriteLine("You are in Autumn Fall");
                break;
                default:
                Console.WriteLine("Wrong Entry");
                break;
            }
        }
    }
}
