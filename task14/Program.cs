using System;

namespace task14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть речення ");
            string Stone = Console.ReadLine();
            int spaces = 0;
            string[] words = Stone.Split(' ');
           
            foreach (var word in words)
            {
                spaces++;
            }
            Console.WriteLine("Кiлькiсть пробiлiв: "+(spaces-1));   
        }
    }
}
