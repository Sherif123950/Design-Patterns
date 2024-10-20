using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDP.CarComponents.Engines
{
    internal interface IEngine
    {
        int PowerHourse { get; }
        int MaxSpeed { get; }
    }
}
