using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть радiус кола:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Площа кола:"+(Math.Sqrt(a)*Math.PI));
        }
    }
}
