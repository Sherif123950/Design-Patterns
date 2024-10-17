using DecoratorDP.Main_Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDP.Decorators
{
    abstract class Decorator : Beverage
    {
         protected Beverage _beverage;
        public Decorator(Beverage beverage)
        {
            _beverage = beverage;
        }
    }
}
