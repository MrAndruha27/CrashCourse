using System;

namespace task8
{
    enum Actions { R = 1, S = 2, P = 3 };

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введiть дiаметр: ");
            double D = Convert.ToInt32(Console.ReadLine());
            Console.Write("Виберiть потрiбну дiю: \n" +
                                                                  "1 - Знайти радiус \n" +
                                                                  "2 - Знайти площу \n" +
                                                                  "3 - Знайти периметр \n");
            int choise = Convert.ToInt32(Console.ReadLine());
            switch (choise)
            {
                case (int)Actions.R:
                    Console.WriteLine($"Радiус: {D/2}");
                    break;
                case (int)Actions.S:
                    Console.WriteLine($"Площа: {Math.PI*Math.Pow((D/2),2)}");
                    break;
                case (int)Actions.P:
                    Console.WriteLine($"Периметр: {2*Math.PI*D/2}");
                    break;
                default:
                    Console.WriteLine("Введено некоректне значення");
                    break;
            }

        }
    }
}
