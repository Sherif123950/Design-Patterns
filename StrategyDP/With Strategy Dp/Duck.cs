using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDP.With_Strategy_Dp
{
    internal abstract class Duck
    {
        public IFlyBehaviour FlyBehaviour { get; set; }
        public IQuackBehaviour QuackingBehaviour { get; set; }
        protected Duck(IFlyBehaviour flyBehaviour, IQuackBehaviour quackBehaviour)
        {
            this.FlyBehaviour = flyBehaviour;
            this.QuackingBehaviour = quackBehaviour;
        }
        public abstract void Display();

        public  void Swim()
        {
            Console.WriteLine("I'm Swimming :)");
        }

        public void Quacking()
        {
            QuackingBehaviour.PerformQuack();
        }

        public void Flying()
        {
            FlyBehaviour.PerformFly();

        }
        public void FlyingWithDelegate(Action flyDelegate)
        {
            flyDelegate.Invoke();
        }
        public void QuackingWithDelegate(Action quackDelegate)
        {
            quackDelegate.Invoke();
        }
    }
}
