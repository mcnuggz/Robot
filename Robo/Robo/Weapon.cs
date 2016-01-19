using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Robot
{
    public class Weapon
    {
        public string equippedItem;
        private List<string> Weapons = new List<string>()
        {
            "Mace",
            "Sword",
            "Katana",
            "Pistol",
            "Laser pistol",
            "Assault Rifle",
            "Laser Rifle",
            "Sniper Rifle",
            "Laser Sniper Rifle"

        };

        public void EquipWeapon()
        {
            Console.Clear();
            Console.WriteLine("Choose your weapon! One weapon per arm.");
            foreach (string weapons in Weapons)
            {
                Console.WriteLine(weapons);
            }
            Console.WriteLine("");
            string weapon = Console.ReadLine().ToLower();
            switch (weapon)
            {
                case "mace":
                    Console.WriteLine("Mace equipped");
                    equippedItem = "Weapon: Mace";
                    break;

                case "sword":
                    Console.WriteLine("Unit prepared to fight for glory!");
                    equippedItem = "Weapon: Longsword";
                    break;

                case "katana":
                    Console.WriteLine("Unit is prepared to fight for honor!");
                    equippedItem = "Weapon: Katana";
                    break;

                case "pistol":
                    Console.WriteLine("Locked and loaded");
                    equippedItem = "Weapon: Pistol";
                    break;

                case "laser pistol":
                    Console.WriteLine("Pew pew");
                    equippedItem = "Weapon: Laser Pistol";
                    break;

                case "assault rifle":
                    Console.WriteLine("Safety off. Commence medium ranged combat operations");
                    equippedItem = "Weapon: Assault Rifle";
                    break;

                case "laser rifle":
                    Console.WriteLine("Laser batter at 100%");
                    equippedItem = "Weapon: Laser Rifle";
                    break;

                case "sniper rifle":
                    Console.WriteLine("Finding cover for long range combat");
                    equippedItem = "Weapon: Sniper Rifle";
                    break;

                case "laser sniper rifle":
                    Console.WriteLine("Advance weapon parameters check. Commence combat routine");
                    equippedItem = "Weapon: Laser Sniper Rifle";
                    break;
                default:
                    Console.WriteLine("Fisticuffs it is then!");
                    equippedItem = "Fist";
                    break;
            }
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}
