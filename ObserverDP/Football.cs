using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDP
{
    internal class Football
    {
        public Location location;
        public List<IObserver> observers;
        public Location Location
        {
            get
            {
                return location;
            }
            set
            {
                if (!location.Equals(value))
                {
                    location = value;
                    if (observers is not null)
                    {
                        Notify(location);
                    }
                }
            }
        }
        public Football(Location newLocation)
        {
            observers = new List<IObserver>();
            Location = newLocation;
        }
        public void Notify(Location location)
        {
            foreach (var sub in observers)
            {
                sub.Update(location);
            }
        }
        public void Subscribe(IObserver subscriber)
        {
            observers.Add(subscriber);
        }
        public void Unsubscribe(IObserver subscriber)
        {
            observers.Remove(subscriber);
        }
    }
}
