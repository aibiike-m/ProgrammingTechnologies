using System;

namespace programming_tecnologies
{
    public static class Task7_GladiatorEquipment
    {
        public static void Run()
        {
            Console.Write("Choose armor type (1 - Light, 2 - Medium, 3 - Heavy): ");
            string? armorChoice = Console.ReadLine();

            double armorWeight = 0;
            decimal armorCost = 0;

            if (armorChoice == "1")
            {
                armorWeight = 10;
                armorCost = 500;
            }
            else if (armorChoice == "2")
            {
                armorWeight = 25;
                armorCost = 1200;
            }
            else if (armorChoice == "3")
            {
                armorWeight = 45;
                armorCost = 2500;
            }
            else
            {
                Console.WriteLine("Invalid armor choice.");
                return;
            }

            Console.Write("Choose weapon (1 - Sword, 2 - Trident, 3 - Spear): ");
            string? weaponChoice = Console.ReadLine();

            double weaponWeight = 0;
            decimal weaponCost = 0;

            if (weaponChoice == "1")
            {
                weaponWeight = 3;
                weaponCost = 300;
            }
            else if (weaponChoice == "2")
            {
                weaponWeight = 4;
                weaponCost = 400;
            }
            else if (weaponChoice == "3")
            {
                weaponWeight = 5;
                weaponCost = 350;
            }
            else
            {
                Console.WriteLine("Invalid weapon choice.");
                return;
            }

            Console.Write("Add helmet? (yes/no): ");
            bool addHelmet = Console.ReadLine()?.Trim().ToLower() == "yes";
            double helmetWeight = addHelmet ? 2 : 0;
            decimal helmetCost = addHelmet ? 200 : 0;

            Console.Write("Add shield? (yes/no): ");
            bool addShield = Console.ReadLine()?.Trim().ToLower() == "yes";
            double shieldWeight = addShield ? 6 : 0;
            decimal shieldCost = addShield ? 500 : 0;

            double totalWeight = armorWeight + weaponWeight + helmetWeight + shieldWeight;
            decimal totalCost = armorCost + weaponCost + helmetCost + shieldCost;

            Console.WriteLine($"Total equipment weight: {totalWeight} kg");
            Console.WriteLine($"Total equipment cost: {totalCost}");
        }
    }
}