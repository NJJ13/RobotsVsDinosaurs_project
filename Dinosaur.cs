using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Dinosaur
    {
        public string dinoType;
        public int dinoHealth;
        public int dinoEnergy;
        public int dinoAttackPower;

        public Dinosaur(string dinoType, int dinoHealth, int dinoEnergy, int attackPower)
        {
            this.dinoType = dinoType;
            this.dinoHealth = dinoHealth;
            this.dinoEnergy = dinoEnergy;
            this.dinoAttackPower = attackPower;
        }

        public void AttackRobot(Robot chosenRobot)
        {
            chosenRobot.roboHealth -= dinoAttackPower;
            
        }
    }
}
