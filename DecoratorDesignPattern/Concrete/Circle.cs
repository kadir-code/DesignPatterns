using DecoratorDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.Concrete
{
    class Circle : IShape
    {
        public void Draw(int size, int location)
        {
            Console.Write("Circle Drawed  ");
        }
        /*
         * Only the edges of the circle can be colored,
         * Only the inside of the circle can be colored, 
         * The sides and the inside can be colored at the same time.
         */

        //we can write all of this insice circle but, we will use decorater based pattern.
    }
}
