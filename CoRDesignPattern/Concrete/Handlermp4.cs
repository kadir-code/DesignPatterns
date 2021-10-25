using CoRDesignPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoRDesignPattern.Concrete
{
    class Handlermp4 : PlayerHandler
    {
        public override void Player(string fileType)
        {
            if (fileType.EndsWith(".mp4"))
            {
                Console.WriteLine($"{fileType} type is playing");
            }
            else
            {
                if (_nextHandler != null)
                {
                    _nextHandler.Player(fileType);
                }
            }
        }
    }
}
