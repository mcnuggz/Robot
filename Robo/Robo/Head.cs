using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private List<string> headList = new List<string>() { "Sensory model, Standard model, Defensive model" };
        public Head(string name) : base(name)
        {
            PickHeadModel();
            Name = model;
        }

        public string PickHeadModel()
        {
            Console.WriteLine("Select your head model");
            foreach (string heads in headList)
            {
                Console.WriteLine(heads);
            }
            string userHead = Console.ReadLine().ToLower();
            switch (userHead)
            {
                case "sensory head":
                    Console.WriteLine("Sensors and optics calibrated. Covering {0} around unit", maxCoverage);
                    sensorCoverage = maxCoverage;
                    break;
                case "standard model":
                    Console.WriteLine("Optics calibrated. moving out. Covering {0} in front of unit", midCoverage);
                    sensorCoverage = midCoverage;
                    break;
                case "defensive model":
                    Console.WriteLine("Shields online, optics calibrated. Covering {0} in front of unit", minCoverage);
                    sensorCoverage = minCoverage;
                    break;
                default:
                    Console.WriteLine("Alright...no head unit. Odd choice, but hey it's your robot");
                    sensorCoverage = nonCoverage;
                    break;
            }
            model = userHead;
            return model;
        }
    }
}
