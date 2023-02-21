using System;

namespace task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть символ: ");
           char charr = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введiть довжину лiнiї: ");
            int len = Convert.ToInt32(Console.ReadLine());
            while(len>0)
            {
                Console.Write(charr);
                len--;
            }

        }
    }
}
