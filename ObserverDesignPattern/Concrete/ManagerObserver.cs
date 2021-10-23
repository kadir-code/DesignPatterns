using ObserverDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern.Concrete
{
    class ManagerObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("the manager was informed");
        }
    }
}
