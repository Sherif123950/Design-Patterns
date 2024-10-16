using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP.With_Strategy_Dp
{
    internal class MullardDuck : Duck
    {
        public MullardDuck():base(new NormalSpeedFly(),new Quacking())
        {
            
        }
        public override void Display()
        {
            Console.WriteLine("Im DP Mullard Duck.....");
        }


    }
}
