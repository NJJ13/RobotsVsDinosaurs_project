using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Robot : Combatant
    {
        public Weapon equippedWeapon;
        int roboAttackPower;
        public Weapon lazerRifle = new Weapon("Lazer Rifle", 15);
        public Weapon lazerSword = new Weapon("Lazer Sword", 10);
        public Weapon robofists = new Weapon("Robofists", 5);

        public Robot(string robotName, int roboHealth, int powerLevel)
        {
            name = robotName;
            health = roboHealth;
            energy = powerLevel;
            attackPower = 5;
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
                energy -= 10;
                Console.WriteLine("Choose your robot's equipped weapon. 1. Lazer Rifle (-10 power level points) 2. Lazer Sword (-5 power level points) 3. Robofists (-10 power level points)");
                int selectedWeapon = int.Parse(Console.ReadLine());
                if (selectedWeapon == 1)
                {
                    
                    Console.WriteLine("Lazer Rifle has been selected.");
                    equippedWeapon = lazerRifle;
                    this.roboAttackPower = attackPower * equippedWeapon.attackPower;
                    energy -= 10;

                }
                else if (selectedWeapon == 2)
                {
                    Console.WriteLine("Lazer Sword has been selected.");
                    equippedWeapon = lazerSword;
                    this.roboAttackPower = attackPower * equippedWeapon.attackPower;
                    health += 25;
                    energy -= 5;
                }
                else if (selectedWeapon == 3)
                {
                    Console.WriteLine("Robofists have been selected.");
                    equippedWeapon = robofists;
                    health += 50;
                    energy -= 10;
                    this.roboAttackPower = attackPower * equippedWeapon.attackPower;
                }
                else
                {
                    Console.WriteLine("No weapon has been changed.");
                    this.roboAttackPower = attackPower * equippedWeapon.attackPower;
                }
                    
            }
            
            
        }
        public override void Attack(Combatant combatant)
        {
            if (energy > 0)
            {
                combatant.health -= attackPower;
                energy -= 10;
                Console.WriteLine("The robot's attack was successful, " + combatant.name + "'s health is now " + combatant.name + ".");
            }
            else
            {
                Console.WriteLine("The robot's power level is too low too attack, and must recharge. The robot's power level will be restored.");
                energy = 100;
            }
        } 
    }

}
