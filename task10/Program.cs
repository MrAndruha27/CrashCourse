using System;

namespace task10
{
    class Program
    {
        static void Main(string[] args)
        {
            int attemps = 0;
            int answer = 0;
            Random r = new Random();
            int num = r.Next(1, 11);
            Console.WriteLine("Програма загадала число вiд 1 до 10, спробуйте вгадати це число");
            while (answer != num)
            {
                answer = Convert.ToInt32(Console.ReadLine());
                if (answer != num)
                    Console.WriteLine("Невiрно");
                attemps++;
            }
            Console.WriteLine("Ви вгадали число! Кiлькiсть спроб: " + attemps);

        }
    }
}
