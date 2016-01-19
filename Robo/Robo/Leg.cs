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

        public string AttachLegs()
        {
            Console.WriteLine("Do you want regular legs, booster legs, or tracked legs?");
            string legInput = Console.ReadLine().ToLower();
            switch (legInput)
            {
                case "regular legs":
                    Console.WriteLine("Legs attached");
                    legCount = 2;
                    movementSpeed = averageSpeed;
                    break;
                case "booster legs":
                    Console.WriteLine("Fuel levels optimal.");
                    movementSpeed = fastSpeed;
                    break;
                case "tracked legs":
                    Console.WriteLine("All-terrain chassis equipped.");
                    movementSpeed = slowSpeed;
                    break;
                default:
                    Console.WriteLine("No legs equipped.");
                    break;
            }
            model = legInput;
            return model;
        }
    }
}
