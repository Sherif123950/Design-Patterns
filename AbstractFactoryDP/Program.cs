using AbstractFactoryDP.Factories;

namespace AbstractFactoryDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var factory = new ConcreteFactoryA();
            var car = new Formula1Car(factory);
            car.Assemble();
            Console.WriteLine(car);
        }
    }
}
