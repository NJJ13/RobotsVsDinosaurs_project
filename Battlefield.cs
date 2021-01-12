using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Battlefield
    {
        public Herd dinoArmy;
        public Fleet roboArmy;
        Random selector;

        public Battlefield()
        {
            dinoArmy = new Herd();
            dinoArmy.PopulateHerd();
            roboArmy = new Fleet();
            roboArmy.PopulateFleet();
            selector = new Random();

        }

        public int CombatSelector(int target)
        {
            return selector.Next(target);
        }
        
        public void BattleFieldChecker()
        {
            if (dinoArmy.dinoArmy.Count >= 1 && dinoArmy.dinoArmy[0].dinoHealth <= 0)
            {
                Console.WriteLine(dinoArmy.dinoArmy[0].dinoType + " has been defeated.");
                dinoArmy.dinoArmy.RemoveAt(0);
            }
            else if (dinoArmy.dinoArmy.Count >= 2 && dinoArmy.dinoArmy[1].dinoHealth <= 0)
            {
                Console.WriteLine(dinoArmy.dinoArmy[1].dinoType + " has been defeated.");
                dinoArmy.dinoArmy.RemoveAt(1);
            }
            else if (dinoArmy.dinoArmy.Count >= 3 && dinoArmy.dinoArmy[2].dinoHealth <= 0)
            {
                Console.WriteLine(dinoArmy.dinoArmy[2].dinoType + " has been defeated.");
                dinoArmy.dinoArmy.RemoveAt(2);
            }
            else if (roboArmy.roboArmy.Count >= 1 && roboArmy.roboArmy[0].roboHealth <= 0)
            {
                Console.WriteLine(roboArmy.roboArmy[0].robotName + " has been defeated.");
                roboArmy.roboArmy.RemoveAt(0);
            }
            else if (roboArmy.roboArmy.Count >= 2 && roboArmy.roboArmy[1].roboHealth <= 0)
            {
                Console.WriteLine(roboArmy.roboArmy[1].robotName + " has been defeated.");
                roboArmy.roboArmy.RemoveAt(1);
            }
            else if (roboArmy.roboArmy.Count >= 3 && roboArmy.roboArmy[2].roboHealth <= 0)
            {
                Console.WriteLine(roboArmy.roboArmy[2].robotName + " has been defeated.");
                roboArmy.roboArmy.RemoveAt(2);
            }
        }
        public void Clash()
        {
            Console.WriteLine("The battle is now underway.");
            

            do
            {
                int robotSelector = roboArmy.roboArmy.Count;
                int dinoSelector = dinoArmy.dinoArmy.Count;
                
                int roboAttacker = CombatSelector(robotSelector);
                int dinoTarget = CombatSelector(dinoSelector);
                Console.WriteLine("The robot " + roboArmy.roboArmy[roboAttacker].robotName + " has targeted " + dinoArmy.dinoArmy[dinoTarget].dinoType + ".");
                roboArmy.roboArmy[roboAttacker].ChangeWeapon();
                Console.WriteLine(roboArmy.roboArmy[roboAttacker].robotName + "'s power level is now " + roboArmy.roboArmy[roboAttacker].powerLevel + ", and health is now " + roboArmy.roboArmy[roboAttacker].roboHealth + ".");
                roboArmy.roboArmy[roboAttacker].AttackDinosaur(dinoArmy.dinoArmy[dinoTarget]);
                Console.WriteLine(roboArmy.roboArmy[roboAttacker].robotName + "'s power level is now " + roboArmy.roboArmy[roboAttacker].powerLevel + ".");
                BattleFieldChecker();
                
                robotSelector = roboArmy.roboArmy.Count;
                dinoSelector = dinoArmy.dinoArmy.Count;
                
                if (dinoArmy.dinoArmy.Count==0)
                {
                    break;
                }
                
                int dinoAttacker = CombatSelector(dinoSelector);
                int roboTarget = CombatSelector(robotSelector);
                Console.WriteLine("The dinosaur " + dinoArmy.dinoArmy[dinoAttacker].dinoType + " has targeted " + roboArmy.roboArmy[roboTarget].robotName + ".");
                dinoArmy.dinoArmy[dinoAttacker].ChooseAttack(roboArmy.roboArmy[roboTarget]);
                Console.WriteLine(dinoArmy.dinoArmy[dinoAttacker].dinoType + "'s energy points is now " + dinoArmy.dinoArmy[dinoAttacker].dinoEnergy + ", and health is " + dinoArmy.dinoArmy[dinoAttacker].dinoHealth + ".");
                BattleFieldChecker();

            } while (dinoArmy.dinoArmy.Count > 0 && roboArmy.roboArmy.Count > 0);
             
                

            if (dinoArmy.dinoArmy.Count == 0)
            {
                Console.WriteLine("Robots have won the battle!");
            }
            if (roboArmy.roboArmy.Count == 0)
            {
                Console.WriteLine("Dinosaurs have won the battle");
            }
            


        }
    }
}
