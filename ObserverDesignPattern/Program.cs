using ObserverDesignPattern.Concrete;
using ObserverDesignPattern.ObserverManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.AddObserver(new EmployeeObserver());
            product.AddObserver(new ManagerObserver());

            //product.Name = "Lamp";
            //product.Code = "12lm3";
            //product.Category = "Home Stuff";
            product.Produce = true;

            Console.ReadKey(true);

        }
    }
}
