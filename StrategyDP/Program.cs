using StrategyDP.With_Strategy_Dp;

namespace StrategyDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mallradDuck = new MullardDuck();
            mallradDuck.Display();
            mallradDuck.Quacking();
            mallradDuck.Swim();
            mallradDuck.Flying();

            Console.WriteLine("******************************");

            var rubberDuck = new RubberDuck();
            rubberDuck.Display();
            rubberDuck.Quacking();
            rubberDuck.Swim();
            rubberDuck.Flying();


            Console.WriteLine("++++++++++++++++++++++++++ Hunting mode on +++++++++++++++++++++++++++");
            mallradDuck.QuackingBehaviour = new AbnormalQuacking();
            mallradDuck.FlyBehaviour = new HighSpeedFly();
            mallradDuck.Flying();
            mallradDuck.Quacking();


            Console.WriteLine("++++++++++++++++++++++++++ Hunting mode on with delegate +++++++++++++++++++++++++++");
            
            mallradDuck.FlyingWithDelegate(()=> Console.WriteLine("Im flying with high speed with delegate"));
            mallradDuck.QuackingWithDelegate(() => Console.WriteLine("Im abnormally quacking with delegate"));

        }
    }
}
