using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDP.Main_Components
{
    internal class HouseBlend:Beverage
    {
        public HouseBlend()
        {
            Description = "House Blend Cofee";
            Cost = 3.5M;   
        }
    }
}
