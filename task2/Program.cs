using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть ширину прямокутника:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введiть довжину прямокутника:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Площа прямокутника:"+(a*b)+"\nПериметр прямокутника: "+((a*2)+(b*2)));
        }
    }
}
