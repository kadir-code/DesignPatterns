using BridgeDesignPattern.Abstract;
using BridgeDesignPattern.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Abstraction abstractionA = new Abstraction(new ImplementationA());
            Abstraction abstractionB = new Abstraction(new ImplementationB());

            Console.WriteLine(abstractionA.Operation());
            Console.WriteLine(abstractionB.Operation());
            Console.ReadKey();

        }
    }
}
