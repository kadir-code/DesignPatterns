using BuilderPattern.Builder;
using BuilderPattern.ConcreteBuilder;
using BuilderPattern.Director;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
         CarBuilder car = new OpelBuilder();
         CreateCar create = new CreateCar();
         create.Create(car);
            Console.WriteLine(car.Car.ToString());
            Console.Read();

        }
    }
}
