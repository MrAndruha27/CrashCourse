using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть час в секундах:");
            int seconds = Convert.ToInt32(Console.ReadLine());
            int Minute=seconds/60;
            int hour=Minute/60;
            if (Minute >= 60)
                Minute %= 60;
            if (seconds >= 60)
                seconds %= 60;
            Console.Write("Час: "+hour+":"+Minute+":"+seconds);
        }
    }
}
