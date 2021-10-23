using BuilderPattern.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Builder
{
    abstract class CarBuilder
    {
        protected Car _car=null;
        public Car Car
        {
            get { return _car; }
        }
        public abstract void SetBrand();
        public abstract void SetModel();
        public abstract void SetKM();
    }
}
