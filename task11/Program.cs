using System;

namespace task11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];
            Random r = new Random();
            for (int i = 0; i < 20; i++)
            {
                arr[i] = r.Next(1, 10);
            }
            Console.Write("Масив: ");
            for (int i = 0; i < 20; i++)
            {
                Console.Write(arr[i]+" ");
            }
        }
    }
}
