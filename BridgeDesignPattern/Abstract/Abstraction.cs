using BridgeDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern.Abstract
{
    public class Abstraction
    {
        IBridge _bridge;
        public Abstraction(IBridge bridge)
        {
            _bridge = bridge;
        }

        public string Operation()
        {
            return _bridge.Operation();
        }
    }
}
