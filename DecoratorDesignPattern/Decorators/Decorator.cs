using DecoratorDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.Decorators
{
    public class Decorator : IShape
    {
        readonly IShape _shape=null;
        public Decorator(IShape shape)
        {
            _shape = shape;
        }
        public virtual void Draw(int size, int location)
        {
            _shape.Draw(size,location);
        }
    }
}
