using System;

namespace task16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть словосполучення ");
            string Stone = Console.ReadLine();
            string[] words = Stone.Split(' ');
           
            for (int i = 0; i < words.Length; i++)
            {
                Console.Write(words[i].ToUpper().Substring(0,1));
            }
          
        }
    }
}
