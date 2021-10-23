using ObserverDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern.Concrete
{
    class EmployeeObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("the employee was informed");
        }
    }
}
