using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDP
{
    internal class Refree : IObserver
    {
        public Refree(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public Location Location { get; set; }

        public void Update(Location newLocation)
        {
            Location = newLocation;
            Console.WriteLine($"{this} is looking towards location {newLocation}");
        }
        public override string ToString()
        {

            return $"Refree : {Name}";
        }
    }
}
