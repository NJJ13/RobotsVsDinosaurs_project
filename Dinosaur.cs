using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Dinosaur : Combatant
    {
        string[] attackArray = new string[3];
                

        public Dinosaur(string dinoType, int dinoHealth, int dinoEnergy, int attackPower)
        {
            this.name = dinoType;
            this.health = dinoHealth;
            this.energy = dinoEnergy;
            this.attackPower = attackPower;
            attackArray[0] = "Base Attack = 1";
            attackArray[1] = "Bite = 2";
            attackArray[2] = "Charge = 3";
        }

        public void HeadbuttRobot(Combatant combatant)
        {
            if(energy > 0)
            {
                combatant.health -= attackPower;
                energy -= 10;
                Console.WriteLine("The dinosaur's attack was successful, " + combatant.name + "'s health is now " + combatant.health + ".");
            }
            else
            {
                Console.WriteLine("This dinosaur's energy is too low too attack, and must rest. Energy has been restored.");
                energy = 50;
            }
            

        }
        public void BiteRobot(Combatant combatant)
        {
            if (energy > 0)
            {
                combatant.health -= attackPower;
                health += attackPower;
                energy -= 50;
                Console.WriteLine("The dinosaur's attack was successful, " + combatant.name + "'s health is now " + combatant.health + ".");
                Console.WriteLine("The dinosaur gained health from the successful bite.");
            }
            else
            {
                Console.WriteLine("This dinosaur's energy is too low too attack, and must rest. Energy has been restored.");
                energy = 50;
            }


        }
        public void ChargeRobot(Combatant combatant)
        {
            if (energy > 0)
            {
                combatant.health -= (2 * attackPower);
                energy = 0;
                Console.WriteLine("The dinosaur's attack was successful, " + combatant.name + "'s health is now " + combatant.health + ".");
                Console.WriteLine("The dinosaur's charge drained its energy completely");
            }
            else
            {
                Console.WriteLine("This dinosaur's energy is too low too attack, and must rest. Energy has been restored.");
                energy = 50;
            }


        }
        public void Attack(Combatant combatant)
        {
            Console.WriteLine("Choose your attack:");
            foreach (string attack in attackArray)
            {
                Console.WriteLine(attack);
            }
            int chosenAttack = int.Parse(Console.ReadLine());
            if (chosenAttack == 1)
            {
                HeadbuttRobot(combatant);
            }
            else if (chosenAttack == 2)
            {
                BiteRobot(combatant);
            }
            else if (chosenAttack == 3)
            {
                ChargeRobot(combatant);
            }
        }

       
    }
}
