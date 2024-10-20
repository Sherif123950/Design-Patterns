using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDP.CarComponents.GearBox
{
    internal class GearBoxX : IGearBox
    {
        public int ShiftNumber => 5;

        public bool IsAutomatic => false;
        public override string ToString()
        {
            return $"Shift Number {ShiftNumber} , {IsAutomatic}, ";
        }
    }
}
