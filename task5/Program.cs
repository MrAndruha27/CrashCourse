using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть рiк:");
            double year = Convert.ToDouble(Console.ReadLine());
            if (year % 400 == 0 ||year % 4 == 0 && year % 100 != 0) 
                    Console.Write("Кiлькiсть днiв: 366");
            else
                Console.Write("Кiлькiсть днiв: 365");

        }
    }
}
