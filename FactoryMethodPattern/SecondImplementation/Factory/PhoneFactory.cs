using FactoryMethodPattern.SecondImplementation.Concrete;
using FactoryMethodPattern.SecondImplementation.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern.SecondImplementation.Factory
{
    class PhoneFactory
    {
        //Here is a problem,what if we have 100 models for only samsung?
        //We should use abstract factory pattern.
        public static IPhone GetPhone(string model,string battery)
        {
            IPhone _phone=null;
            if ("Samsung"==model)
            {
                _phone = new Samsung(model, battery);
            }
            else if ("Iphone"==model)
            {
                _phone = new Iphone(model,battery);
            }
            return _phone;
        }
    }
}
