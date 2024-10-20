using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDP.CarComponents.FrontWings
{
    internal class DesignA : IFrontWing
    {
        public int count => 6;
        public override string ToString()
        {
            return $"{count} Wings, ";
        }
    }
}
