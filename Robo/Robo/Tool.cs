using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Robot
{
    public class Tool
    {
        public string equippedItem;
        private List<string> Tools = new List<string>()
        {
            "Wrench",
            "Blow torch",
            "Screwdriver",
            "Pliers"
        };

        public void EquipTool()
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
                    Console.WriteLine("I hope you don't plan on making any sentries with that. ");
                    equippedItem = "Tool: Wrench";
                    break;
                case "blow torch":
                    Console.WriteLine("Careful, it's hot!");
                    equippedItem = "Tool: Blow torch";
                    break;
                case "screwdriver":
                    Console.WriteLine("Screwdrivers. A versitile tool for versitile robots");
                    equippedItem = "Tool: Screwdriver";
                    break;
                case "pliers":
                    Console.WriteLine("Good for yanking stuff");
                    equippedItem = "Tool: Pliers";
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
