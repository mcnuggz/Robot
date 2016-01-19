using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public class Arm : Part
    {
        public bool HasWeapon;
        public string _weapon = "weapon";
        public string _tool = "tool";
        public string equippedItem;

        private List<string> Weapons = new List<string>()
        {
            "Mace",
            "Sword", 
            "Katana",
            "Pistol",
            "Laser pistol",
            "Assault Rifle",
            "Sniper Rifle",
            "Laster Rifle"

        };

        private List<string> Tools = new List<string>()
        {
            "Wrench",
            "Blow torch",
            "Screwdriver",
            "Pliers"
        };

        public Arm(string name, bool hasWeapon) : base(name)
        {
            HasWeapon = hasWeapon;
            Equip();
        }

        public void Equip()
        {
            if (HasWeapon == true)
            {
                Console.WriteLine("Do you want to equip a weapon or a tool?");
                string choice = Console.ReadLine().ToLower();
                if (choice == _weapon)
                {
                    EquipWeapon();
                }
                else if (choice == _tool)
                {
                    EquipTool();
                }
            }
        }

        private string EquipTool()
        {
            Console.Clear();
            Console.WriteLine("Choose what tool you wish to equip. One tool per arm.");
            foreach (string item in Tools)
            {
                Console.WriteLine(item);
            }
            string tool = Console.ReadLine().ToLower();
            switch (tool)
            {
                case "wrench":
                    Console.WriteLine("I hope you don't plan on making any sentries with that");
                    break;
                case "blow torch":
                    Console.WriteLine("Careful, it's hot!");
                    break;
                case "screwdriver":
                    Console.WriteLine("Screwdrivers. A versitile tool for versitile robots");
                    break;
                case "pliers":
                    Console.WriteLine("Good for yanking stuff");
                    break;
                default:
                    Console.WriteLine("No tool selected");
                    break;
            }
            equippedItem = tool;
            return equippedItem;
        }

        private string EquipWeapon()
        {
            Console.Clear();
            Console.WriteLine("Choose your weapon! One weapon per arm.");
            foreach (string weapons in Weapons)
            {
                Console.WriteLine(weapons);
            }
            string weapon = Console.ReadLine().ToLower();
            Console.WriteLine(Environment.NewLine);
                switch (weapon)
            {
                case "mace":
                    Console.WriteLine("Mace equipped");
                    break;

                case "sword":
                    Console.WriteLine("Unit prepared to fight for glory!");
                    break;

                case "katana":
                    Console.WriteLine("Unit is prepared to fight for honor!");
                    break;

                case "pistol":
                    Console.WriteLine("Locked and loaded");
                    break;

                case "laser pistol":
                    Console.WriteLine("Pew pew");
                    break;

                case "assault rifle":
                    Console.WriteLine("Safety off. Commence medium ranged combat operations");
                    break;

                case "sniper rifle":
                    Console.WriteLine("Finding cover for long range combat");
                    break;

                case "laser rifle":
                    Console.WriteLine("Advance weapon parameters check. Commence combat routine");
                    break;
                default:
                    Console.WriteLine("Fisticuffs it is then!");
                    break;
            }
            equippedItem = weapon;
            return equippedItem;
        }

    }
}
