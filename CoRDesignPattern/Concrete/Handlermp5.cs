using CoRDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoRDesignPattern.Concrete
{
    class Handlermp5 : PlayerHandler
    {
        public override void Player(string fileType)
        {
            if (fileType.EndsWith(".mp5"))
            {
                Console.WriteLine($"{fileType} type is playing");
            }
            else
            {
                Console.WriteLine("Unknown type..!");
            }
        }
    }
}
