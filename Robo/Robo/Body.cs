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
        public Body(string name) : base(name)
        {
            Name = model;
        }
    }
}
