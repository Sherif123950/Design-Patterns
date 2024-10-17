using DecoratorDP.Main_Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDP.Decorators
{
    internal class Milk : Decorator
    {
        public Milk(Beverage beverage):base(beverage)
        {
        }
        public override string Description => $"{_beverage.Description}, With Milk";
        public override decimal Cost => _beverage.Cost + 0.75M;
    }
}
