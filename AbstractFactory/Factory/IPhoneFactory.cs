using FactoryMethodPattern.SecondImplementation.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    interface IPhoneFactory
    {
        IPhone CreatePhone(string model,string battery);
    }
}
