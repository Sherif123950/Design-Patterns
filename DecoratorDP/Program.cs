using DecoratorDP.Decorators;
using DecoratorDP.Main_Components;

namespace DecoratorDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var espresso = new Espresso();
            Console.WriteLine(espresso);

            var espressoWithMilk = new Milk(espresso);
            Console.WriteLine(espressoWithMilk);

            var espressoWithMilkAndCaramel = new Caramel(espressoWithMilk);
            Console.WriteLine(espressoWithMilkAndCaramel);


            var espressoWithMilkAndCaramelAndMocha = new Mocha(espressoWithMilkAndCaramel);
            Console.WriteLine(espressoWithMilkAndCaramelAndMocha);
        }
    }
}
