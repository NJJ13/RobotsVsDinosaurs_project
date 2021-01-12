using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Weapon
    {
        public string weaponType;
        public int attackPower;

        public Weapon (string weaponType, int weaponAttackPower)
        {
            this.weaponType = weaponType;
            this.attackPower = weaponAttackPower;
        }
        
    }
}
