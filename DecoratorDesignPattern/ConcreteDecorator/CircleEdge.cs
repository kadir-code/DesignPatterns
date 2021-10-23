using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorDesignPattern.Decorators;
using DecoratorDesignPattern.Interface;

namespace DecoratorDesignPattern.ConcreteDecorator
{
    public class CircleEdge: Decorator
    {
        readonly IShape _shape;
        public CircleEdge(IShape shape) : base(shape)
        {
            _shape = shape;
        }
        private void ColorEdge()
        {
            Console.WriteLine("Colored edges");
        }
        public override void Draw(int size, int location)
        {
            base.Draw(size, location);
            ColorEdge();
        }
    }
}

