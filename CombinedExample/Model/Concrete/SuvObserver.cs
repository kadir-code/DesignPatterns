using CombinedExample.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinedExample.Model.Concrete
{
    public class SuvObserver : IObserver
    {
        public void Update()
        {
            Console.WriteLine("Dear Suv observer, your car is ready..!");

        }
    }
}
