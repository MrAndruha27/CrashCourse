using System;

namespace task17
{
    class Program
    {
        static void Main(string[] args)
        {


            ///НЕДОРОБЛЕНО
            string Stone = "";
            int i = 0;
            while (i != 1)
            {
              
                Console.WriteLine("Введiть слово ");
                Stone += Console.ReadLine();
         //       Console.WriteLine(Stone.Substring(Stone.LastIndexOf('.') ), Stone.LastIndexOf('.')+1));
                if (Stone.Substring((0),1) == ".")
                {
                    i = 1;
                }
            }
            string[] words = Stone.Split(' ');
            for (int ii = 0; ii < words.Length; ii++)
            {
                Console.Write(words[i]+", ");
            }

        }
        }
    }

