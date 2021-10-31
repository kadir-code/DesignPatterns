using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseKullanımı
{
    //A Bden kalıtım alıyor
    public class A : B
    {
        #region sınıf kullanımı
        //public void Yaz()
        //{
        //    base.Yaz();
        //    Console.WriteLine("A metodu");
        //}
        #endregion

        //burda parametresiz a çalışınca bye 5 gitsin dedik
        public A():base(5)
        {
            Console.WriteLine("A ctoru");
        }
        //parametreli çalışınca aynı parametre b ye de gitsin dedik ya da 8 gitsin
        public A(int x):base(
            8)
        {
            Console.WriteLine("A parametreli ctoru"+x);
        }

    }
}
