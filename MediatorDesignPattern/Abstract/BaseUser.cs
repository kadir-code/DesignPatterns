using MediatorDesignPattern.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern.Abstract
{
    public class BaseUser
    {
        public string Name { get; set; }
        public ConcreteMediator concreteMediator { set; get; }
        public BaseUser(string name)
        {
            this.Name = name;
        }
        public void SendMessage(string receiver,string messsage)
        {
            concreteMediator.SendMessage(Name, receiver, messsage);
        }
        public virtual void MessageReceiver(string sender, string messsage)
        {
            Console.WriteLine("{0} to {1}: '{2}'", sender, Name, messsage);
        }
    }
}
