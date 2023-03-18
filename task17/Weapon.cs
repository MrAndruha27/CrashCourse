using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task17
{
    class Weapon
    {

       readonly double ShootRange;
       readonly double Calibr;

        int CurrectAmmo { get; set; }

        int MaxAmmo { get; set; }
      
        public Weapon(int range, double caliber, int maxSize)
        {
            if (range < 0)
                ShootRange = 0;
            else
                ShootRange = range;
            if (caliber < 0)
                Calibr = 0;
            else
                Calibr = caliber;
            if (maxSize < 0)
                MaxAmmo = 0;
            else
                MaxAmmo = maxSize;
        }
      public  bool Shoot()
        {
            if (CurrectAmmo <= 0)
            {
                Console.WriteLine("babah!");
                CurrectAmmo--;
                return false;
                    }

            else
            {
                Console.WriteLine("Not enough  ammo!");
                return true;
            }
          
        }
        public void Info()
            {
            Console.WriteLine("Range: "+ShootRange+"\nCalibr: "+Calibr+" \nMax ammo: "+MaxAmmo+" \nCurrect Ammo: "+CurrectAmmo);

        }
     public   void Recharge()
        {
            CurrectAmmo = MaxAmmo;
        }
    }
}
