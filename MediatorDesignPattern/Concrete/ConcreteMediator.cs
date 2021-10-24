using MediatorDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern.Concrete
{
    public class ConcreteMediator : Mediator
    {
        private Dictionary<string, BaseUser> _baseUsers = new Dictionary<string, BaseUser>();
        public override void SendMessage(string sender, string receiver, string message)
        {
            BaseUser baseUser = _baseUsers[receiver];
            throw new NotImplementedException();
        }

        public override void SignIn(BaseUser baseUser)
        {
            if (!_baseUsers.ContainsValue(baseUser))
            {
                _baseUsers[baseUser.Name] = baseUser;
            }
            baseUser.concreteMediator = this;
        }
    }
}
