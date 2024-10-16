namespace SingletonDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var card1 =  GCard.Create();
            var card2 =  GCard.Create();
            var card3 =  GCard.Create();

            Console.WriteLine(card1.GetHashCode());
            Console.WriteLine(card2.GetHashCode());
            Console.WriteLine(card3.GetHashCode());
        }
    }
}
