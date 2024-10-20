using AbstractFactoryDP.CarComponents.Engines;
using AbstractFactoryDP.CarComponents.FrontWings;
using AbstractFactoryDP.CarComponents.GearBox;
using AbstractFactoryDP.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDP
{
    internal class Formula1Car
    {
        IFactory factory;
        IEngine engine;
        IFrontWing frontWing;
        IGearBox gearBox;

        public Formula1Car(IFactory factory)
        {
            this.factory = factory;
        }
        public void Assemble()
        {
            engine = factory.GetEngine(); 
            frontWing = factory.GetFrontWings(); 
            gearBox = factory.GetGearBox();
        }

        public override string ToString()
        {
            return $"{engine} {frontWing} {gearBox}";
        }
    }
}
