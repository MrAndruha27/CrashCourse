using System;

namespace task17
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon pm = new Weapon(20, 9.19, 12);
            pm.Shoot();

            pm.Shoot();
            pm.Recharge();
            Weapon m4 = new Weapon(-60, -5.59, 30);
            m4.Shoot();

            m4.Shoot();
            m4.Recharge();
            m4.Info();
        }
    }
    }

