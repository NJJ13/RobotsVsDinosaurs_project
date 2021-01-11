using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Robot
    {
        public string robotName;
        public int roboHealth;
        public int powerLevel;
        public int attackPower;
        public List<Weapon> equippedWeapon;

        public Robot(string robotName, int roboHealth, int powerLevel)
        {
            this.robotName = robotName;
            this.roboHealth = roboHealth;
            this.powerLevel = powerLevel;
            ChooseWeapon();
            
            
        }

        public void ChooseWeapon()
        {
            Console.WriteLine("Choose your robot's weapon. 1. Lazer Rifle 2. Lazer Sword, 3. Robofists");
            int selectedWeapon = int.Parse(Console.ReadLine());
            if (selectedWeapon == 1)
            {
                Weapon lazerRifle = new Weapon("Lazer Rifle", 50);
                Console.WriteLine("Lazer Rifle has been selected.");
            }
            else if (selectedWeapon == 2)
            {
                Weapon lazerSword = new Weapon("Lazer Sword", 60);
                Console.WriteLine("Lazer Sword has been selected.");
            }
            else if (selectedWeapon == 3)
            {
                Weapon roboFists = new Weapon("Robofists", 20);
                Console.WriteLine("Robofists have been selected.");
            }
            else
            {
                ChooseWeapon();
            }
        }
        public void AttackDinosaur()
        {

        } 
    }

}
