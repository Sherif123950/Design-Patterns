using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP.With_no_Strategy_Dp
{
    internal abstract class Duck
    {
        public abstract void Display();

        public  void Swim()
        {
            Console.WriteLine("I'm Swimming :)");
        }
        public void Quacking()
        {
            Console.WriteLine("I'm Quacking :)");
        }
        public void Flying()
        {
            Console.WriteLine("I'm Normal Flying");
        }
    }
}
