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
    internal class ConcreteFactoryB : IFactory
    {
        public IEngine GetEngine()
        => new FerrariEngine();

        public IFrontWing GetFrontWings()
        => new DesignB();

        public IGearBox GetGearBox()
        => new GearBoxY(); 
    }
}
