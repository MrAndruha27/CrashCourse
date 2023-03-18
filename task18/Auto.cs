using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task18
{
    class Auto
    {
        private const int Wheels=4;
        private readonly int MaxSpeed;
        private double Price;
        private readonly double MaxFluel;
        private  double CurrectFluel;
        private bool Avalible;
        private double? AvgPrice;

       public Auto(int maxSpeed,double price, double maxFluel, bool avalible)
        {
            if (maxSpeed < 0)
                MaxSpeed = 0;
            else
            MaxSpeed = maxSpeed;

            if (price < 0)
                Price = 0;
            else
                Price = price;

            if (maxFluel < 0)
                MaxFluel = 0;
            else
                MaxFluel = maxFluel;
            Avalible = avalible;
        }
      public  Auto(int maxSpeed, double price, double maxFluel,double currfluel, bool avalible)
        {
            if (maxSpeed < 0)
                MaxSpeed = 0;
            else
                MaxSpeed = maxSpeed;

            if (price < 0)
                Price = 0;
            else
                Price = price;

            if (maxFluel < 0)
                MaxFluel = 0;
            else
                MaxFluel = maxFluel;

            if (currfluel < 0)
                CurrectFluel = 0;
            else
                CurrectFluel = currfluel;
            Avalible = avalible;
        }
        public void Info()
            {
            Console.WriteLine($"Max speed: {MaxSpeed}\nPrice: {Price}\nCurrect fluel: {CurrectFluel}\nMax fluel: {MaxFluel}\nAvalible: {Avalible}\n");
        }
        public void BuyFuel()
            {
            CurrectFluel=MaxFluel;
        }
        public void SetDiscount()
        {
            Price = Price - (Price / 30);
        }
    }
}
