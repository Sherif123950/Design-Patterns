using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDP
{
    internal interface IObserver
    {
        public string Name { get; set; }
        public Location Location { get; set; }
        void Update(Location newLocation);
    }
}
