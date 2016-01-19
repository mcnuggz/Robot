using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assemble = new Assembly();
            Weapon weapon = new Weapon();
            Tool tool = new Tool();
            assemble.AssembleParts();
            Console.WriteLine("");
            foreach (Part item in assemble.robotParts)
            {
                Console.WriteLine(item.Name);
            }
            foreach (string item in assemble.equippedItems)
            {
                Console.WriteLine(item);
            }
            assemble.IsPoweredOn();
            Console.Read();
        }
    }
}
