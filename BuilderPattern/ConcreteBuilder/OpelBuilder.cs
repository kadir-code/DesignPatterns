using BuilderPattern.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.ConcreteBuilder
{
    class OpelBuilder : CarBuilder
    {
        public override void SetBrand()
        {
            _car.Brand = "opel";
        }

        public override void SetKM()
        {
            _car.KM = 500;
        }

        public override void SetModel()
        {
            _car.Model = "astra";
        }
    }
}
