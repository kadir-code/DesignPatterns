using DecoratorDesignPattern.Concrete;
using DecoratorDesignPattern.ConcreteDecorator;
using DecoratorDesignPattern.Decorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("circle");
            Circle circle = new Circle();
            //circle.Draw(10,100);

            CircleEdge circleEdge = new CircleEdge(new CircleFill(circle));
            circleEdge.Draw(20, 20);

            //CircleFill circleFill = new CircleFill(circle);
            //circleFill.Draw(12,82);

            Console.Read();
        }
    }
}
