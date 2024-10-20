using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDP.CarComponents.Engines
{
    internal class MercidesEngine : IEngine
    {
        public int PowerHourse => 3000;

        public int MaxSpeed => 300;
        public override string ToString()
        {
            return $"{PowerHourse} cc , {MaxSpeed} km/s, ";
        }
    }
    
}
