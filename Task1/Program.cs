using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ведiть дату:");
            string day = Console.ReadLine();
            Console.Write("Ведiть мiсяць:");
            string month = Console.ReadLine();
            Console.Write("Ведiть рiк:");
            string year = Console.ReadLine();
            Console.Write("Повна дата: "+day+":"+month+":"+year);
        }
    }
}
