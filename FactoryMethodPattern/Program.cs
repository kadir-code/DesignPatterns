using FactoryMethodPattern.Factory;
using FactoryMethodPattern.SecondImplementation.Concrete;
using FactoryMethodPattern.SecondImplementation.Factory;
using FactoryMethodPattern.SecondImplementation.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region First implementation

            //Createor createor = new Createor();
            //Screen screen = createor.ScreenFactory(Enum.ScreenModel.Desktop);
            //screen.Draw();

            #endregion

            #region Phone example
            IPhone phone = PhoneFactory.GetPhone("Iphone", "560mah");
            IPhone phone1 = PhoneFactory.GetPhone("Samsung", "1000mah");
            Console.WriteLine(phone);
            Console.WriteLine(phone1);
            #endregion
            Console.Read();
        }
    }
}
