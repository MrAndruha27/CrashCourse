using System;

namespace task12
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
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\nВиберiть опцiю: \n" +
                "1 - Обрахувати суму\n" +
                "2 - Вiдсортувати\n" +
                "3 - Знайти кiлькiсть парних значень\n" +
                "4 - Знайти максимальний елемент");
            int Suma = 0;
            int choise = Convert.ToInt32(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    for (int i = 0; i < 20; i++)
                    {
                        Suma += arr[i];
                    }
                    Console.WriteLine("Сума: " + Suma);
                    break;
                case 2:
                    Array.Sort(arr);
                    Console.Write("Масив: ");
                    for (int i = 0; i < 20; i++)
                    {
                        Console.Write(arr[i] + " ");
                    }
                    break;
                case 3:
                    
                    for (int i = 0; i < 20; i++)
                    {
                        if (arr[i] %2== 0)
                            Suma++;
                    }
                    Console.Write("Кiлькiсть парних: "+Suma);
                    break;
                case 4:
                    int max = 0;
                    for (int i = 0; i < 20; i++)
                    {
                        if (max < arr[i])
                            max = arr[i];
                    }
                    Console.Write("Максимальне: " + max);
                    break;




            }
        }
    }
}
