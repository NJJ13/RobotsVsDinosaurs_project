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
            if(dinoEnergy > 0)
            {
                chosenRobot.roboHealth -= dinoAttackPower;
                dinoEnergy -= 10;
                Console.WriteLine("The dinosaur's attack was successful, " + chosenRobot.robotName + "'s health is now " + chosenRobot.roboHealth + ".");
            }
            else
            {
                Console.WriteLine("This dinosaur's energy is too low too attack, and must rest. Energy has been restored.");
                dinoEnergy = 100;
            }
            
        }
    }
}
