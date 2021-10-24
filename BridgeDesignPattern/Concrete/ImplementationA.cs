using BridgeDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern.Concrete
{
    class ImplementationA : IBridge
    {
        public string Operation()
        {
            return "Implementation A";
        }
    }
}
