using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public class Leg : Part
    {
        public string movementSpeed;
        public int legCount = 0;
        public string slowSpeed = "Slow";
        public string averageSpeed = "Average";
        public string fastSpeed = "Fast";
        public string model;

        public Leg(string name) : base(name)
        {
            Name = model;
            AttachLegs();
        }

        public void AttachLegs()
        {
            Console.Clear();
            Console.WriteLine("Do you want Standard legs, Booster legs, or Tank Treads?");
            string legInput = Console.ReadLine().ToLower();
            switch (legInput)
            {
                case "standard legs":
                    Console.WriteLine("Legs attached");
                    model = "Standard Legs";
                    legCount = 2;
                    movementSpeed = averageSpeed;
                    break;
                case "booster legs":
                    Console.WriteLine("Fuel levels optimal.");
                    model = "Booster Legs";
                    movementSpeed = fastSpeed;
                    break;
                case "tank treads":
                    Console.WriteLine("All-terrain treads equipped.");
                    model = "Tank treads";
                    movementSpeed = slowSpeed;
                    break;
                default:
                    Console.WriteLine("No legs equipped.");
                    break;
            }
        }
    }
}
