using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDP.Main_Components
{
    internal class Decaf:Beverage
    {
        public Decaf()
        {
            Description = "Decaf Coffe";
            Cost = 3M;
        }
    }
}
