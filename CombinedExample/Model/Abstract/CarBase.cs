using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinedExample.Model.Abstract
{
    public class CarBase
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }


       bool _produce;

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
        List<IObserver> _observer;
        public CarBase()
        {
            this._observer = new List<IObserver>();

        }
        public void AddObserver(IObserver observer)
        {
            _observer.Add(observer);
        }
        public void RemoveObserver(IObserver observer)
        {
            _observer.Remove(observer);
        }
        public void Notify()
        {
            _observer.ForEach(o => { o.Update(); });

        }
    }
}
