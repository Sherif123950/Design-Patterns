using DecoratorDP.Main_Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDP.Decorators
{
    internal class Caramel:Decorator
    {
        public Caramel(Beverage beverage):base(beverage)
        {

        }
        public override string Description => $"{_beverage.Description}, With caramel";
        public override decimal Cost => _beverage.Cost + 1M;
    }
}
