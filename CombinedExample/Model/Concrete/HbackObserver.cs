using CombinedExample.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinedExample.Model.Concrete
{
    public class HbackObserver : IObserver
    {
        public void Update()
        {
            Console.WriteLine("Dear Hback observer, your car is ready..!");
        }
    }
}
