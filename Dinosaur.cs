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

        public void HeadbuttRobot(Robot chosenRobot)
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
        public void BiteRobot(Robot chosenRobot)
        {
            if (dinoEnergy > 0)
            {
                chosenRobot.roboHealth -= dinoAttackPower;
                dinoHealth += dinoAttackPower;
                dinoEnergy -= 50;
                Console.WriteLine("The dinosaur's attack was successful, " + chosenRobot.robotName + "'s health is now " + chosenRobot.roboHealth + ".");
                Console.WriteLine("The dinosaur gained health from the successful bite.");
            }
            else
            {
                Console.WriteLine("This dinosaur's energy is too low too attack, and must rest. Energy has been restored.");
                dinoEnergy = 100;
            }


        }
        public void ChargeRobot(Robot chosenRobot)
        {
            if (dinoEnergy > 0)
            {
                chosenRobot.roboHealth -= (2 * dinoAttackPower);
                dinoEnergy = 0;
                Console.WriteLine("The dinosaur's attack was successful, " + chosenRobot.robotName + "'s health is now " + chosenRobot.roboHealth + ".");
                Console.WriteLine("The dinosaur's charge drained its energy completely");
            }
            else
            {
                Console.WriteLine("This dinosaur's energy is too low too attack, and must rest. Energy has been restored.");
                dinoEnergy = 100;
            }


        }
        public void ChooseAttack(Robot chosenRobot)
        {
            Console.WriteLine("Choose your attack:");

            string[] attackArray = new string[3];
            attackArray[0] = "Base Attack = 1";
            attackArray[1] = "Bite = 2";
            attackArray[2] = "Charge = 3";
            foreach (string attack in attackArray)
            {
                Console.WriteLine(attack);
            }
            int chosenAttack = int.Parse(Console.ReadLine());

            if (chosenAttack == 1)
            {
                HeadbuttRobot(chosenRobot);
            }
            else if (chosenAttack == 2)
            {
                BiteRobot(chosenRobot);
            }
            else if (chosenAttack == 3)
            {
                ChargeRobot(chosenRobot);
            }
        }

       
    }
}
