using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP.With_Strategy_Dp
{
    internal interface IQuackBehaviour
    {
        void PerformQuack();
    }
    class Quacking : IQuackBehaviour
    {
        public void PerformQuack()
        {
            Console.WriteLine("Im Quacking");
        }
    }
    class Squeecking : IQuackBehaviour
    {
        public void PerformQuack()
        {
            Console.WriteLine("I'm Squeecking");
        }
    }
    class AbnormalQuacking() : IQuackBehaviour
    {
        public void PerformQuack()
        {
            Console.WriteLine("I'm abnormally Quaacking");
        }
    }
}
