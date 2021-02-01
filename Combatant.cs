using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Combatant
    {
        public string name;
        public int health;
        public int energy;
        public int attackPower;
        
        
        public virtual void Attack(Combatant combatant)
        {

        }
    }
}
