using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Robot
{
    public class Leg : Part
    {
        public string model;

        public Leg(string name) : base(name)
        {  
            AttachLegs();
            Name = model;
        }

        public void AttachLegs()
        {
            Console.Clear();
            Console.WriteLine("Do you want [Standard] legs, [Booster] legs, or [Tank Treads]?");
            string legInput = Console.ReadLine().ToLower();
            Console.WriteLine( Environment.NewLine);
            switch (legInput)
            {
                case "standard":
                    Console.WriteLine("Legs attached");
                    model = "Standard Legs";
                    break;
                case "booster":
                    Console.WriteLine("Fuel levels optimal.");
                    model = "Booster Legs";
                    break;
                case "tank treads":
                    Console.WriteLine("All-terrain treads equipped.");
                    model = "Tank treads";
                    break;
                default:
                    Console.WriteLine("No legs equipped.");
                    break;
            }
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}
