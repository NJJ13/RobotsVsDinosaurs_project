using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Dinosaur
    {
        string dinoType;
        int dinoHealth;
        int dinoEnergy;
        int attackPower;

        public Dinosaur(string dinoType, int dinoHealth, int dinoEnergy, int attackPower)
        {
            this.dinoType = dinoType;
            this.dinoHealth = dinoHealth;
            this.dinoEnergy = dinoEnergy;
            this.attackPower = attackPower;
        }

        public void AttackRobot()
        {

        }
    }
}
