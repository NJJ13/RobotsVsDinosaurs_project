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

        public Battlefield(Herd dinoArmy, Fleet roboArmy)
        {
            dinoArmy = new Herd();
            roboArmy = new Fleet();

        }

        public void Clash()
        {
            while (dinoArmy.dinoArmy.Count < 0 && roboArmy.roboArmy.Count <0)
            {        
                if (dinoArmy.dinoArmy[0].dinoHealth > 0)
                {
                    dinoArmy.dinoArmy[0].AttackRobot(roboArmy.roboArmy[0]);
                }
                else
                {
                    dinoArmy.dinoArmy.RemoveAt(0);
                    Console.WriteLine(dinoArmy.dinoArmy[0] + " has been defeated.");
                }
                if (roboArmy.roboArmy[0].roboHealth > 0)
                {
                    roboArmy.roboArmy[0].AttackDinosaur(dinoArmy.dinoArmy[0]);
                }
                else
                {
                    roboArmy.roboArmy.RemoveAt(0);
                    Console.WriteLine(roboArmy.roboArmy[0] + " has been defeated.");
                }

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
}
