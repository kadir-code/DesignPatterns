using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Singleton
    {
        private static Singleton _instance;
        private static object _lockObject = new object();//Made thread safe for multi-thread applications.
        private Singleton() { }

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                lock (_lockObject)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();

                    }
                }
            }
            return _instance;

        }
    }
    class WhenUseSingleton
    {
        //Singleton singleton = new Singleton(); Dont work
        Singleton singleton = Singleton.GetInstance();
    }
}
/*
 The Logic:
It is to ensure that the instance of a class is unique at runtime. 
With the constructor method marked as private, it cannot be used by 
the instance constructor at runtime. Instead, a method is defined as a 
static method if it does not exist before, it is produced, and if 
there is, it is intended to be used without generating a new one.
 */
