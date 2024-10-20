using AbstractFactoryDP.CarComponents.Engines;
using AbstractFactoryDP.CarComponents.FrontWings;
using AbstractFactoryDP.CarComponents.GearBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDP.Factories
{
    internal interface IFactory
    {
        IEngine GetEngine();
        IFrontWing GetFrontWings();
        IGearBox GetGearBox();
    }
}
