using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP.With_no_Strategy_Dp
{
    internal class RubberDuck:Duck
    {
        public override void Display()
        {
            Console.WriteLine("I'm Rubber Duck");
        }
        public new void Quacking()
        {
            Console.WriteLine("I'm Squeeking");
        }
        public new void Swim()
        {
            Console.WriteLine("I'm not Swimming :(");
        }
        public new void Flying()
        {
            Console.WriteLine("No Wings To Fly");
        }
    }
}
