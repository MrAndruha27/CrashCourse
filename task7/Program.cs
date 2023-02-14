using System;

namespace task7
{
    enum Wallets { USD = 1, EUR = 2, PLN = 3};

    class Program
    {
        static void Main(string[] args)
        {
            const double UAHtoUSD = 36.57;
            const double UAHtoEUR = 39.72;
            const double UAHtoPLN = 8.43;

            Console.Write("Введiть суму в UAH: ");
            double UAH = Convert.ToInt32(Console.ReadLine());
            Console.Write("Виберiть в яку валюту потрiбно конвертувати: \n" +
                                                                  "1 - USD \n" +
                                                                  "2 - EUR \n" +
                                                                  "3 - PLN \n");
            int choise = Convert.ToInt32(Console.ReadLine());
            switch (choise)
            {
                case (int)Wallets.USD:
                    Console.WriteLine($"{UAH} UAH = {UAHtoUSD/UAH} {Wallets.USD}");
                    break;
                case (int)Wallets.EUR:
                    Console.WriteLine($"{UAH} UAH = {UAHtoEUR / UAH} {Wallets.EUR}");
                    break;
                case (int)Wallets.PLN:
                    Console.WriteLine($"{UAH} UAH = {UAHtoPLN / UAH} {Wallets.PLN}");
                    break;
                default:
                    Console.WriteLine("Введено некоректне значення");
                    break;
            }

        }
    }
}
