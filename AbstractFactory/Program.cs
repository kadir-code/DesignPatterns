using AbstractFactory.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            SamsungFactory samsungFactory = new SamsungFactory();
            samsungFactory.CreatePhone("s8", "500mah");
        }
    }
}
