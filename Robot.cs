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
        public int attackPower = 5;
        public Weapon equippedWeapon;
        int roboAttackPower;
        public Weapon lazerRifle = new Weapon("Lazer Rifle", 15);
        public Weapon lazerSword = new Weapon("Lazer Sword", 10);
        public Weapon robofists = new Weapon("Robofists", 5);

        public Robot(string robotName, int roboHealth, int powerLevel)
        {
            this.robotName = robotName;
            this.roboHealth = roboHealth;
            this.powerLevel = powerLevel;
            equippedWeapon = new Weapon("None", 1);
            this.roboAttackPower = equippedWeapon.attackPower * attackPower;
            List<Weapon> roboWeapons = new List<Weapon>();
            roboWeapons.Add(lazerRifle);
            roboWeapons.Add(lazerSword);
            roboWeapons.Add(robofists);
                                    
        }

        
        public void ChangeWeapon()
        {
            Console.WriteLine("Changing equipped weapon uses 10 power level points. Would you like to change your robot's weapon?");
            Console.WriteLine("Yes or No");
            string changeWeaponResponse = Console.ReadLine();
            if (changeWeaponResponse == "Yes" || changeWeaponResponse == "yes" || changeWeaponResponse == "y")
            {
                powerLevel -= 10;
                Console.WriteLine("Choose your robot's equipped weapon. 1. Lazer Rifle (-10 power level points) 2. Lazer Sword (-5 power level points) 3. Robofists (-10 power level points)");
                int selectedWeapon = int.Parse(Console.ReadLine());
                if (selectedWeapon == 1)
                {
                    
                    Console.WriteLine("Lazer Rifle has been selected.");
                    equippedWeapon = lazerRifle;
                    this.roboAttackPower = attackPower * equippedWeapon.attackPower;
                    powerLevel -= 10;

                }
                else if (selectedWeapon == 2)
                {
                    Console.WriteLine("Lazer Sword has been selected.");
                    equippedWeapon = lazerSword;
                    this.roboAttackPower = attackPower * equippedWeapon.attackPower;
                    roboHealth += 25;
                    powerLevel -= 5;
                }
                else if (selectedWeapon == 3)
                {
                    Console.WriteLine("Robofists have been selected.");
                    equippedWeapon = robofists;
                    roboHealth += 50;
                    powerLevel -= 10;
                    this.roboAttackPower = attackPower * equippedWeapon.attackPower;
                }
                else
                {
                    Console.WriteLine("No weapon has been changed.");
                    this.roboAttackPower = attackPower * equippedWeapon.attackPower;
                }
                    
            }
            
            
        }
        public void AttackDinosaur(Dinosaur chosenDino)
        {
            if (powerLevel > 0)
            {
                chosenDino.dinoHealth -= roboAttackPower;
                powerLevel -= 10;
                Console.WriteLine("The robot's attack was successful, " + chosenDino.dinoType + "'s health is now " + chosenDino.dinoHealth + ".");
            }
            else
            {
                Console.WriteLine("The robot's power level is too low too attack, and must recharge. The robot's power level will be restored.");
                powerLevel = 100;
            }
        } 
    }

}
