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
        public Robot(string robotName, int roboHealth, int powerLevel)
        {
            this.robotName = robotName;
            this.roboHealth = roboHealth;
            this.powerLevel = powerLevel;
            Weapon none = new Weapon("None", 1);
            equippedWeapon = none;
            this.roboAttackPower = equippedWeapon.attackPower * attackPower;
                        
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
                    Weapon lazerRifle = new Weapon("Lazer Rifle", 15);
                    Console.WriteLine("Lazer Rifle has been selected.");
                    equippedWeapon = lazerRifle;
                    this.roboAttackPower = attackPower * equippedWeapon.attackPower;
                    powerLevel -= 10;

                }
                else if (selectedWeapon == 2)
                {
                    Weapon lazerSword = new Weapon("Lazer Sword", 10);
                    Console.WriteLine("Lazer Sword has been selected.");
                    equippedWeapon = lazerSword;
                    this.roboAttackPower = attackPower * equippedWeapon.attackPower;
                    roboHealth += 25;
                    powerLevel -= 5;
                }
                else if (selectedWeapon == 3)
                {
                    Weapon roboFists = new Weapon("Robofists", 5);
                    Console.WriteLine("Robofists have been selected.");
                    equippedWeapon = roboFists;
                    roboHealth += 50;
                    powerLevel -= 10;
                    this.roboAttackPower = attackPower * equippedWeapon.attackPower;
                }
                else
                {
                    Weapon none = new Weapon("No weapon selected", 1);
                    Console.WriteLine("No weapon has been equipped.");
                    equippedWeapon = none;
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
