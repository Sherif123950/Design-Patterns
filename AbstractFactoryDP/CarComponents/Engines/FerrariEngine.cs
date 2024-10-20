using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDP.CarComponents.Engines
{
    internal class FerrariEngine : IEngine
    {
        public int PowerHourse => 4000;

        public int MaxSpeed => 500;
        public override string ToString()
        {
            return $"{PowerHourse} cc , {MaxSpeed} km/s, ";
        }
    }
}
