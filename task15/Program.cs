using System;

namespace task15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть речення ");
            string Stone = Console.ReadLine();
            double low = 0;
           double high = 0;
          char [] arr=  Stone.ToCharArray();
            for(int i=0;i<arr.Length;i++)
            {
                if(Char.IsUpper(arr[i]))
                {
                    high++;
                }
                else if(Char.IsLower(arr[i]))
                {
                    low++;
                }
            }
            double stoPercent = low + high;
            Console.WriteLine("Кiлькiсть малих букв: "+low);
            Console.WriteLine("Кiлькiсть великих букв: " + high);
            Console.WriteLine("Вiдсоток малих букв: " + ((low*100)/stoPercent)+"%");
            Console.WriteLine("Вiдсоток малих букв: " + ((high * 100) / stoPercent)+"%");


        }
    }
}
