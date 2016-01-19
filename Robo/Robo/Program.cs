using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Robot
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assemble = new Assembly();
            assemble.AssembleParts();
            Console.WriteLine("");
            foreach (Part item in assemble.robotParts)
            {
                Console.WriteLine(item.Name);
            }
            assemble.IsPoweredOn();
            Console.Read();
        }
    }
}
