using DecoratorDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.Decorators
{
    public class CircleFill:Decorator
    {
        readonly IShape _shape;
        public CircleFill(IShape shape) : base(shape)
        {
            _shape = shape;
        }
        private void ColorFill()
        {
            Console.WriteLine("Colored inside circle");
        }
        public override void Draw(int size, int location)
        {
            base.Draw(size, location);
            ColorFill();
        }
    }
}
