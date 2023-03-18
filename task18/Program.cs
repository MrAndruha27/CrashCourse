using System;

namespace task18
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto car1 = new Auto(120,35000,30,true);
            car1.Info();
            car1.BuyFuel();
            car1.Info();
            car1.SetDiscount();
            car1.Info();
        }
    }
}
