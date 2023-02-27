using System;

namespace task13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть речення ");
            string Stone = Console.ReadLine();
            
            string[] words = Stone.Split(' ');
            Array.Reverse(words);
           for(int i=0;i<words.Length;i++)
            {
                Console.Write(words[i]+" ");
            }
        }
    }
}
