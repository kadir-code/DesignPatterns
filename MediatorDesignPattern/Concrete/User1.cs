using MediatorDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern.Concrete
{
    public class User1 : BaseUser
    {
        public User1(string name) : base(name)
        {

        }
        public override void MessageReceiver(string sender, string messsage)
        {
            Console.WriteLine("From : User1: ");
            base.MessageReceiver(sender, messsage);
        }
    }
}
