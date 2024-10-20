using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDP
{
    internal class Player : IObserver
    {
        public Player(string name, string team)
        {
            Name = name;
            Team = team;
        }
        public string Name { get; set; }
        public string Team { get; set; }
        public Location Location { get; set; }
        public void Update(Location newLocation)
        {
            Location = newLocation;
            Console.WriteLine($"{this} is running towards location {newLocation}");
        }
        public override string ToString()
        {
            return $"Player: {Name} at team {Team}";
        }
    }
}
