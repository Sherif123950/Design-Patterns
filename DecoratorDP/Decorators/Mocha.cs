using DecoratorDP.Main_Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDP.Decorators
{
    internal class Mocha:Decorator
    {
        public Mocha(Beverage beverage):base(beverage)
        {
        }
        public override string Description => $"{_beverage.Description}, With Mocha";
        public override decimal Cost => _beverage.Cost+1.25M;
    }
}
