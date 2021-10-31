using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseKullanımı
{
    public class B
    {
        #region sınıf kullanımı
        //public void Yaz()
        //{
        //    Console.WriteLine("B metodu");
        //}
        #endregion

        public B()
        {
            Console.WriteLine(  "B ctoru");
        }
        public B(int x)
        {
            Console.WriteLine("B parametreli  ctoru"+x);

        }

    }
}
