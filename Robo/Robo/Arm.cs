using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public class Arm : Part
    {
        Tool tool = new Tool();
        Weapon weapon = new Weapon();
        private bool HasWeapon;
        private string _weapon = "weapon";
        private string _tool = "tool";
        private string _nothing = "nothing";

        public Arm(string name, bool hasWeapon) : base(name)
        {            
            HasWeapon = hasWeapon;
            Name = name;
            Equip();
        }

        public void Equip()
        {
            if (HasWeapon == true)
            {
                Console.WriteLine("Do you want to equip a weapon, a tool, or nothing?");
                string choice = Console.ReadLine().ToLower();
                if (choice == _weapon)
                {
                    weapon.EquipWeapon();
                }
                else if (choice == _tool)
                {
                    tool.EquipTool();
                }
                else if(choice == _nothing)
                {
                    Console.WriteLine("Very well. Nothing will be equipped in this hand.");
                }
            }
        }
    }
}
