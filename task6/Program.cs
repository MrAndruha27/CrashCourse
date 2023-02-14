using System;

namespace task6
{ enum Days  {Monday = 1, Tuesday =2, Wednesday =3, Thursday =4, Friday =5, Saturday =6, Sunday =7};

class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть порядковий номер дня тижня: ");
            int choise=Convert.ToInt32(Console.ReadLine());
            switch (choise)
            {
                case (int)Days.Monday:
                    Console.WriteLine("Понедiлок");
                    break;
                case (int)Days.Tuesday:
                    Console.WriteLine("Вiвторок");
                    break;
                case (int)Days.Wednesday:
                    Console.WriteLine("Середа");
                    break;
                case (int)Days.Thursday:
                    Console.WriteLine("Четвер");
                    break;
                case (int)Days.Friday:
                    Console.WriteLine("П'ятниця");
                    break;
                case (int)Days.Saturday:
                    Console.WriteLine("Субота");
                    break;
                case (int)Days.Sunday:
                    Console.WriteLine("Неділя");
                    break;
                default:
                    Console.WriteLine("Введено некоректне значення");
                    break;


            }

        }
    }
}
