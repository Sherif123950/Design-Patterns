using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDP.CarComponents.FrontWings
{
    internal class DesignB : IFrontWing
    {
        public int count => 8;
        public override string ToString()
        {
            return $"{count} Wings, ";
        }
    }
}
