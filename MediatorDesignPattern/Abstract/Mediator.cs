using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern.Abstract
{
    public abstract class Mediator
    {
        public abstract void SignIn(BaseUser baseUser);

        public abstract void SendMessage(string sebder, string receiver, string message);
    }
}
