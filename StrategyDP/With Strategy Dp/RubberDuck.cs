using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP.With_Strategy_Dp
{
    internal class RubberDuck : Duck
    {
        public RubberDuck():base(new NoFly(), new Squeecking())
        {
            
        }
        public override void Display()
        {
            Console.WriteLine("im dp rubber duck.....");
        }

        public new void Swim()
        {
            Console.WriteLine("I'm not swimming ....");
        }
    }
}
