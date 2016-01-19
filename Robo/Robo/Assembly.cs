using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public class Assembly : IPowerSource
    {
        Tool tool = new Tool();
        Weapon weapon = new Weapon();
        private bool poweredOn = false;
        public List<Part> robotParts = new List<Part>();
        public List<string> equippedItems = new List<string>();
        public void IsPoweredOn()
        {
            Console.WriteLine("Unit powered on, moving out");
            poweredOn = true;
        }

        public void AssembleParts()
        {
            equippedItems = new List<string>();
            robotParts = new List<Part>();

            robotParts.Add(new Body("Body"));
            robotParts.Add(new Arm("Left Arm", true));
            robotParts.Add(new Arm("Right Arm", true));
            robotParts.Add(new Leg("Legs"));
            robotParts.Add(new Head("Head"));
            equippedItems.Add(weapon.equippedItem);
            equippedItems.Add(tool.equippedItem);

        }
    }
}
