using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDP.CarComponents.GearBox
{
    internal interface IGearBox
    {
        int ShiftNumber { get; }
        bool IsAutomatic { get; }
    }
}
