namespace ObserverDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ball = new Football(new Location(1,2,3));

            var P11 = new Player("Messi", "PSG");
            var P12 = new Player("Neymar", "PSG");
            var P21 = new Player("Salah", "Liverpool");
            var P22 = new Player("Mane", "Liverpool");

            var refree = new Refree("Mike Hannigan");

            ball.Subscribe(refree);
            ball.Subscribe(P11);
            ball.Subscribe(P12);
            ball.Subscribe(P21);
            ball.Subscribe(P22);

            ball.Location = new Location(4,5,6);

            Console.WriteLine("After firing salah");

            ball.Unsubscribe(P21);

            ball.Location = new Location(7,8,9);
        }
    }
}
