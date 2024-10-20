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
    internal class ConcreteFactoryA : IFactory
    {
        public IEngine GetEngine()
        => new MercidesEngine();
        public IFrontWing GetFrontWings()
        => new DesignA();

        public IGearBox GetGearBox()
        => new GearBoxX();
    }
}
