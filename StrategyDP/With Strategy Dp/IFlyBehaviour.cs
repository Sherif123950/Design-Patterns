using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP.With_Strategy_Dp
{
    internal interface IFlyBehaviour
    {
        void PerformFly();
    }

    class NormalSpeedFly : IFlyBehaviour
    {
        public void PerformFly()
        {
            Console.WriteLine("I'm Flying with normal speed");
        }
    }
    class HighSpeedFly : IFlyBehaviour
    {
        public void PerformFly()
        {
            Console.WriteLine("I'm Flying with high speed");
        }
    }
    class NoFly : IFlyBehaviour
    {
        public void PerformFly()
        {
            Console.WriteLine("No Wings to fly");
        }
    }
}
