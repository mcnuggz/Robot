using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public class Body : Part
    {
        public string model;
        public bool poweredOn = false;
        List<string> bodyModels = new List<string>() { "Light body", "Standard body", "Heavy body" };
        public Body(string name) : base(name)
        {
            PickBodyChassis();
            Name = model;
        }
        public void PickBodyChassis()
        {
            Console.Clear();
            Console.WriteLine("Pick a body chassis: ");
            foreach (string item in bodyModels)
            {
                Console.WriteLine ("{0} ",item);
            }
            Console.WriteLine("");
            string userBody = Console.ReadLine().ToLower();
            switch (userBody)
            {
                case "light":
                    Console.WriteLine("You may be faster now, but you take more damage. Be careful out there");
                    model = "Light body chassis";
                    break;
                case "standard":
                    Console.WriteLine("A fine balance between mobility and defense");
                    model = "Standard body chassis";
                    break;
                case "heavy":
                    Console.WriteLine("Not easy to move around with this heavy body, but bullets don't hurt you.");
                    model = "Heavy body chassis";
                    break;
                default:
                    Console.WriteLine("Please select a valid body option");
                    PickBodyChassis();
                    break;
            }
            Console.Clear();
        }

    }
}
