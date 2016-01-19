using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Robot
{
    public class Head : Part
    {
        public string model;
        public int sensorCoverage;
        private int midCoverage = 180;
        private int minCoverage = 120;
        private int maxCoverage = 270;
        private int nonCoverage = 0;

        private List<string> headList = new List<string>() { "[Sensory] model, [Standard] model, [Defensive] model" };
        public Head(string name) : base(name)
        {
            PickHeadModel();
            Name = model;
        }

        public void PickHeadModel()
        {
            Console.Clear();
            Console.WriteLine("Select your head model: ");
            foreach (string heads in headList)
            {
                Console.WriteLine("{0} ",heads);
            }
            Console.WriteLine("");
            string userHead = Console.ReadLine().ToLower();
            switch (userHead)
            {
                case "sensory":
                    Console.WriteLine("Sensors and optics calibrated. Covering {0} degrees around unit", maxCoverage);
                    model = "Sensory head unit";
                    sensorCoverage = maxCoverage;
                    break;
                case "standard":
                    Console.WriteLine("Optics calibrated. Covering {0} degrees in front of unit", midCoverage);
                    model = "Standard head unit";
                    sensorCoverage = midCoverage;
                    break;
                case "defensive":
                    Console.WriteLine("Shields online, optics calibrated. Covering {0} degrees in front of unit", minCoverage);
                    model = "Defensive head unit";
                    sensorCoverage = minCoverage;
                    break;
                default:
                    Console.WriteLine("Alright...no head unit. Odd choice, but hey it's your robot");
                    sensorCoverage = nonCoverage;
                    break;
                    
            }
            Thread.Sleep(2000);
        }
    }
}
