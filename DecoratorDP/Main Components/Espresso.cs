using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDP.Main_Components
{
    internal class Espresso : Beverage
    {
        public Espresso()
        {
            Description = "Espresso";
            Cost = 2.5M;
        }
    }
}
