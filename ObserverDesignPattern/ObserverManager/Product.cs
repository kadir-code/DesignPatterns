using ObserverDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern.ObserverManager
{
    class Product
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Category { get; set; }

        bool _produce = false;

        public bool Produce
        {
            get { return _produce; }
            set
            {
                if (value == true)
                {
                    Notify();
                    _produce = value;
                }
                else
                {
                    _produce = value;
                }
            }
        }
        List<Observer> Observers;
        public Product()
        {
            this.Observers = new List<Observer>();

        }
        public void AddObserver(Observer observer)
        {
            Observers.Add(observer);
        }
        public void RemoveObserver(Observer observer)
        {
            Observers.Remove(observer);
        }
        public void Notify()
        {
            Observers.ForEach (o=> { o.Update(); }) ;
            
        }
    }
}
