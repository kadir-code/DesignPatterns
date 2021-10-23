using FactoryMethodPattern.SecondImplementation.Concrete;
using FactoryMethodPattern.SecondImplementation.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    class SamsungFactory : IPhoneFactory
    {
        public IPhone CreatePhone(string model, string battery)
        {
            return new Samsung("S8", "1500mah");
        }
    }
}
