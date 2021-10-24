using MediatorDesignPattern.Abstract;
using MediatorDesignPattern.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteMediator cm = new ConcreteMediator();

            BaseUser user1 = new User1("User1");
            BaseUser user2 = new User2("User1");

            cm.SignIn(user1);
            cm.SignIn(user2);

            user1.SendMessage("user2","its a message");
            user2.SendMessage("user1","its a message");

        }
    }
}
