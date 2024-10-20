using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDP.CarComponents.GearBox
{
    internal class GearBoxY : IGearBox
    {
        public int ShiftNumber => 7;
        public bool IsAutomatic => true;
        public override string ToString()
        {
            return $"Shift Number {ShiftNumber} , {IsAutomatic}, ";
        }
    }
}
