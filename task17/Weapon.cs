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
      
        public Weapon(int range, float caliber, int maxSize)
        {
            ShootRange = range;
            Calibr = caliber;
            MaxAmmo = maxSize;
        }
        bool Shot()
        {
            if (CurrectAmmo <= 0)
            {
                CurrectAmmo--;
                return false;
                    }

            else
            {
                Console.WriteLine("Not enough  ammo!");
                return true;
            }
          
        }
        void Recharge()
        {
            CurrectAmmo = MaxAmmo;
        }
    }
}
