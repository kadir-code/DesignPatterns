using MediatorDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern.Concrete
{
    public class User2 : BaseUser
    {
        public User2(string name) : base(name)
        {

        }
        public override void MessageReceiver(string sender, string messsage)
        {
            Console.WriteLine("From : User2: ");
            base.MessageReceiver(sender, messsage);
        }
    }
}
