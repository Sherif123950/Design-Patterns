using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDP.Main_Components
{
    internal class DarkRoastCofee : Beverage
    {
        public DarkRoastCofee()
        {
            Description = "Dark Roast Cofee";
            Cost = 4M;
        }
    }
}
